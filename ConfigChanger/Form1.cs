using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

/** Futureproof Modularity for custom plugins by reading commands from text files in a specific folder. */
namespace ConfigChanger
{
    public partial class Form1 : Form
    {
        [DllImport("user32.dll")]
        static extern int SetForegroundWindow(IntPtr point);

        Form2 form2 = new Form2();

        private int otherOptions = 2; // Amount of other options that are saved (for reading from file)
        private double gameSpeed = 1.0f; // Holder for the GUI
        private int numComments = 2; // Amount of comments in the file

        private string dirCommands = @"plugins\commands\";
        private string dirPlugins = @"plugins";
        private string pluginsConfig = @"plugins.cfg";
        private string pluginsDat = @"plugins.dat";
        private string guiConfigLocation = @"cfg\GUIConfig\";
        private List<string> dirConfigFiles = new List<string>() { @"default.cfg", @"bindings.cfg", @"customCode.cfg", @"plugins.cfg", @"otherOptions.cfg" }; // Each plugin has it's own config file for advanced modularity
        private List<string> loadedPlugins = new List<string>(); // All the plugins that have been loaded, grabbed from the plugins list and saved. Used for reading and writing to cfg file
        private List<string> pluginsToUnload = new List<string>(); // All the plugins that will be unloaded on the next configuration run
        private List<string> unloadedPlugins = new List<string>(); // All the plugins in the 'plugins' folder that aren't currently loaded
        List<string> commands = new List<string>();

        private string[] keycodes = new string[]
        {
            "XboxTypeS_LeftX",
            "XboxTypeS_LeftY",
            "XboxTypeS_RightX",
            "XboxTypeS_RightY",
            "XboxTypeS_LeftThumbStick",
            "XboxTypeS_RightThumbStick",
            "XboxTypeS_Back",
            "XboxTypeS_Start",
            "XboxTypeS_Special_Left",
            "XboxTypeS_Special_Right",
            "XboxTypeS_FaceButton_Bottom",
            "XboxTypeS_FaceButton_Right",
            "XboxTypeS_FaceButton_Left",
            "XboxTypeS_FaceButton_Top",
            "XboxTypeS_LeftShoulder",
            "XboxTypeS_RightShoulder",
            "XboxTypeS_LeftTrigger",
            "XboxTypeS_RightTrigger",
            "XboxTypeS_LeftTriggerAxis",
            "XboxTypeS_RightTriggerAxis",
            "XboxTypeS_DPad_Up",
            "XboxTypeS_DPad_Down",
            "XboxTypeS_DPad_Right",
            "XboxTypeS_DPad_Left",
            "XboxTypeS_Y",
            "XboxTypeS_X",
            "XboxTypeS_B",
            "XboxTypeS_A",
            "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "zero",
            "Q", "W", "E", "R", "T", "Y", "U", "I", "O", "P",
            "A", "S", "D", "F", "G", "H", "J", "K", "L",
            "Z", "X", "C", "V", "B", "N", "M",
            "Tilde",
            "Underscore",
            "Equals",
            "LeftBracket",
            "RightBracket",
            "Backslash",
            "Comma",
            "Period",
            "Slash",
            "Tab",
            "Caps-Lock",
            "LeftShift",
            "RightShift",
            "LeftControl",
            "RightControl",
            "LeftAlt",
            "RightAlt",
            "SpaceBar",
            "Left",
            "Up",
            "Down",
            "Right",
            "Home",
            "End",
            "Insert",
            "PageUp",
            "Delete",
            "PageDown",
            "NumLock", "Divide", "Multiply", "Subtract", "Add",
            "NumPadOne", "NumPadTwo", "NumPadThree",
            "NumPadFour", "NumPadFive", "NumPadSix",
            "NumPadSeven", "NumPadEight", "NumPadNine",
            "NumPadZero", "Decimal"
        };

        string[] maps = new string[]
        {
            "cosmic", "doublegoal", "eurostadium", "eurostadium_rainy", "hoops",
            "utopia", "labs_utopia", "utopia_dusk", "neotokyo", "park", "park_night",
            "park_rainy", "stadium", "stadium_winter", "trainstation", "trainstation_night",
            "underpass", "wasteland"
        };

