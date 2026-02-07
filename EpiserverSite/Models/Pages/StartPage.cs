using System.ComponentModel.DataAnnotations;

namespace EpiserverSite.Models.Pages;

/// <summary>
/// Start page type - typically the root page of an Episerver site
/// </summary>
[ContentType(
    DisplayName = "Start Page",
    Description = "The home page of the website",
    GUID = "19671657-B684-4D95-A61F-8DD4FE60D559")]
public class StartPage : PageData
{
    [Display(Name = "Heading", Description = "Main heading for the page")]
    public string Heading { get; set; } = "Welcome to Episerver";

    [Display(Name = "Main Content", Description = "Main content area")]
    public string MainContent { get; set; } = "This is a functioning Episerver website scaffold.";

    [Display(Name = "Footer Text", Description = "Text displayed in the footer")]
    public string FooterText { get; set; } = "© 2026 Episerver Site";
}
