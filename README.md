# Dovign.Logging

[![NuGet Version](https://img.shields.io/nuget/v/Dovign.Logging?label=Dovign.Logging)](https://www.nuget.org/packages/Dovign.Logging/)
[![GitHub License](https://img.shields.io/github/license/Audectra/Dovign.Logging)](LICENSE)

Dovign.Logging provides a lightweight static log manager extension for the common logging framework Microsoft.Extensions.Logging.

This allows for a simplified retrieval of a logger instance from anywhere within the application, without the need to pass it around as a parameter.

## Installation
Install the core package via NuGet:

```bash
dotnet add package Dovign.Logging
```

## Usage
### Initialization
To initialize the static log manager, simple call the extension method `InitializeDovignLogging` on an initalized service provider.

Example initialization within an ASP.NET Core application:

```csharp
var builder = WebApplication.CreateBuilder(args);
// Configure logging and other services.
// ...

var app = builder.Build();

// Initialize the static log manager. 
app.Services.InitializeDovignLogging();
```
Thats it, you can now easily retrieve a logger instance when required.

### Using LogManager
Here is an example of retrieving a logger instance for a class. 

```csharp
using Dovign.Logging;

namespace MyApplication;

public class MyClass
{
    private static readonly ILogger _logger = LogManager.GetLogger<MyClass>();
    
    public void MyMethod()
    {
        _logger.LogInformation("I am logging something.");
    }
}
```
