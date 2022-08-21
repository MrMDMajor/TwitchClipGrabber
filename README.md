# TwitchClipGrabber
Easy tool for downloading Twitch clips




![Text](https://i.imgur.com/0k7U5DN.png)

-----------------------------------------------------
<b>.NET 5.0 is required, go to https://dotnet.microsoft.com/en-us/download/dotnet/5.0 and install .NET Desktop Runtime</b>

To Build
---
- Download code as .zip and extract it to wherever you would like
- Open a command prompt and navigate to the folder where .sln file is located
- Type or copy/paste `dotnet build -c release`
- Built project will be located in `bin\release\net5.0-windows` folder

----

- Upon first launch, you will be prompted to authenticate with Twitch
- If Authenticate window does not show, click 'Authenticate' button and log in to Twitch

- You can set the format of the downloaded files in the `Settings` dialog. Click the `?` button for help with the proper formatting.

Note
---
This program does not currently support downloading clips from VODs which are no longer available.
