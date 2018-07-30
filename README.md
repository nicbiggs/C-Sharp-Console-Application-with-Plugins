# C-Sharp-Console-Application-with-Plugins
Experiment to implement a plugin application using the console window

### Based on tutorial found at:
> https://www.codeproject.com/Articles/1052356/Creating-a-Simple-Plugin-System-with-NET

I expanded upon this tutorial by adding my own plugin project, named "MathPlugins," which implements a simple object-oriented structure
to do basic math operations, and also a "SentenceCheck" plugin to verify if a sentence as input is proper. I also improved upon the "help"
command so that it lists the plugins first by category (a new property of IPlugin) and then by command name.

### Things I learned from this project:
- How to structure a Plugin implementation
- Organizing code to simplify creating additional operations later
- What some of the subtle differences are between C# and VB.Net

### To use:
Be sure to have the plugin DLL files inside of a folder named "Plugins"
This folder needs to be in the same folder as the console application .exe file.