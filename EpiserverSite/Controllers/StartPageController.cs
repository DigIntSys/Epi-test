using Microsoft.AspNetCore.Mvc;
using EpiserverSite.Models.Pages;

namespace EpiserverSite.Controllers;

/// <summary>
/// Controller for the StartPage content type
/// In Episerver, controllers are named after the page type they handle
/// </summary>
public class StartPageController : Controller
{
    public IActionResult Index()
    {
        // In a real Episerver site, the page data would be retrieved from the CMS
        // Here we create a mock page for demonstration
        var page = new StartPage
        {
            PageId = 1,
            PageName = "Home",
            PageUrl = "/",
            Created = DateTime.Now,
            Changed = DateTime.Now,
            Heading = "Welcome to Episerver",
            MainContent = "This is a functioning Episerver website scaffold. This demonstrates the typical structure of an Episerver CMS site with page types, controllers, and views.",
            FooterText = "© 2026 Episerver Site - Powered by Optimizely CMS"
        };

        return View(page);
    }
}
