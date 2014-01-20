IPS Peek
====
IPS Peek is a tool used to look inside of IPS (International Patching System) patches. It allows you to see all elements of an IPS patch such as: offset, patch type, patch size, resize information (for Lunar IPS patches), and more! It also lets you see the actual data that is written by a given patch record.  You can also export the list of patch information to a text file for later use.

Quick Start
===========
To read more detailed instructions on how to use IPS Peek, check out the following link: http://help.codeisle.com/ips-peek/ (the page is under construction at the time of this writing).

IPS Peek requires no installation. Everything to use the program is contained in a single folder (including the settings). Double-cliking the IPS peek icon will launch the application. 

With IPS Peek open, click the folder icon to open an IPS patch. After the IPS patch is loaded, the user will be presented with a list of every element of the patch. 

Here is an exlanation of the columns:

 * Offset - the offset in the file that is modified by the patch (or in the special case of when 'Type' is RES, the new size for the patched file.)
 * Size - the size of the data that is patched to the file.
 * Type - the type of patch record; possible values: ID for the 'PATCH' identifier, PAT for a normal patch, RLE for a RLE patch, EOF for the 'End of File' marker, RES for the resize (Lunar IPS truncate) command.
 * IPS Start - the address in the IPS patch where the record begins.
 * IPS End - the address in the IPS patch where the record ends.
 * IPS Size - the total size of the record data in the IPS patch.

If 'Data View' is enabled (from the 'View' menu), data that is written to a file at a given offset can be viewed by clicking on a record in the list. Enabling 'String View' will also allow the data to be viewed as text. 

To export the list of patch records to a text file, click the 'Export' icon. 

System Requirements
===================
Microsoft Windows XP SP 3 or greater 
.NET Framework 4.0

Support
=======
You can post a question or get help on the following forum: http://www.codeisle.com/forum/product/ips-peek/

Copyright
=========
IPS Peek (c) 2014 CodeIsle.com All Rights Reserved. IPSV is released under the CodeIsle.com Freeware EULA (see included file 'LICENSE.txt' for details).

Thanks
======
I want to thank Fusoya. His Lunar IPS log files were the inspiration for the columns and export format I used for IPS Peek.


