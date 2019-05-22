# MakoBlog
An SPA blog with a ASP.NET Core WebAPI backend and an Angular 7 front-end.

This is just a wee project I'm chipping away at in my (limited) free time.

## Philosophy
### Simplicity
It's a blog, not a CMS. A Minimum Viable Product (MVP) approach will ensure that it works with *just enough* to get running, with more flashy features added over time. Will have support for core blogging functionality including RSS, an externally accessible API, multiple languages, and customisable user profiles. With that said...

### Extensibility
Additional features should be easy to add, allowing administrators to customise their blog as they see fit.

### Customisability
Support for themes and straight-forward tweaking of CSS files to style the blog.

### Usability
A combination of Angular, Angular Material, and responsive design will ensure that MakoBlog is snappy, intuitive and usable on a range of devices.

### Configurability
The front-end should not be dependent on a certain backend. MakoBlog will be built with a .NET Core backend initially, but the front and back ends will be separated to allow other technologies to provide the backend. Furthermore, it should not be tied to any particular database.

## Developing for MakoBlog
### Development Environment
MakoBlog is built in [VS Code](https://code.visualstudio.com/), Microsoft's excellent lightweight, cross-platform, open source development environment. I use [Pop!\_OS](https://system76.com/pop) on my machines. Is pr'y good!

### Prerequisites
#### .NET Core 2.2
For Linux prerequisites, check out [Prerequisites for .NET Core on Linux](https://docs.microsoft.com/en-us/dotnet/core/linux-prerequisites?tabs=netcore2x). Windows and macOS links are on the left of that page.

To install the .NET Core 2.2 SDK on Linux, see [Install .NET Core SDK on Linux](https://dotnet.microsoft.com/download/linux-package-manager/ubuntu18-10/sdk-current) and change the dropdown to match your Linux distro.
