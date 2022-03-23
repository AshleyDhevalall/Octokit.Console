using Octokit;
using System.CommandLine;
using System.CommandLine.Invocation;

namespace GitHub.Client
{
    class Program
    {
        static readonly string _productName = "my-cool-app";

        static int Main(string[] args)
        {
            var rootCommand = new RootCommand
            {
                new Option<string>(
                    "--action",
                    description: "Specify the action to perform"),
                new Option<string>(
                    "--token",
                    "Specify github token \n"),
                new Option<string>(
                    "--repository",
                    "An option for providing the repository name when action == artifacts. \n"),
                new Option<string>(
                    "--output-path",
                    "An option for file directory path where output will be created.")
            };

            rootCommand.Description = ".NET Core console wrapper for OctoKit.";
            rootCommand.Handler = CommandHandler.Create<string, string, string, string>(Execute);

            // Parse the incoming args and invoke the handler
            return rootCommand.InvokeAsync(args).Result;
        }

        static void Execute(string action, string token, string outputpath, string repository)
        {
            switch (action)
            {
                case "repositories":
                    FetchRepositories(token);
                    break;
                case "artifacts":
                    FetchArtifacts(token, repository);
                    break;
                case "projects":
                    FetchProjects(token);
                    break;
            }
        }

        static void FetchRepositories(string token)
        {
            var client = new GitHubClient(
               new ProductHeaderValue(_productName));

            var tokenAuth = new Credentials(token);
            client.Credentials = tokenAuth;

            foreach (var repo in client.Repository.GetAllForCurrent().Result)
            {
                System.Console.WriteLine(repo.Name);
                System.Console.WriteLine(repo.GitUrl);
            }
        }

        static void FetchProjects(string token)
        {

        }

       
        static void FetchArtifacts(string token, string repository)
        {

        }
    }
}
