# IPS-Peek

[![Join the chat at https://gitter.im/vector-man/IPS-Peek](https://badges.gitter.im/vector-man/IPS-Peek.svg)](https://gitter.im/vector-man/IPS-Peek?utm_source=badge&utm_medium=badge&utm_campaign=pr-badge&utm_content=badge)

IPS Peek is an IPS (International Patching System) patch exploring tool. It runs on Microsoft Windows 7 or greater.

![IPS Peek](https://i.ibb.co/frtZRg6/1038screenshot1.png)

# Sponsor Project
Help IPS Peek with a sponsorship to the following Patreon page: https://patreon.com/vectordude

## Latest Release
Release verison 0.6.0 can be downloaded here: https://games.softpedia.com/get/Tools/IPS-Peek.shtml

## Overview
Usually, IPS patch files can only be analyzed with hex editors; this can be difficult if the user has no knowledge of the IPS file format. IPS Peek allows IPS patch file data to be easily viewed in a visual way; no target file requied!

IPS patches can be opened, along with an optional target file (a file the patch is designed for). Each patch record can be clicked in a list, showing the data that is written to the file (in the Data View). Patch records can be selectively enabled or disabled for a given target file, and tested with an external tool (such as an emulator), all from within the application. Patch report information can also be exported for later use.

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

Microsoft .NET Framework 4.7.2

## Contribution
If you would like to add or request features, please feel free to post an issue or fork and send me a pull requests!


# Building
Clone the project, do a Nuget package restore, and you are on your way!



