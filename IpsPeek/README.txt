IPS Peek
========
IPS Peek is an IPS patch (International Patching System) analysis tool. It allows you to see the elements of an IPS patch such as: offset, patch type, patch size, resize information (for Lunar IPS patches), and more! It also lets you see the actual data that is written by a given patch record. You can also open a target file to see how the file is changed by a given patch record.  

You can export a list of patch information to a text file for later use.

Features
========
* Selective patching.
* Emulator testing (with selected patch records.)
* Supports loading of a target file to see how patch records affect it (with patched file diff and highlighting).
* Shows IPS patch records, record sizes, offsets and more!
* Shows Lunar IPS truncate extension (CHS).
* Shows data (in a hex view) written by a patch record.
* Shows total size of all modified data.
* Allows exporting of patch information to a text file for later use.
* Filtering support.

System Requirements
===================
Microsoft .NET Framework 4.0

Quick Start
===========
To read more detailed instructions on how to use IPS Peek, check out the following link: http://help.codeisle.com/ips-peek/ (the page is under construction at the time of this writing).

While the documentation is being written, assistance can be obtained from one of the following sources:
* https://www.codeisle.com/forums/forum/product/ips-peek/ (requires a free account).
* http://www.romhack.me/ips-peek (requires a free account).

IPS Peek requires no installation. Everything to use the application is contained in a single folder (including the settings). Double-clicking the 'IPS Peek' icon will launch the application. 

With IPS Peek open, click the button with the folder icon to open an IPS patch (you can also drag and drop the file into the application icon or window to open it too). After the IPS patch is loaded, the user will be presented with a list of various elements of the patch. 

Here is an explanation of the list columns (columns can be added or removed by right-clicking the column headers.):

 * Offset - the starting address in the file where data is modified by the patch (or in the special case of when 'Type' is 'CHS', the new size for the patched file.)
 * End - the address in the file where patching ends for the given patch..
 * Size - the size of the data that is patched to the file.
 * Type - the type of record; possible values: 'ID' for the 'PATCH' identifier, 'PAT' for a normal patch, 'RLE' for a Run-length encoded patch, 'EOF' for the end of file marker, and 'CHS' for the resize (Lunar IPS truncate) command.
 * IPS Offset - the address in the IPS patch where the record begins.
 * IPS End - the address in the IPS patch where the record ends.
 * IPS Size - the total size of the record data in the IPS patch.
 * # - Row number.

If 'Data View' is enabled (from the 'View' menu), data that is written to a file at a given offset can be viewed by clicking on a patch record in the list. Enabling 'String View' will also allow the data to be viewed as text. 

If a patch and target file are opened at the same time, the application shows how each patch affects the target file. In this mode, patches can be selected or deselected by clicking a checkbox next to a record in the Patch View. The target file data in the Data View is updated accordingly. In this mode an emulator can be launched to test the target file with the selected patch records. 

You can filter the rows by typing text in the filter text box (located on the toolbar) and pressing 'Enter' on the keyboard; deleting the text will remove the filter. 

To export the list of patch records to a text file, click the 'Export' button. 

Support
=======
You can post a question or get help on the following forum: http://www.codeisle.com/forum/product/ips-peek/

Copyright
=========
IPS Peek (c) 2014 - 2015 CodeIsle.com All Rights Reserved. IPS Peek is released under the CodeIsle.com Freeware EULA; 

IPS Peek also uses libraries under other licenses (contained in the Third-Party folder).

Acknowledgments
================
Thanks to the creator of ObjectListView (http://objectlistview.sourceforge.net/cs/index.html) for giving permission to use their library.

Thanks to FatCow for providing the icons used in the application: http://www.fatcow.com/free-icons

Fusoya's (http://fusoya.eludevisibility.org/) Lunar IPS log files were the inspiration for the columns and export format used for IPS Peek. 