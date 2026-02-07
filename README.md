# Epi-test
Episerver scaffold test - A functioning Episerver (Optimizely CMS) website

![Episerver Site Screenshot](https://github.com/user-attachments/assets/1c61937d-087e-4e86-922a-7493d3d76347)

## Overview

This repository contains a scaffolded Episerver website demonstrating the typical architecture and structure of an Episerver/Optimizely CMS site. The site is built on ASP.NET Core 8.0 and follows Episerver conventions.

## Features

- **Page Types**: StartPage content type with properties
- **Content Type Attributes**: Mock implementation of EPiServer ContentType attributes
- **Controllers**: Page-specific controllers following Episerver naming conventions
- **Views**: Razor views with strongly-typed models and a shared layout
- **ASP.NET Core Integration**: Modern ASP.NET Core 8.0 setup

## Project Structure

```
EpiserverSite/
├── Models/
│   ├── PageData.cs                    # Base class for all page types
│   ├── ContentTypeAttribute.cs        # Content type metadata attribute
│   └── Pages/
│       └── StartPage.cs               # Start page content type
├── Controllers/
│   └── StartPageController.cs         # Controller for StartPage
├── Views/
│   ├── _ViewStart.cshtml             # View configuration
│   ├── StartPage/
│   │   └── Index.cshtml              # StartPage view
│   └── Shared/
│       └── _Layout.cshtml            # Shared layout template
├── Program.cs                         # Application entry point
├── appsettings.json                   # Configuration
└── EpiserverSite.csproj              # Project file
```

## Prerequisites

- [.NET 8.0 SDK](https://dotnet.microsoft.com/download/dotnet/8.0) or later

## Getting Started

### 1. Clone the repository

```bash
git clone https://github.com/DigIntSys/Epi-test.git
cd Epi-test/EpiserverSite
```

### 2. Restore dependencies

```bash
dotnet restore
```

### 3. Build the project

```bash
dotnet build
```

### 4. Run the application

```bash
dotnet run
```

The site will be available at `https://localhost:5001` (or `http://localhost:5000`)

## Development

### Adding New Page Types

To add a new page type:

1. Create a new class in `Models/Pages/` that inherits from `PageData`
2. Add the `ContentType` attribute with metadata
3. Add properties with `Display` attributes
4. Create a corresponding controller in `Controllers/`
5. Create views in `Views/[PageTypeName]/`

Example:

```csharp
[ContentType(
    DisplayName = "Article Page",
    Description = "A page for articles",
    GUID = "YOUR-GUID-HERE")]
public class ArticlePage : PageData
{
    [Display(Name = "Title")]
    public string Title { get; set; }
    
    [Display(Name = "Body")]
    public string Body { get; set; }
}
```

### Hot Reload

The project includes runtime Razor compilation for development. Changes to views will be reflected immediately without rebuilding.

## Architecture Notes

This is a simplified scaffold that demonstrates Episerver architecture patterns:

- **PageData**: Base class for all content types (mock implementation)
- **ContentType Attribute**: Defines metadata for content types
- **Convention-based Controllers**: Controllers named after page types
- **Strongly-typed Views**: Views receive page models as view models

In a production Episerver site, these would be provided by the Episerver NuGet packages and would include:
- Database integration
- CMS admin interface
- Content management features
- Publishing workflow
- Multi-site support
- And much more

## Technologies

- ASP.NET Core 8.0
- Razor Views
- MVC Pattern
- Episerver/Optimizely CMS Architecture

## GitHub Pages Deployment

This repository is configured with automatic deployment to GitHub Pages. The workflow:

1. Builds the ASP.NET Core application
2. Creates a static landing page with project information
3. Deploys to GitHub Pages

**Note:** Since ASP.NET Core is a server-side framework, the GitHub Pages site displays project information and documentation. To run the full application with all dynamic features, clone the repository and run it locally.

The deployment workflow runs automatically on pushes to the `main` branch and can also be triggered manually via the Actions tab.

## License

This is a test/demonstration project.

