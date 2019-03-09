# IPS-Peek
IPS Peek is an IPS (International Patching System) patch exploring tool. It runs on Microsoft Windows 7 or greater. 

## Screenshots
![IPS Peek](https://www.romhacking.net/utilities/screenshots/1038screenshot1.png)

## Overview
Usually, IPS patch files can only be analyzed with hex editors; this can be difficult if the user has no knowledge of the IPS file format. IPS Peek allows IPS patch file data to be easily viewed in a visual way.

IPS patces can be opened, along with an optional target file (a file the patch is designed for). Each patch record can be clicked in a list, showing the data that is written to the file (in the Data View). Patch records can be selectively enabled or disabled for a given target file, and tested with an emulator, all from within the application. Patch report information can also be exported for later use.

Main Features:

* Selective patching with instant visual file diff.
* Emulator testing (with selected patch records).
* Supports loading of a target file to see how patch records affect it (with patched file diff and highlighting).
* Shows IPS patch records, record sizes, offsets and more!
* Shows Lunar IPS truncate extension (CHS).
* Shows data (in a hex view) written by a patch record.
* Shows total size of all modified data.
* Allows exporting of patch information to a text file for later use.
* Filtering support.

## System Requirements:

Microsoft .NET Framework 4.0

## Contribution
IPS needs help! I originally wrote the program many years ago. I have improved my coding skills in C# since then. Therefore, the code is no longer up to my standards. If you would like to add features, or help refactor it, please feel free to fork and send me pull requests! 

