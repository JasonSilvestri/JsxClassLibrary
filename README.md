# Official JSX Class Library of the jSilvestri.com BETA v 2024 Web API Demo Collection

The `JsxClassLibrary` application (i.e., jSilvestri.com BETA v 2024 JSX Class Library) in specific, is a FREE, open-source, custom, reusable, jSilvestri.com 2024 Web API Demo Collections ASP.NET Core 8 Class Library, designed to hold common constants, enums, and helper classes that can be shared across multiple projects. 

## Overview

The `jSilvestri.com BETA v 2024` mobile and web applications, developed for most smart phones, tablets and desktop computers, was created to showcase a wide range of skills to potential clients and employers, while providing helpful information to fellow developers, demos for interview talks, access to resumes, etc.

The `JsxClassLibrary` application (i.e., jSilvestri.com BETA v 2024 JSX Class Library) in specific, is a FREE, open-source, custom, reusable, jSilvestri.com 2024 Web API Demo Collections ASP.NET Core 8 Class Library, designed to hold common constants, enums, and helper classes that can be shared across multiple projects. This library promotes code reuse, reduces duplication, and simplifies maintenance. 

Many applications in the `Custom jSilvestri.com BETA v 2024 Web API Demo Collection`, such as the `Angular Web API Demo`, `Blazor Web API Demo`, `React Web API Demo`, and `Vue Web API Demo` applications will use this project to reference common features throughout the collective applications.

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
- [Visual Studio 2022 or higher](https://visualstudio.microsoft.com/)
- [Visit jSilvestri.com BETA v 2024 Demos for More Details](https://jsilvestri.com/home/demo)
  
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

**Copyright © 2024 All Rights Reserved by Jason Silvestri**