        List<ComboBox> commandBoxes = new List<ComboBox>();
        List<ComboBox> keyBoxes = new List<ComboBox>();

        public Form1()
        {
            InitializeComponent();
            // First run? (since default cfg doesn't exist)
            if (!File.Exists(AppDomain.CurrentDomain.BaseDirectory + guiConfigLocation + dirConfigFiles[0]))
            {
                MessageBox.Show("This is the first time you have run the GUI\nThe necessary files will be created.", "Press OK");
                firstRun();
            }

            //System.Threading.Thread.Sleep(3000);
            loadPlugins();
            // Get plugins that are unloaded
            refreshUnloadedPlugins();
            // Must be after plugins so it can load the commands
            //initConfigFiles();
            initCommands();
            // Add references to default boxes
            commandBoxes.Add(cmbCommand1);
            commandBoxes.Add(cmbCommand2);
            commandBoxes.Add(cmbCommand3);
            commandBoxes.Add(cmbCommand4);
            // Keys
            keyBoxes.Add(cmbKey1);
            keyBoxes.Add(cmbKey2);
            keyBoxes.Add(cmbKey3);
            keyBoxes.Add(cmbKey4);

            try
            {
                foreach (ComboBox cmb in commandBoxes)
                    cmb.Items.AddRange(commands.ToArray());
            }
            catch (ArgumentNullException) { MessageBox.Show("No Command files are present in \n'" + dirCommands + "'", "No Problem."); }
            foreach (ComboBox cmb in keyBoxes)
                cmb.Items.AddRange(keycodes);

            cmbMaps.Items.AddRange(maps);

        }
        
        private void firstRun()
        {
            initConfigFiles();
            // Plugins dat
            var myfile = File.Create(AppDomain.CurrentDomain.BaseDirectory + guiConfigLocation + pluginsDat);
            myfile.Close();
            // Plugins config
            var myfile2 = File.Create(AppDomain.CurrentDomain.BaseDirectory + guiConfigLocation + pluginsConfig);
            myfile2.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnLoad.PerformClick();
        }



        /// <summary>
        /// General
        /// </summary>
        private void btnSave_Click(object sender, EventArgs e)
        {
            saveConfigFiles();
            savePlugins();
            saveCustomCode();
        }

