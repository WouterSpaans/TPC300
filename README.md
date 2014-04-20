TPC300
======

A C# Wrapper Around An Unmanaged TPC-300 Windows Library

Usage
-----

Add a reference to "TPC300.dll" into your project.

To turn on device 0 we use:  
	TPC300.Device.On(0);

To turn off device 0 we use:  
	TPC300.Device.Off(0);

To adjust device 0 to jump to dim level 5 we use:  
	TPC300.Device.Level(0, 5);

Links
-----
Hardware Device: http://www.klikaanklikuit.nl/shop/nl/producten-1/zenders/tpc-301  
How to wrap an unmanaged DLL: http://msdn.microsoft.com/en-us/library/26thfadc.aspx  
