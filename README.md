# delegates
Example for helping you out with delegates, simple console app in .NET Core 3.1 :)

The most common use for delegates in .NET are events in windows applications, normally in web, you won't use events but for sure at some point, you'll run into them.
If you are a js developer you know you can pass a function as an argument of a method. For C# developers that could be weird or strange, you must get use to the idea 
to be able to pass functions in methods.

Delegates follows a simple pattern, the name of the delegate and two parameters (sender and args) <code> delegate void {delegateName} (object sender, EventArgs args);</code>. 
Here you can find the naming convention for delegates in C# https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/inside-a-program/coding-conventions

# How does it work?

Use VS code or Visual Studio 2019, add a break point, hit run and follow the comments in the code.

This code is documented with the intention to help you digest what delegates are, happy coding :)