        // Needed in case the user's current config file is outdated (otherwise they can't reload)
        /** Automatically run on load */
        private void btnLoad_Click(object sender, EventArgs e)
        {
            List<string> bindLines = new List<string>();

            // Splitting the string
            string[] separators = { " ", "\"", "bind" };
            try
            {
                // Get Binding Lines
                try
                {
                    bindLines = File.ReadAllLines(AppDomain.CurrentDomain.BaseDirectory + guiConfigLocation + dirConfigFiles[1]).ToList();
                }
                catch (Exception) { MessageBox.Show("Something went wrong reading the cfg. Ensure that it is in '" + guiConfigLocation + dirConfigFiles[0] + "'", "Oops!"); return; }



                // Format the result for the first tab (Bindings)
                string t = "";
                foreach (string s in bindLines)
                {
                    if (!s.Contains("//"))
                        t += s;
                }

                string[] values = t.Split(separators, StringSplitOptions.RemoveEmptyEntries);

                // Add rows
                for (int i = 0; i < values.Length; i++)
                {
                    if (commandBoxes.Count < values.Length / 2)
                        addBind();
                    //Console.WriteLine(values[i]);
                }

                // Add plugin 
                int x = 0;
                bool pluginMissing = false;
                string missingPluginsNames = "";
                for (int i = 0; i < values.Length; i += 2)
                {
                    keyBoxes[x].SelectedIndex = keyBoxes[x].Items.IndexOf(values[i]);
                    x++;
                }

                x = 0;
                for (int i = 1; i < values.Length; i += 2)
                {
                    commandBoxes[x].SelectedIndex = commandBoxes[x].Items.IndexOf(values[i]);
                    if (commandBoxes[x].SelectedIndex == -1)
                    {
                        missingPluginsNames += "\n" + values[i];
                        pluginMissing = true;
                    }
                    x++;
                }
                if (pluginMissing)
                    MessageBox.Show("One or more the plugins that you have bound actions from \nno longer exists in the 'plugins' folder.\nAll Command Bindings from this plugin will be discarded if you save.\n\nCommands missing:" + missingPluginsNames, "Noooooo!");

                // Other Options (Game Speed, Map, perhaps boost amount?)
                List<string> otherOps = new List<string>();
                string v = "";
                try { otherOps = File.ReadAllLines(AppDomain.CurrentDomain.BaseDirectory + guiConfigLocation + dirConfigFiles[4]).ToList(); }
                catch (Exception) { MessageBox.Show("Something went wrong reading the other options config. Ensure that it is in '" + guiConfigLocation + dirConfigFiles[4] + "'", "Oops!"); return; }

                foreach (string s in otherOps) v += s;

                string[] separators2 = new string[] { "loadmap", "gamespeed", "bind", "\"", " ", "//" };
                string[] values2 = v.Split(separators2, StringSplitOptions.RemoveEmptyEntries);
                foreach (string s in values2)
                    Console.WriteLine(s);

                if (otherOps[0].Contains("//"))
                    chkGameSpeed.Checked = false;
                else
                    chkGameSpeed.Checked = true;
                if (otherOps[1].Contains("//"))
                    chkLoadMap.Checked = false;
                else
                    chkLoadMap.Checked = true;


                // Set the game speed Key and Speed
                try
                {
                    cmbGameSpeed.SelectedIndex = cmbGameSpeed.Items.IndexOf(values2[0]);
                    gameSpeed = double.Parse(values2[1]);
                }
                catch (Exception) { MessageBox.Show("Game Speed found is not a double (e.g 1.0)\n Or there was an issue with the line it was bound on", "No Way!"); }

                txtGameSpeed.Text = "" + gameSpeed;

                // Set map to load
                cmbMaps.SelectedIndex = cmbMaps.Items.IndexOf(values2[2]);

                // Custom Code
                loadCustomCode();

            }
            catch (Exception) { MessageBox.Show("Your current configuration will not run. \nPlease backup your config and click 'Save' to generate a new one.\n\n If this is your first time running, please create a configuration.", "Nice Shot!"); }
        }

        // Show the commands window
        private void btnCommands_Click(object sender, EventArgs e)
        {
            form2.Show();
        }

        // Running the injector from the application
        private void btnRunInjector_Click(object sender, EventArgs e)
        {
            Console.WriteLine(Application.StartupPath);
            try
            {
                ProcessStartInfo injector = new ProcessStartInfo(Application.StartupPath + "\\BakkesModInjector.exe");
                injector.Verb = "runas";
                Process.Start(injector);
            }
            catch (Win32Exception) { MessageBox.Show("The injector must be present in the root folder", "Injector not found"); }

        }

        // Loading the config in RocketLeague
        private void btnApplyConfig_Click(object sender, EventArgs e)
        {
            if (Process.GetProcessesByName("BakkesModInjector.exe").Length == 0)
            {
                MessageBox.Show("Injector must be running to apply the Configuration files");
                return;
            }

            if (Process.GetProcessesByName("rocketleague.exe").Length == 0)
            {
                MessageBox.Show("RocketLeague must be running to apply the Configuration files");
                return;
            }

            btnSave.PerformClick();

            try
            {
                // Get first process with this name
                Process p = Process.GetProcessesByName("rocketleague")[0];

                IntPtr pointer = p.MainWindowHandle;
                SetForegroundWindow(pointer);
                // Execute each of the config files
                SendKeys.SendWait("`");
                foreach (string s in loadedPlugins) // Load the plugins advanced file
                {
                    string send = @"exec GUIConfig\" + s + @"{ENTER}";
                    Console.WriteLine(send);
                    SendKeys.SendWait(send);
                }
                foreach (string s in dirConfigFiles) // Load the default config files
                {
                    string send = @"exec GUIConfig\" + Path.GetFileNameWithoutExtension(s) + @"{ENTER}";
                    Console.WriteLine(send);
                    SendKeys.SendWait(send);
                }
                SendKeys.SendWait("`");
            }
            catch (IndexOutOfRangeException) { MessageBox.Show("Rocket League must be launched \nto apply the configuration in-game", "Whoops..."); }
        }

