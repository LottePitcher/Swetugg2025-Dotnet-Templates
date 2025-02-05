# Custom Dotnet New Templates

This repository contains the demo templates from my talk at [Swetugg 2025](https://www.swetugg.se/sthlm-2025) entitled "dotnet new Templates: an underused tool in a .NET developers toolkit".

## Installing Locally

If you want to install and test these locally:

- Clone this repository
- Navigate to the `Templates` folder
- `cmd > dotnet new install .\`

## Templates

Each template is in its own folder inside `Templates`. Look at `.template.config\template.json` to see the configuration file for each template.

### Item Template

`dotnet new demoitem`

### Project Template

`dotnet new demoproject -n MyProject`

### Solution Template

`dotnet new demosolution -n MyApp`

## Resources

- [Source code of Microsoft's templates](https://github.com/dotnet/aspnetcore/tree/main/src/ProjectTemplates)

- [Microsoft's Tutorial on creating templates](https://learn.microsoft.com/en-us/dotnet/core/tutorials/cli-templates-create-project-template)

- [Templating docs](https://github.com/dotnet/templating/wiki)

- [Source name considerations](https://github.com/dotnet/templating/wiki/Naming-and-default-value-forms)