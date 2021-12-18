# ambrosial
![GitHub](https://img.shields.io/github/license/disepi/ambrosial)
![Lines of code](https://img.shields.io/tokei/lines/github/disepi/ambrosial)
![GitHub last commit](https://img.shields.io/github/last-commit/disepi/ambrosial)
> A launcher made for MC:BE mods
> 
Ambrosial is a launcher for Minecraft: Bedrock Edition (specifically Windows 10 Edition) modifications. The source code is here for you to check for any malicious code, or if you're just curious.

## How it works
Ambrosial sends a download request to the server to download an encrypted JSON file (can be generated using the developer form) and then decrypts it and adds the modification's buttons and such to a windows form, then attaches events to the buttons. You can see how this works in more detail in the source code.

## Building
To build Ambrosial, you need to install multiple NuGET psckages after installing the source. You also need to use a version of Visual Studio to compile. The packages you need to install are
- DiscordRichPresence
- Costura.Fody
- Newtonsoft.JSON
- Guna.UI2.WinForms
That's basically you need!
