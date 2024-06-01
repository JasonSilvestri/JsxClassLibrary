# JsxClassLibrary

## Overview

The `JsxClassLibrary` project is custom, reusable, jSilvestri.com 2024 Web API Demo ASP.NET Core Class Library, designed to hold common constants, enums, and helper classes that can be shared across multiple projects. This library promotes code reuse, reduces duplication, and simplifies maintenance.

Copyright © 2024 All Rights Reserved by Jason Silvestri

## Project Structure

The project is organized into the following structure:

### Constants

- **JsxConstants.cs**: Contains constant values used across the application, such as JWT settings.

### Enums

- **UserRoles.cs**: Defines enums for user roles within the application.

### Helpers

- **JwtHelper.cs**: Provides methods for generating and validating JWT tokens.

## Getting Started

### Prerequisites

- [.NET 8 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)

### Installation

1. **Clone the repository**:

    ```bash
    git clone https://github.com/JasonSilvestri/JsxClassLibrary.git
    ```

2. **Open the solution in Visual Studio**:

    - Open `JsxClassLibrary.sln` in Visual Studio.

3. **Build the project**:

    - Right-click on the solution in Solution Explorer and select `Build Solution`.

### Usage

#### Adding the Class Library to Other Projects

1. **Add Project Reference**:

    - In the solution that requires the common library, right-click on the project in Solution Explorer.
    - Select `Add` > `Reference`.
    - Check the box for `JsxClassLibrary` and click `OK`.

2. **Use the Common Code**:

    - You can now use the constants, enums, and helpers from the `JsxClassLibrary` in your other projects.

#### Example Usage

**Using Constants**:

```csharp
using JsxClassLibrary.JsxConstants;

public class ExampleService
{
    public void PrintJwtSettings()
    {
        Console.WriteLine($"Issuer: {JsxConstants.JsxWebApiDemoSettings.JwtIssuer}");
        Console.WriteLine($"Audience: {JsxConstants.JsxWebApiDemoSettings.JwtAudience}");
        Console.WriteLine($"Key: {JsxConstants.JsxWebApiDemoSettings.JwtKey}");
    }
}
