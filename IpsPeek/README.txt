IPS Peek
====
IPS Peek is a tool used to look inside of IPS (International Patching System) patches. It allows you to see the elements of an IPS patch such as: offset, patch type, patch size, resize information (for Lunar IPS patches), and more! It also lets you see the actual data that is written by a given patch record.  You can also export the list of patch information to a text file for later use.

System Requirements
===================
Microsoft .NET Framework 4.0

Quick Start
===========
To read more detailed instructions on how to use IPS Peek, check out the following link: http://help.codeisle.com/ips-peek/ (the page is under construction at the time of this writing).

IPS Peek requires no installation. Everything to use the application is contained in a single folder (including the settings). Double-clicking the 'IPS Peek' icon will launch the application. 

With IPS Peek open, click the button with the folder icon to open an IPS patch (you can also drag and drop the file into the application icon or window to open it too). After the IPS patch is loaded, the user will be presented with a list of various elements of the patch. 

Here is an explanation of the list columns:

 * Offset - the starting address in the file where data is modified by the patch (or in the special case of when 'Type' is 'CHS', the new size for the patched file.)
 * End - the address in the file where patching ends for the given patch..
 * Size - the size of the data that is patched to the file.
 * Type - the type of record; possible values: 'ID' for the 'PATCH' identifier, 'PAT' for a normal patch, 'RLE' for a Run-length encoded patch, 'EOF' for the end of file marker, and 'CHS' for the resize (Lunar IPS truncate) command.
 * IPS Offset - the address in the IPS patch where the record begins.
 * IPS End - the address in the IPS patch where the record ends.
 * IPS Size - the total size of the record data in the IPS patch.

If 'Data View' is enabled (from the 'View' menu), data that is written to a file at a given offset can be viewed by clicking on a patch record in the list. Enabling 'String View' will also allow the data to be viewed as text. 

You can filter the rows by typing text in the filter text box (located on the toolbar) and pressing 'Enter' on the keyboard; deleting the text will remove the filter. 

To export the list of patch records to a text file, click the 'Export' button. 

Support
=======
You can post a question or get help on the following forum: http://www.codeisle.com/forum/product/ips-peek/

Copyright
=========
IPS Peek (c) 2014 CodeIsle.com All Rights Reserved. IPS Peek is released under the CodeIsle.com Freeware EULA; IPS Peek also uses libraries under other licenses  (see included file 'LICENSE.txt' for details).

Acknowledgments
================
Thanks to the creator of ObjectListView (http://objectlistview.sourceforge.net/cs/index.html) for giving permission to use their library.

Fusoya's (http://fusoya.eludevisibility.org/) Lunar IPS log files were the inspiration for the columns and export format used for IPS Peek. 