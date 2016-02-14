# MQL4CSharpWrapper
Use this wrapper in you custom strategy DLL

To use the MQL4CSharp library with nuget. Create a new Visual Studio project, and include the MQLWrapper.cs file.
This will expose the DLL functions to Metatrader and call the underlying library.

Make sure that you update the dll import in the mql4csharp.mq4 file:

Change:
  #import "MQL4CSharp.dll"
To:
  #import "yourprojectname.dll"

Get the nuget package:
  PM> Install-Package MQL4CSharp

Don't forget to copy all of the DLLs that are created by the build to the same directory as your metatrader terminal.exe

Then you need to copy "yourprojectname.dll" to the MQL/Libraries directory.

And also the mqh files need to be copied to your MQL/Include directory.

Here are the MQL files mentiond above.
https://github.com/jseparovic/MQL4CSharp/tree/master/MQL4CSharp/Mql


