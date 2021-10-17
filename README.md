# MakoBlog
A single user SPA blog with a ASP\.NET WebAPI backend and a Blazor front-end.

## How to Use
Download and publish with the .NET SDK. Use the `.json` files in `wwwroot` to configure and write articles.

Note that article dates are formatted to ISO-8601 (equivalent to `.toISOString()` from the JavaScript datetime object.) Navigate to `/admin` to get the current value.

## Philosophy
### Simplicity
It's a blog, not a CMS. A Minimum Viable Product (MVP) approach will ensure that it works with *just enough* to get running, with more flashy features added over time. Will have support for core blogging functionality including RSS, an externally accessible API and multiple language support. With that said...

### Extensibility
Additional features should be easy to add, allowing administrators to customise their blog as they see fit.

### Customisability
Support for themes and straight-forward tweaking of CSS files to style the blog.

### Usability
Blazor is a Single Page Application (SPA) framework along the lines of Angular and React will ensure that MakoBlog is snappy.
[UI-Kit](https://getuikit.com) will provide the foundations of a responsive design to ensure that MakoBlog is usable on a range of devices.

### Configurability
The front-end should not be dependent on a certain backend. MakoBlog will be built with a .NET backend initially, but the front and back ends will be separated to allow other technologies to provide the backend. Furthermore, it should not be tied to any particular database.

### Reliability
Test Driven Development helps to mitigate bugs and regressions, as well as encouraging leaner code by only writing what needs to be written.

## Developing for MakoBlog
### Development Environment
MakoBlog is built in [VS Code](https://code.visualstudio.com/), Microsoft's excellent lightweight, cross-platform, open source development environment. My machines run on [Manjaro](https://manjaro.org). Is pr'y excellent!

### Prerequisites
#### .NET 5
Instructions to install .NET can be found [here](https://docs.microsoft.com/en-us/dotnet/core/install/linux). For Arch and its derivatives including Manjaro, it's in the [Community repos](https://archlinux.org/packages/community/x86_64/dotnet-sdk/).

### Debugging
#### Blazor Client
Regretably, Blazor offers only rudimentary debugging through Edge and Chrome, and I'm a big Firefox fan. I'm looking forward to improved support in the future, but in the meantime, the application can be launched using the `watch` task.

Launch a browser, navigate to MakoBlog (port `5001` on https and `5000` on http), press `Shift+Alt+D` and follow the instructions to get debugging.

More details in the Microsoft Documentation: [Debug ASP.NET Core Blazor](https://docs.microsoft.com/en-us/aspnet/core/blazor/debug?view=aspnetcore-3.0).

#### WebAPI Server
Debug as normal. The API sits on port `6001` on https, and `6000` on http.

### TDD
Tests are written in NUnit and span all aspects of MakoBlog. Write the tests before (or in parallel) with the functional code.

* Don't think of it as testing, instead consider tests to be specifications. If the test passes, your code adheres to the spec.
* Write the test before or in parallel with the code. Make sure the test fails before attempting to write the solution.
* Write only the code necessary to pass the test.

## Project Structure
### Overview
Each project with functional code has a corresponding Tests project. All deployable code lives within the `src` directory, allowing clear seperation from readmes, configs, build pipelines, etc.

### Common
Shared libraries that can be used in both Client and Server.

#### MakoBlogCommon
A shared library of code, including DTO classes, enums and other things that don't include code with processes.

### Client
Projects pertaining to the browser frontend.

#### MakoBlog
The primary starting point for the MakoBlog frontend.

### Server
Projects pertaining to the server backend.

#### MakoBlogApi
A WebAPI project that interacts with the database, file systems etc.