        private void btnWiki_Click(object sender, EventArgs e)
        {
            Process.Start("http://bakkesmod.wikia.com/wiki/BakkesModGUI_(WIP)");
        }


        /// <summary>
        /// Initialisation
        /// </summary>
        private void initCommands()
        {
            List<string> newCommands = new List<string>();
            string[] fileCommands = null; // Required in case something is wrong with the commands in the file
            string[] files = null;
            // Gets command files, creates directory if it doesn't exist
            try { files = Directory.GetFiles(AppDomain.CurrentDomain.BaseDirectory + dirCommands); }
            catch (DirectoryNotFoundException)
            {
                MessageBox.Show("'" + dirCommands + "' did not exist, created!");
                Directory.CreateDirectory(AppDomain.CurrentDomain.BaseDirectory + dirCommands);
                return;
            }

            // Load commands
            foreach (string s in files)
            {
                Console.WriteLine(s);
                if (s.EndsWith(".bnd"))
                {
                    // Make sure the plugin is loaded
                    if (lstLoadedPlugins.Items.Contains(Path.GetFileNameWithoutExtension(s)) || s.EndsWith("GenericBindings.bnd"))
                    {
                        // Get commands
                        try
                        {
                            fileCommands = File.ReadAllLines(s);

                            foreach (string t in fileCommands)
                            {
                                if (!t.Contains(" "))
                                    newCommands.Add(t);
                                else
                                    MessageBox.Show("Could not add command '" + t + "' (Contains a space)\n\nCommands file: " + s + "\n\nAll other commands from the file have been added.", "Savage!");
                            }
                        }
                        catch (Exception) { MessageBox.Show("There is something wrong with Commands file \n" + s, "What a save!"); }
                    }
                }
            }

            commands = newCommands;
        }

        private void initConfigFiles()
        {
            // Create Config Location if it doesn't exist
            Directory.CreateDirectory(guiConfigLocation);
            // Create config files if they don't exist
            foreach (string s in dirConfigFiles)
            {
                if (!File.Exists(AppDomain.CurrentDomain.BaseDirectory + guiConfigLocation + s))
                {
                    var myfile = File.Create(AppDomain.CurrentDomain.BaseDirectory + guiConfigLocation + s);
                    myfile.Close();
                }
            }
            if (!File.Exists(AppDomain.CurrentDomain.BaseDirectory + guiConfigLocation + pluginsConfig))
            {
                var myfile = File.Create(AppDomain.CurrentDomain.BaseDirectory + guiConfigLocation + pluginsConfig);
                myfile.Close();
            }
        }




        /// <summary>
        /// Bindings tab
        /// </summary>
        private void btnRemoveRow_Click(object sender, EventArgs e)
        {
            removeBind();
        }

        private void btnAddRow_Click(object sender, EventArgs e)
        {
            addBind();
        }

        // Used when addrow is clicked and also when reading from cfg
        private void addBind()
        {
            // Params: Box is 27 below the last one. Box is 208, 21 in size.
            // Command
            commandBoxes.Add(new ComboBox());
            commandBoxes[commandBoxes.Count - 1].FlatStyle = FlatStyle.Flat;
            commandBoxes[commandBoxes.Count - 1].DropDownStyle = ComboBoxStyle.DropDownList;
            commandBoxes[commandBoxes.Count - 1].Size = new Size(208, 21);
            commandBoxes[commandBoxes.Count - 1].Location = new Point(commandBoxes[commandBoxes.Count - 2].Location.X, commandBoxes[commandBoxes.Count - 2].Location.Y + 27);
            commandBoxes[commandBoxes.Count - 1].Items.AddRange(commands.ToArray());
            tabCustomConfig.GetControl(0).Controls.Add(commandBoxes[commandBoxes.Count - 1]);
            // Keys
            keyBoxes.Add(new ComboBox());
            keyBoxes[keyBoxes.Count - 1].FlatStyle = FlatStyle.Flat;
            keyBoxes[keyBoxes.Count - 1].DropDownStyle = ComboBoxStyle.DropDownList;
            keyBoxes[keyBoxes.Count - 1].Size = new Size(208, 21);
            keyBoxes[keyBoxes.Count - 1].Location = new Point(keyBoxes[keyBoxes.Count - 2].Location.X, keyBoxes[keyBoxes.Count - 2].Location.Y + 27);
            tabCustomConfig.GetControl(0).Controls.Add(keyBoxes[keyBoxes.Count - 1]);
            keyBoxes[keyBoxes.Count - 1].Items.AddRange(keycodes);
            // Set new size
            tabCustomConfig.MaximumSize = new Size(tabCustomConfig.Width, tabCustomConfig.Height + 27);
            tabCustomConfig.MinimumSize = new Size(tabCustomConfig.Width, tabCustomConfig.Height + 27);
            this.MaximumSize = new Size(Width, Height + 27);
            this.MinimumSize = new Size(Width, Height + 27);
        }

