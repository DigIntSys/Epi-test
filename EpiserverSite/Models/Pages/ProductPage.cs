using System.ComponentModel.DataAnnotations;

namespace EpiserverSite.Models.Pages;

/// <summary>
/// Product listing page type - displays a list of products
/// </summary>
[ContentType(
    DisplayName = "Product Page",
    Description = "Page for displaying product listings",
    GUID = "A5671657-B684-4D95-A61F-8DD4FE60D560")]
public class ProductPage : PageData
{
    [Display(Name = "Heading", Description = "Main heading for the product page")]
    public string Heading { get; set; } = "Our Products";

    [Display(Name = "Description", Description = "Description text for the product page")]
    public string Description { get; set; } = "Browse our selection of quality products";

    public List<Product> Products { get; set; } = new List<Product>();
}
