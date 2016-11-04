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

        string[] commands = new string[] {
            "toggleconsole", "previewshot", "redirect_shoot", "rebound_shoot",
            "defender_start", "defender_stop", "respawnboost", "training_predictball"
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

            foreach (ComboBox cmb in commandBoxes)
                cmb.Items.AddRange(commands);
            foreach (ComboBox cmb in keyBoxes)
                cmb.Items.AddRange(keycodes);

            cmbMaps.Items.AddRange(maps);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < commandBoxes.Count; i++)
            {
                commandBoxes[i].SelectedIndex = i;
                keyBoxes[i].SelectedIndex = i;
            }

            cmbGameSpeed.SelectedIndex = 0;
            cmbMaps.SelectedIndex = 0;

            btnLoad.PerformClick();
        }

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

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                StreamWriter sw = new StreamWriter(Application.StartupPath + "\\cfg\\config.cfg");
                sw.WriteLine("// Re-initialise all the keys");
                // Initialise the keycodes for when changing on the fly
                for (int i = 0; i < keycodes.Length; i++)
                    sw.WriteLine("bind " + keycodes[i] + " \"\"");

                // Write the new keys
                sw.WriteLine("// Bind the new keys");
                for (int i = 0; i < commandBoxes.Count; i++)
                    sw.WriteLine("bind " + keyBoxes[i].SelectedItem.ToString() + " \"" + commandBoxes[i].SelectedItem.ToString() + "\"");

                // Write the others tab
                if(chkGameSpeed.Checked)
                    sw.WriteLine("bind " + cmbGameSpeed.SelectedItem.ToString() + " \"gamespeed " + gameSpeed + "\"");
                else
                    sw.WriteLine("// bind " + cmbGameSpeed.SelectedItem.ToString() + " \"gamespeed " + gameSpeed + "\"");

                if(chkLoadMap.Checked)
                    sw.WriteLine("loadmap " + cmbMaps.SelectedItem.ToString());
                else
                    sw.WriteLine("// loadmap " + cmbMaps.SelectedItem.ToString());
                sw.Flush();
                sw.Close();
                MessageBox.Show("Saved, reload in game console.");
            } catch (Exception) { MessageBox.Show("Something went wrong setting the cfg. \nEnsure that there are no blank selections."); }
        }

        // Needed in case the user's current config file is outdated (otherwise they can't reload)
        /** Automatically run on load */
        private void btnLoad_Click(object sender, EventArgs e)
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
                } catch (Exception) { MessageBox.Show("Something went wrong reading the cfg. Ensure that it is in cfg\\config.cfg"); return; }
                
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
                for (int i = 0; i < values.Length; i+=2)
                { 
                    keyBoxes[x].SelectedIndex = keyBoxes[x].Items.IndexOf(values[i]);
                    x++;
                }

                x = 0;
                for (int i = 1; i < values.Length; i += 2)
                {
                    commandBoxes[x].SelectedIndex = commandBoxes[x].Items.IndexOf(values[i]);
                    x++;
                }
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
                catch (Exception) { MessageBox.Show("Game Speed found is not a double (e.g 1.0)\n Or there was an issue with the line it was bound on"); }

                txtGameSpeed.Text = "" + gameSpeed;
                // Set map to load
                cmbMaps.SelectedIndex = cmbMaps.Items.IndexOf(values2[2]);
                
    
            } catch (Exception) { MessageBox.Show("Your config file is outdated. \nPlease backup your config and click 'Save' to generate a new one."); }
        }

        // Show the commands window
        private void btnCommands_Click(object sender, EventArgs e)
        {
            form2.Show();
        }

        private void btnRemoveRow_Click(object sender, EventArgs e)
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
                tabControl1.MaximumSize = new Size(tabControl1.Width, tabControl1.Height - 27);
                tabControl1.MinimumSize = new Size(tabControl1.Width, tabControl1.Height - 27);
                this.MaximumSize = new Size(Width, Height - 27);
                this.MinimumSize = new Size(Width, Height - 27);

                tabControl1.Size = tabControl1.MaximumSize;
            }
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
            commandBoxes[commandBoxes.Count - 1].Items.AddRange(commands);
            tabControl1.GetControl(0).Controls.Add(commandBoxes[commandBoxes.Count - 1]);
            // Keys
            keyBoxes.Add(new ComboBox());
            keyBoxes[keyBoxes.Count - 1].FlatStyle = FlatStyle.Flat;
            keyBoxes[keyBoxes.Count - 1].DropDownStyle = ComboBoxStyle.DropDownList;
            keyBoxes[keyBoxes.Count - 1].Size = new Size(208, 21);
            keyBoxes[keyBoxes.Count - 1].Location = new Point(keyBoxes[keyBoxes.Count - 2].Location.X, keyBoxes[keyBoxes.Count - 2].Location.Y + 27);
            tabControl1.GetControl(0).Controls.Add(keyBoxes[keyBoxes.Count - 1]);
            keyBoxes[keyBoxes.Count - 1].Items.AddRange(keycodes);
            // Set new size
            tabControl1.MaximumSize = new Size(tabControl1.Width, tabControl1.Height + 27);
            tabControl1.MinimumSize = new Size(tabControl1.Width, tabControl1.Height + 27);
            this.MaximumSize = new Size(Width, Height + 27);
            this.MinimumSize = new Size(Width, Height + 27);
        }

        // Running the injector from the application
        private void btnRunInjector_Click(object sender, EventArgs e)
        {
            Console.WriteLine(Application.StartupPath);
            ProcessStartInfo injector = new ProcessStartInfo(Application.StartupPath + "\\BakkesModInjector.exe");
            Process.Start(injector);
        }

        // Loading the config in RocketLeague
        private void btnApplyConfig_Click(object sender, EventArgs e)
        {

        }
    }
}
