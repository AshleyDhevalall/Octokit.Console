using CommandLine;
using GitHub.Client;

static void Main(string[] args)
{
	Parser.Default.ParseArguments<PushCommand, CommitCommand>(args)
		.WithParsed<ICommand>(t => t.Execute());
}