namespace EpiserverSite.Models;

/// <summary>
/// Base class for all Episerver page types
/// This is a mock implementation to demonstrate the Episerver architecture
/// </summary>
public abstract class PageData
{
    public int PageId { get; set; }
    public string? PageName { get; set; }
    public string? PageUrl { get; set; }
    public DateTime Created { get; set; }
    public DateTime Changed { get; set; }
}
