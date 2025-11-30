# Base External Tools for BizHawk
This project is meant to be a very basic implementation based on the official [Development Quickstart](https://github.com/TASEmulators/BizHawk-ExternalTools/wiki/Development-quickstart) for ExternalTools in BizHawk so you can start writing your code. This project includes:

 - CS Project with the compilation setup.
 - Basic CS File that creates a form and implements the EmulationAPI to fetch the game name and update the label created alongside the form.

# Building

To build the project you will need [BizHawk 2.10](https://github.com/TASEmulators/BizHawk/releases/tag/2.10). You will also need [.NET 8.0](https://dotnet.microsoft.com/en-us/download/dotnet/8.0) and Visual Studio 2022 or later.

 1. Extract the contents of the BizHawk build in a folder called BizHawk inside this project (at the same level of src). 
 2. Open the project in Visual Studio.
 3. Go to Compile > Compile Solution. This should create the ExternalTools folder inside BizHawk and the .dll file.
 4. Then open a console/cmd inside the BizHawk folder and run `.\EmuHawk.exe --open-ext-tool-dll=ExternalToolTest`. This should open a small form alongside the emulator that tells which game you're running.

## Automating Run inside Visual Studio
If you want to simplify the building process for this project, you can change the execution settings for this project so it opens BizHawk automatically after pressing Run in Visual Studio.

 1. Right Click the project inside the Solution Explorer in Visual Studio > Properties
 2. Go to Debug > Open the Debug Profiles dialog
 3. Click "Create new Profile"
 4. In Executable, select the EmuHawk.exe inside the BizHawk folder.
 5. In Command Line Arguments, set `--open-ext-tool-dll=ExternalToolTest`
 6. (Optionally) Click on the Profile, and press Change Profile Name to the Name you prefer.
 7. Close the Dialog and then go to the top where the execution button is, press the arrow next to it and select the profile you just created.
 8. Press Run and check that the Emulator opens correctly with the form.

