// A more interactive C# console application in .NET 6
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using InlogikConsoleApp.Domain;
using InlogikConsoleApp.Infrastructure;

// Initialize command and query processors
var commandProcessor = new CommandProcessor();
var queryProcessor = new QueryProcessor();

Console.WriteLine("Inlogik Console Application");
Console.WriteLine("*--------------------------------------*"); 
Console.WriteLine("Commands:");
Console.WriteLine("- <user name> -> @<project name> <message>");
Console.WriteLine("- <project name>");
Console.WriteLine("- <user name> follows <project name>");
Console.WriteLine("- <user name> wall");
Console.WriteLine("- exit (to quit)");
Console.WriteLine();

// Regular expressions for parsing commands
var postRegex = new Regex(@"^(\w+)\s+->\s+@(\w+)\s+(.+)$");
var readRegex = new Regex(@"^(\w+)$");
var followRegex = new Regex(@"^(\w+)\s+follows\s+(\w+)$");
var wallRegex = new Regex(@"^(\w+)\s+wall$");
bool isRunning = true;

while (isRunning)
{
    Console.Write("> ");
    var input = Console.ReadLine()?.Trim();

    if (string.IsNullOrEmpty(input))
        continue;

    if (input.ToLower() == "exit")
    {
        isRunning = false;
        continue;
    }

    // posting: <user name> -> @<project name> <message>
    var postMatch = postRegex.Match(input);
    if (postMatch.Success)
    {
        var username = postMatch.Groups[1].Value;
        var projectName = postMatch.Groups[2].Value;
        var message = postMatch.Groups[3].Value;

        commandProcessor.ProcessPostMessage(username, projectName, message);
        continue;
    }

    // reading: <project name>
    var readMatch = readRegex.Match(input);
    if (readMatch.Success && !input.Contains("follows") && !input.Contains("wall"))
    {
        var projectName = readMatch.Groups[1].Value;
        var messages = queryProcessor.ProcessReadProject(projectName, commandProcessor.GetProjects());

        if (!messages.Any())
        {
            Console.WriteLine($"No messages found for project: {projectName}");
        }
        else
        {
            foreach (var message in messages)
            {
                Console.WriteLine(message);
            }
        }
        continue;
    }

    // following: <user name> follows <project name>
    var followMatch = followRegex.Match(input);
    if (followMatch.Success)
    {
        var username = followMatch.Groups[1].Value;
        var projectName = followMatch.Groups[2].Value;

        commandProcessor.ProcessFollowProject(username, projectName);
        Console.WriteLine($"{username} is now following project: {projectName}");
        continue;
    }
    

    Console.WriteLine("Unknown command format. Please try again.");
}

Console.WriteLine("Thank you for using the Inlogik Console Application!");
