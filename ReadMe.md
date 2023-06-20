# GrubNames

ItemChanger/Randomizer 4 add-on that replaces Grub names with Grub names edited by the user via a config file.

## Installation

To install, place the .dll file in your Managed/Mods folder inside a folder named GrubNames.

This mod comes with two pre-prepared Grub Name packs, with one with Skurry's grub names, and one with Blossom's AI generated grub names.

## Usage
By default, the grub names are set to their internal locations, in the format
	```Grub_[grublocation]```
Example:
	```Grub_Fungal_Bouncy```

1. Open Hollow Knight and open a save file to generate the GlobalSettings.json file.
2. Go to LocalLow/Team Cherry/Hollow Knight/GrubNames.GlobalSettings.json.
3. Either copy-paste one of the json files included in the releases, or replace the grub names with your own.
4. (optional) if using one of the pre-prepared json files, remember to rename your file ```GrubNames.GlobalSettings.Json```

## Important Notes
This mod is best used in conjunction with Randomizer when grubs are not randomized, but in a seperate pool so that they appear when picked up.

*As of 2.0.0.0*, the mod will not distinguish between mimics and grubs.

The mod does *not* currently allow for multiple grubs being named the same name. The mod will fail to function if this is the case.
