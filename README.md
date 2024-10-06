# TwitchClipGrabber
Easy Windows tool for downloading Twitch clips

![Text](https://i.imgur.com/sHKFVRR.png)

-----------------------------------------------------
<b>.NET 8 is required, go to https://dotnet.microsoft.com/en-us/download/dotnet/8.0 and install latest .NET Desktop Runtime</b>

To Build
---
- Download code as .zip and extract it to wherever you would like
- Open a command prompt and navigate to the folder where .sln file is located
- Type or copy/paste `dotnet build -c release`
- Built project will be located in `bin\release\[version]` folder

----

- Upon first launch, you will be prompted to authenticate with Twitch
- If Authenticate window does not show, click 'Authenticate' button and log in to Twitch

- You can set the format of the downloaded files in the `Settings` dialog. Click the `?` button for help with the proper formatting.

Note
---
This program does not currently support downloading clips from VODs which are no longer available.