        // Used when removerow is clicked
        private void removeBind()
        {
            // ensure there is at least one row
            if (keyBoxes.Count > 1)
            {
                // Remove the controls
                tabPage1.Controls.RemoveAt(tabPage1.Controls.IndexOf(keyBoxes[keyBoxes.Count - 1]));
                tabPage1.Controls.RemoveAt(tabPage1.Controls.IndexOf(commandBoxes[commandBoxes.Count - 1]));
                keyBoxes.RemoveAt(keyBoxes.Count - 1);
                commandBoxes.RemoveAt(commandBoxes.Count - 1);
                // Resize
                tabCustomConfig.MaximumSize = new Size(tabCustomConfig.Width, tabCustomConfig.Height - 27);
                tabCustomConfig.MinimumSize = new Size(tabCustomConfig.Width, tabCustomConfig.Height - 27);
                this.MaximumSize = new Size(Width, Height - 27);
                this.MinimumSize = new Size(Width, Height - 27);

                tabCustomConfig.Size = tabCustomConfig.MaximumSize;
            }
        }




        /// <summary>
        /// Other Options
        /// </summary>
        private void btnSpeedAdd_Click(object sender, EventArgs e)
        {
            if (gameSpeed < 10.0f)
                gameSpeed += 0.1f;

            gameSpeed = Math.Truncate(gameSpeed * 10) / 10;
            txtGameSpeed.Text = "" + gameSpeed;
        }

        private void btnSpeedSub_Click(object sender, EventArgs e)
        {
            if (gameSpeed > 0.19f)
                gameSpeed -= 0.10f;

            gameSpeed += 0.01f;
            gameSpeed = Math.Truncate(gameSpeed * 10) / 10;
            txtGameSpeed.Text = "" + gameSpeed;
        }




        /// <summary>
        /// Plugins
        /// </summary>
        private void btnUnloadPlugin_Click(object sender, EventArgs e)
        {
            try
            {
                string unloadedPlugin = lstLoadedPlugins.GetItemText(lstLoadedPlugins.SelectedItem);
                unloadPlugin(unloadedPlugin);
                refreshUnloadedPlugins();
            }
            catch (ArgumentOutOfRangeException) { Console.WriteLine("Nothing Selected"); /* User did not select a plugin, do nothing */ }
        }

        private void btnLoadPlugin_Click(object sender, EventArgs e)
        {
            // Initial checks
            string fileName = lstUnloadedPlugins.GetItemText(lstUnloadedPlugins.SelectedItem);
            if (fileName == "")
                return;

            if (lstLoadedPlugins.Items.Contains(fileName))
            {
                MessageBox.Show("Plugin is already loaded", "Whoops!");
                return;
            }

            // Loading
            loadedPlugins.Add(fileName);
            lstLoadedPlugins.Items.Add(fileName);
            // Refresh the unloaded list
            refreshUnloadedPlugins();

            loadPlugin(fileName);
        }

