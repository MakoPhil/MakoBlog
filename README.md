# MakoBlog
An SPA blog with a ASP\.NET Core WebAPI backend and an ~~Angular 7~~ ASP\.NET Blazor front-end.

> Hey man, wasn't this going to be an Angular project? What happened?

I'm so glad you asked. With WebAssembly gaining traction, I believe JavaScript and its related technologies are living on borrowed time. More importantly, C# .NET is much, much nicer to develop with. Yes, Blazor is in a very early stage at the moment, but what better time to jump on board?

.NET Core, Blazor, VS Code etc. are all open source too. Microsoft has changed a bit since I were a lad.

## Philosophy
### Simplicity
It's a blog, not a CMS. A Minimum Viable Product (MVP) approach will ensure that it works with *just enough* to get running, with more flashy features added over time. Will have support for core blogging functionality including RSS, an externally accessible API, multiple languages, and customisable user profiles. With that said...

### Extensibility
Additional features should be easy to add, allowing administrators to customise their blog as they see fit.

### Customisability
Support for themes and straight-forward tweaking of CSS files to style the blog.

### Usability
Blazor is a Single Page Application (SPA) framework along the lines of Angular and React will ensure that MakoBlog is snappy.
Bootstrap will provide the foundations of a responsive design to ensure that MakoBlog is usable on a range of devices.

### Configurability
The front-end should not be dependent on a certain backend. MakoBlog will be built with a .NET Core backend initially, but the front and back ends will be separated to allow other technologies to provide the backend. Furthermore, it should not be tied to any particular database.

### Reliability
Test Driven Development helps to mitigate bugs and regressions, as well as encouraging leaner code by only writing what needs to be written.

## Developing for MakoBlog
### Development Environment
MakoBlog is built in [VS Code](https://code.visualstudio.com/), Microsoft's excellent lightweight, cross-platform, open source development environment. I use [Debian 10](https://debian.org) on my machines. Is pr'y excellent!

### Prerequisites
#### .NET Core 3.0
For Linux prerequisites, check out [Prerequisites for .NET Core on Linux](https://docs.microsoft.com/en-us/dotnet/core/linux-prerequisites?tabs=netcore30). Windows and macOS links are on the left of that page.

To install the .NET Core 3.0 SDK on Linux, see [Install .NET Core SDK on Linux](https://dotnet.microsoft.com/download/linux-package-manager/debian10/sdk-current) and change the dropdown to match your Linux distro.

### Debugging
#### Blazor Client
Regretably, Blazor offers only rudimentary debugging through Edge and Chrome, and I'm a big Firefox fan. I'm looking forward to improved support in the future, but in the meantime, the application can be launched using the `run blazor` task.

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
Each project with functional code has a corresponding Tests project.

### Common
Shared libraries that can be used in both Client and Server.

#### MakoBlogCommon
A shared library of code, including DTO classes, enums and other things that don't include code with processes.

### Client
Projects pertaining to the browser frontend.

#### MakoBlog
The primary starting point for MakoBlog, brings all other components and major functionality together.

#### BlogComponents
A Components library with functionality for a blog.

### Server
Projects pertaining to the server backend.

#### MakoBlogApi
A WebAPI project that interacts with the database, file systems etc.