using Microsoft.AspNetCore.Mvc;
using EpiserverSite.Models;
using EpiserverSite.Models.Pages;

namespace EpiserverSite.Controllers;

/// <summary>
/// Controller for the ProductPage content type
/// In Episerver, controllers are named after the page type they handle
/// </summary>
public class ProductPageController : Controller
{
    public IActionResult Index()
    {
        // In a real Episerver site, the page data and products would be retrieved from the CMS
        // Here we create mock data for demonstration
        var page = new ProductPage
        {
            PageId = 2,
            PageName = "Products",
            PageUrl = "/products",
            Created = DateTime.Now,
            Changed = DateTime.Now,
            Heading = "Our Products",
            Description = "Browse our selection of quality products",
            Products = GetSampleProducts()
        };

        return View(page);
    }

    private List<Product> GetSampleProducts()
    {
        return new List<Product>
        {
            new Product
            {
                Id = 1,
                Name = "Laptop Pro 15",
                Description = "High-performance laptop with 15-inch display, perfect for professionals",
                Price = 1299.99m,
                ImageUrl = "https://via.placeholder.com/300x200/667eea/ffffff?text=Laptop+Pro+15",
                Category = "Electronics"
            },
            new Product
            {
                Id = 2,
                Name = "Wireless Mouse",
                Description = "Ergonomic wireless mouse with precision tracking",
                Price = 49.99m,
                ImageUrl = "https://via.placeholder.com/300x200/764ba2/ffffff?text=Wireless+Mouse",
                Category = "Accessories"
            },
            new Product
            {
                Id = 3,
                Name = "USB-C Hub",
                Description = "7-in-1 USB-C hub with HDMI, USB 3.0, and SD card reader",
                Price = 79.99m,
                ImageUrl = "https://via.placeholder.com/300x200/f093fb/ffffff?text=USB-C+Hub",
                Category = "Accessories"
            },
            new Product
            {
                Id = 4,
                Name = "Mechanical Keyboard",
                Description = "RGB backlit mechanical keyboard with customizable keys",
                Price = 129.99m,
                ImageUrl = "https://via.placeholder.com/300x200/4facfe/ffffff?text=Mechanical+Keyboard",
                Category = "Accessories"
            },
            new Product
            {
                Id = 5,
                Name = "4K Monitor",
                Description = "27-inch 4K UHD monitor with HDR support",
                Price = 499.99m,
                ImageUrl = "https://via.placeholder.com/300x200/00f2fe/ffffff?text=4K+Monitor",
                Category = "Electronics"
            },
            new Product
            {
                Id = 6,
                Name = "Webcam HD",
                Description = "1080p webcam with built-in microphone and auto-focus",
                Price = 89.99m,
                ImageUrl = "https://via.placeholder.com/300x200/43e97b/ffffff?text=Webcam+HD",
                Category = "Electronics"
            }
        };
    }
}