        private void loadPlugin (string fileName)
        {
            if (!dirConfigFiles.Contains(@fileName + ".cfg"))
            {
                dirConfigFiles.Add(@fileName + ".cfg");
                // Create the config file for this plugin
                createConfig(fileName);
            }

            string[] _commands = null;
            try
            {
                _commands = File.ReadAllLines(AppDomain.CurrentDomain.BaseDirectory + dirCommands + fileName + ".bnd");

                // Add commands if they dont exist
                foreach (string s in _commands)
                {
                    if (!commands.Contains(s))
                    {
                        Console.WriteLine("not contains");
                        commands.Add(s);
                        foreach (ComboBox c in commandBoxes)
                            if (!c.Items.Contains(s))
                                c.Items.Add(s);
                    }
                }
            }
            catch (FileNotFoundException) { MessageBox.Show("No Command file present for selected plugin", "Whoops!"); }
            catch (Exception) { MessageBox.Show("Something went wrong loading the selected plugin's Command file.", "Oh No!"); }

            // Update the unloading array
            if (pluginsToUnload.Contains(fileName))
                pluginsToUnload.Remove(fileName);
        }

        private void unloadPlugin (string fileName)
        {
            loadedPlugins.Remove(fileName);
            lstLoadedPlugins.Items.Remove(fileName);

            try
            {
                string[] commandsToDelete = File.ReadAllLines(AppDomain.CurrentDomain.BaseDirectory + dirCommands + fileName + ".bnd");
                foreach (ComboBox c in commandBoxes)
                {
                    foreach (string s in commandsToDelete)
                    {
                        if (c.Items.Contains(s))
                            c.Items.Remove(s);
                        if (commands.Contains(s))
                            commands.Remove(s);
                    }
                }
            }
            catch (FileNotFoundException) { /* Thrown if there is no bind file. ignore. */ }
            // Change the unloading array
            if (!pluginsToUnload.Contains(fileName))
                pluginsToUnload.Add(fileName);
        }

        private void btnEditConfig_Click(object sender, EventArgs e)
        {
            try
            {
                createConfig(lstLoadedPlugins.SelectedItem.ToString());

                // Open the config
                Process.Start("notepad.exe", AppDomain.CurrentDomain.BaseDirectory + guiConfigLocation + lstLoadedPlugins.SelectedItem.ToString() + ".cfg");

            }
            catch (NullReferenceException) { Console.WriteLine("Nothing Selected to customise"); }
        }

        private void refreshUnloadedPlugins()
        {
            // Get plugins
            string[] s = Directory.GetFiles(Path.Combine(Application.StartupPath, dirPlugins));
            for (int x = 0; x < s.Length; x++)
                s[x] = Path.GetFileNameWithoutExtension(s[x]);
            unloadedPlugins = s.ToList();
            // Clear plugins list
            lstUnloadedPlugins.Items.Clear();
            // Get rid of it if it's loaded
            foreach (string t in loadedPlugins)
            {
                Console.WriteLine(t);
                if (unloadedPlugins.Contains(t))
                    unloadedPlugins.Remove(t);
            }

            foreach (string t in unloadedPlugins)
                lstUnloadedPlugins.Items.Add(Path.GetFileNameWithoutExtension(t));
        }

