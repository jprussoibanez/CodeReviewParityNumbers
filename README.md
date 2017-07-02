# Parity numbers code review

These exercise will identified code smells and apply refactors to improve the quality for calculating the parity property of numbers in a console app. The solution will be guided by the code smells and refactoring [catalog](https://refactoring.com/catalog/)

## Getting Started

This is a simple console app that calculates the parity for a given number sequence.

### Prerequisites

The following tools may help on developing and running the application

* [Visual Studio 2017](https://www.visualstudio.com) or [Visual Studio Code](https://code.visualstudio.com/) - Recommended IDEs

### Installing

1) Clone repository.
2) Build the solution on visual studio.
3) Run the console application.

The sequence count is the first argument for the console application. It can be configure on the launchSettings.json file commandLineArgs attribute.

```
{
  "profiles": {
    "ParityNumbers.Console": {
      "commandName": "Project",
      "commandLineArgs": "50"
    }
  }
}
```

## Running the tests

The unit test project ParityNumbers.ConsoleApp.UnitTests can be runned within the IDE or using:

```
dotnet test
```

## Built With

* [.NET Core](https://www.microsoft.com/net/core) - .NET core 1.1
* [xUnit](https://xunit.github.io/) - Testing framework
* [Fluent Assertions](http://fluentassertions.com/) - Fluent assertions for testing
