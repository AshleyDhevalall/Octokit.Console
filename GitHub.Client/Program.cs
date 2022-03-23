using CommandLine;
using GitHub.Client;
using GitHub.Client.Commands;
using Octokit;
using System;

/// <summary>
/// https://makolyte.com/csharp-parsing-commands-and-arguments-in-a-console-app/
/// </summary>

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Parser.Default.ParseArguments<CommitCommand, RepositoriesCommand>(args)
             .WithParsed<ICommand>(t => t.Execute());

            Console.ReadLine();
        }
    }
}
