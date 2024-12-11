# Blazor Search, Filter, and Pagination with MudBlazor

This project demonstrates how to implement search, filter, and pagination features in a Blazor WebAssembly application using the MudBlazor library's `MudTable` component.

## Watch the Full Implementation Video
[Watch the Video Here](https://youtu.be/Qn2ERoSSn9s)

## Features
- **Search**: Search data across multiple fields like Name, Email, and Department.
- **Filter**: Filter data based on user input.
- **Pagination**: Easily navigate through data with pagination.
- **Sorting**: Sort data by columns such as ID, Name, or Department.

## Setup Instructions

### 1. Add Imports
Add the following in your `_Imports.razor` file:
```csharp
@using MudBlazor
```

### 2. Add References
Include the following in your HTML head section (depending on the project type):

For WebAssembly: Add in index.html
For Server: Add in _Layout.cshtml or _Host.cshtml
```csharp
<link href="https://fonts.googleapis.com/css?family=Roboto:300,400,500,700&display=swap" rel="stylesheet" />
<link href="_content/MudBlazor/MudBlazor.min.css" rel="stylesheet" />
<script src="_content/MudBlazor/MudBlazor.min.js"></script>
```


### 3. Register Services
Add the following in Program.cs:

```csharp
using MudBlazor.Services;

builder.Services.AddMudServices();
```
### 4. Add Components
Include these components in your MainLayout.razor file:

```csharp
@* Required *@
<MudThemeProvider />
<MudPopoverProvider />
```
