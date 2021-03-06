# Octokit.Console

Lightweight .NET Core console wrapper for [Octokit](https://github.com/octokit/octokit.net).

### Prerequisites
[GitHub](https://github.com/)  
[Token authentication requirements](https://github.blog/2020-12-15-token-authentication-requirements-for-git-operations/)  
[.NET Core 5.0 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/5.0)  
  

### Usage

#### 1. Clone repository

```
git clone https://github.com/AshleyDhevalall/Octokit.Console
```


#### 2. Building the project
* Navigate to cloned repository folder
* Run the build.ps1 file
```
dotnet restore
```

#### 3. Running the application
* Get repositories
```
Octokit.Console.exe --action repositories --token <some token> --output-path C:\Test
```

* Get projects
```
Octokit.Console.exe --action projects --token <some token> --output-path C:\Test
```

* Get artifacts in repository
```
Octokit.Console.exe --action artifacts --token <some token> --repository <some-repository> --output-path C:\Test
```

## Authors

[Ashley Dhevalall](https://github.com/AshleyDhevalall)

## Acknowledgements
[GitHub Docs](https://docs.github.com/en)  
[Matthew Langlois](https://github.blog/2020-12-15-token-authentication-requirements-for-git-operations/)  
[Itay Sagui](https://medium.com/@saguiitay/playing-with-github-api-octokit-net-1f184faacd59)  
