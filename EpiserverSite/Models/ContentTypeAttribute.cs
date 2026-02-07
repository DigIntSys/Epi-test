namespace EpiserverSite.Models;

/// <summary>
/// Attribute to define content type metadata
/// Mock implementation of EPiServer ContentType attribute
/// </summary>
[AttributeUsage(AttributeTargets.Class)]
public class ContentTypeAttribute : Attribute
{
    public string? DisplayName { get; set; }
    public string? Description { get; set; }
    public string? GUID { get; set; }
}
