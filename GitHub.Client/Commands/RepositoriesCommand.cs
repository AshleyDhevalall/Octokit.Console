using CommandLine;
using Octokit;
using System;

namespace GitHub.Client.Commands
{
    [Verb("repositories", HelpText = "List repositories")]
	public class RepositoriesCommand : ICommand
	{		
		private readonly string _productName = "my-cool-app";
				
		[Option('t', "token", Required = true, HelpText = "Enter your GitHub Token")]
		public string Message { get; set; }
		public void Execute()
		{
			var client = new GitHubClient(
			   new ProductHeaderValue(_productName));

			var tokenAuth = new Credentials(Message);
			client.Credentials = tokenAuth;

			foreach (var repo in client.Repository.GetAllForCurrent().Result)
            {
				Console.WriteLine(repo.Name);
				Console.WriteLine(repo.GitUrl);
			}
		}
	}
}