        private void saveConfigFiles()
        {
            StreamWriter sw = null;
            try
            {
                // Write the bindings
                sw = new StreamWriter(AppDomain.CurrentDomain.BaseDirectory + guiConfigLocation + dirConfigFiles[0]);
                // Initialise the keycodes for when changing on the fly
                sw.WriteLine("unbindall");
                sw.Flush();
            }
            catch (Exception) { MessageBox.Show("Error with initial unbinding, file: '" + guiConfigLocation + dirConfigFiles[0] + "'"); return; }
            finally { if (sw != null && sw.BaseStream != null) sw.Close(); }

            try
            {
                sw = new StreamWriter(AppDomain.CurrentDomain.BaseDirectory + guiConfigLocation + dirConfigFiles[1]);

                // Write the new keys
                for (int i = 0; i < commandBoxes.Count; i++)
                    sw.WriteLine("bind " + keyBoxes[i].SelectedItem.ToString() + " \"" + commandBoxes[i].SelectedItem.ToString() + "\"");

                sw.Flush();
            }
            catch (Exception) { MessageBox.Show("Error saving keybindings"); return; }
            finally { if (sw != null && sw.BaseStream != null) sw.Close(); }

            try
            {
                sw = new StreamWriter(AppDomain.CurrentDomain.BaseDirectory + guiConfigLocation + dirConfigFiles[4]);
                // Write the others tab
                if (chkGameSpeed.Checked)
                    sw.WriteLine("bind " + cmbGameSpeed.SelectedItem.ToString() + " \"gamespeed " + gameSpeed + "\"");
                else
                    sw.WriteLine("// bind " + cmbGameSpeed.SelectedItem.ToString() + " \"gamespeed " + gameSpeed + "\"");

                if (chkLoadMap.Checked)
                    sw.WriteLine("loadmap " + cmbMaps.SelectedItem.ToString());
                else
                    sw.WriteLine("// loadmap " + cmbMaps.SelectedItem.ToString());
                sw.Flush();
            }
            catch (NullReferenceException) { MessageBox.Show("Other options could not be saved as it contains empty dropdown lists"); return; }
            catch (IOException) { MessageBox.Show("Something has gone wrong accessing the other options file"); return; }
            catch (Exception) { MessageBox.Show("Something has gone wrong writing to the other options file"); return; }
            finally { if (sw != null && sw.BaseStream != null) sw.Close(); }
        }

        // Saves all the plugins to a data file for loading
        private void savePlugins()
        {
            try
            {
                loadedPlugins.Clear();
                foreach (string t in lstLoadedPlugins.Items)
                    loadedPlugins.Add(t);

                File.WriteAllLines(AppDomain.CurrentDomain.BaseDirectory + guiConfigLocation + pluginsDat, loadedPlugins);

            } catch (Exception) { MessageBox.Show("Plugins configuration file does not exist"); }

            savePluginConfig();
        }

        // Save the plugin configuration file
        private void savePluginConfig()
        {
            // Loading
            List<string> loadPluginsString = new List<string>();
            foreach (string s in lstLoadedPlugins.Items)
                loadPluginsString.Add("plugin load " + s);

            // Unloading
            foreach (string s in pluginsToUnload)
                loadPluginsString.Add("plugin unload " + s);

            // Apply config
            try
            {
                File.WriteAllLines(AppDomain.CurrentDomain.BaseDirectory + guiConfigLocation + pluginsConfig, loadPluginsString);
            }
            catch (Exception) { MessageBox.Show("Plugins configuration file does not exist"); }
        }

        private void loadPlugins()
        {
            // Add all the plugins from the file
            try
            {
                string[] s = File.ReadAllLines(AppDomain.CurrentDomain.BaseDirectory + guiConfigLocation + pluginsDat);
                loadedPlugins = s.ToList();
                lstLoadedPlugins.Items.Clear();
                foreach (string t in loadedPlugins)
                    lstLoadedPlugins.Items.Add(t);
            }
            catch (FileNotFoundException) { MessageBox.Show("Plugins configuration file does not exist"); }
            catch (Exception) { MessageBox.Show("Plugins configuration file is empty"); }
        }

        private void createConfig(string fileName)
        {
            // Where config should go
            string dir = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, guiConfigLocation, fileName + ".cfg");
            // Create config if it doesnt exist
            FileStream fs = null;
            try
            {
                if (!File.Exists(dir))
                {
                    fs = File.Create(dir);
                    fs.Close();
                }
            }
            catch (NullReferenceException)
            {
                fs = File.Create(dir);
                fs.Close();
            }
        }

