# BakkesModGUI
Custom GUI interface for BakkesMod, which is a RocketLeague trainer.

## Reason for creation
The trainer did not (at the time) have a user friendly GUI to create or change configuration for the users. This application provided that GUI.  
I was using the trainer at the time as it provides functionality not available in the game which help with skill building.

## Tech used
- C#
- Visual Studio

## Definition of done
This project will be defined as completed when it:
- [x] Provides a method for users to modify their configuration outside of the game.
- [x] Modifies configuration on the fly.
- [x] Saves user settings.
- [x] Can import settings.

### Stretch goals
There are a number of stretch goals which I would like to implement.
- [x] Integrates with the main application and is installed alongside it.
- [x] Has a wiki page that can be used by people to learn about the application.
    - As this project is now outdated and no longer in use, this page was removed.

## Retrospective
- Integrating with an existing application can be messy if it modifies it's exposed structure, especially when deploying updates.
- Visual studio doesn't provide a modern/sleek interface (a lot of applications are being created using Electron or Chromium).
- Good UX is difficult without a sample set of users.
- This application ended up falling behind in updates and was eventually superseded by an in-house variant from the creator of BakkesMod.
