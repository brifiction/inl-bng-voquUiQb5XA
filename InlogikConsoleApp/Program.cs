// A more interactive C# console application in .NET 6
using System;
using System.Collections.Generic;

Console.WriteLine("Inlogik Console Application");
Console.WriteLine("*--------------------------------------*");

// Demonstrate user input
Console.Write("Please enter input: ");
string? inputTest = Console.ReadLine();
Console.WriteLine($"Confirmed, {inputTest} received.");

Console.WriteLine("\nThank you for using the C# Console Application!");
Console.WriteLine("Press any key to exit...");
Console.ReadKey();