        private void lstLoadedPlugins_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            btnUnloadPlugin.PerformClick();
        }

        private void lstUnloadedPlugins_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            btnLoadPlugin.PerformClick();
        }



        /// <summary>
        /// Custom Config tab
        /// </summary>
        private void saveCustomCode()
        {
            File.WriteAllText(AppDomain.CurrentDomain.BaseDirectory + guiConfigLocation + dirConfigFiles[2], txtCustomConfig.Text);
        }

        private void loadCustomCode()
        {
            txtCustomConfig.Clear();
            txtCustomConfig.Text = File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + guiConfigLocation + dirConfigFiles[2]);
        }





        // The old way of loading
        void old()
        {
            string[] linesFromFile;

            // Spliting the string
            string[] separators = {
                "// Re-initialise all the keys", "//  Bind the new keys",
                "//", " ", "\"",
                "bind", "loadmap", "gamespeed", "ball velocity", "(-400, 400)", "(1200, 1700)" };
            string totalString = "";
            string totalString2 = "";

            try
            {
                // Get everything
                try
                {
                    linesFromFile = File.ReadAllLines(Application.StartupPath + @"\cfg\config.cfg");
                }
                catch (Exception) { MessageBox.Show("Something went wrong reading the cfg. Ensure that it is in cfg\\config.cfg", "Oops!"); return; }

                // Format the result for the first tab (Bindings)
                for (int i = keycodes.Length + numComments; i < linesFromFile.Length - otherOptions; i++)
                    totalString += linesFromFile[i];
                string[] values = totalString.Split(separators, StringSplitOptions.RemoveEmptyEntries);
                //Console.WriteLine(totalString);
                for (int i = 0; i < values.Length; i++)
                {
                    if (commandBoxes.Count < values.Length / 2)
                        addBind();
                }

                int x = 0;
                bool pluginMissing = false;
                string missingPluginsNames = "";
                for (int i = 0; i < values.Length; i += 2)
                {
                    keyBoxes[x].SelectedIndex = keyBoxes[x].Items.IndexOf(values[i]);
                    x++;
                }

                x = 0;
                for (int i = 1; i < values.Length; i += 2)
                {
                    commandBoxes[x].SelectedIndex = commandBoxes[x].Items.IndexOf(values[i]);
                    if (commandBoxes[x].SelectedIndex == -1)
                    {
                        missingPluginsNames += "\n" + values[i];
                        pluginMissing = true;
                    }
                    x++;
                }
                if (pluginMissing)
                    MessageBox.Show("One or more the plugins that you have bound actions from \nno longer exists in the 'plugins' folder.\nAll Command Bindings from this plugin will be discarded if you save.\n\nCommands missing:" + missingPluginsNames, "Noooooo!");
                // ^^^ ALL WORKING ^^^

                // Other options are after all the generics and the dynamics
                int startPoint = linesFromFile.Length - otherOptions; // - 1 for the 0 start index 
                //Console.WriteLine(startPoint);
                for (int i = startPoint /* -1 for 0-index */; i < linesFromFile.Length; i++)
                    totalString2 += linesFromFile[i];
                Console.WriteLine(startPoint);
                Console.WriteLine(linesFromFile.Length);
                string[] values2 = totalString2.Split(separators, StringSplitOptions.RemoveEmptyEntries);

                // Set the game speed                
                try
                {
                    cmbGameSpeed.SelectedIndex = cmbGameSpeed.Items.IndexOf(values2[0]);
                    gameSpeed = double.Parse(values2[1]);
                }
                catch (Exception) { MessageBox.Show("Game Speed found is not a double (e.g 1.0)\n Or there was an issue with the line it was bound on", "No Way!"); }

                txtGameSpeed.Text = "" + gameSpeed;
                // Set map to load
                cmbMaps.SelectedIndex = cmbMaps.Items.IndexOf(values2[2]);


            }
            catch (Exception) { MessageBox.Show("Your current configuration will not run. \nPlease backup your config and click 'Save' to generate a new one.\n\n If this is your first time running, please disregard this message", "Nice Shot!"); }

        }

        private void btnLoadAll_Click(object sender, EventArgs e)
        {
            loadedPlugins.AddRange(unloadedPlugins);
            unloadedPlugins.Clear(); // It's empty since all are loaded
            
            // Refresh loaded plugins list
            lstLoadedPlugins.Items.Clear();
            foreach (string t in loadedPlugins)
            {
                lstLoadedPlugins.Items.Add(t);
                loadPlugin(t);
            }

            refreshUnloadedPlugins();
        }

        private void btnUnloadAll_Click(object sender, EventArgs e)
        {
            foreach(string s in loadedPlugins.ToList())
            {
                unloadPlugin(s);
            }

            refreshUnloadedPlugins();
        }
    }
}

