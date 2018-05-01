# Convert-SRT-to-VTT
Utility program to convert .srt subtitles to .vtt subtitles, with a simple GUI.

## Installing
"INSTALL" folder contains a subfolder "Convert SRT to VTT", drag and drop it to anywhere you want to run the executable from.

### Prerequisites
Windows OS, with .NET Framework 4.5.2

## Built With
* Visual Studio 2015
* C#.NET
* Target framework: .NET Framework 4.5.2

# Solution classes

## The program has the following classes:
* Form1.cs
The code-behind file of the (only) windows form.  

* convert_to_vtt.cs
Class that contains a method named "convert". Takes a string(file) array as parameter, converts it to .vtt, and returns a string (converted file).  
The "convert" method is called to convert a file.  

* Program.cs
The main of the application. This will be executed first when the application runs.  
