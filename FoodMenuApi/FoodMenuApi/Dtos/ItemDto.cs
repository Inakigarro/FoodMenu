namespace FoodMenuApi.Dtos;

/// <summary>
/// Dto used to represent an item in the client.
/// </summary>
public record ItemDto
{
    /// <summary>
    /// Gets the Item CorrelationId.
    /// </summary>
    public Guid CorrelationId { get; set; }

    /// <summary>
    /// Gets the Item Display Name.
    /// </summary>
    public string DisplayName { get; set; } = string.Empty;

    /// <summary>
    /// Gets the Item Description.
    /// </summary>
    public string Description { get; set; } = string.Empty;

    /// <summary>
    /// Gets the Item Price.
    /// </summary>
    public double Price { get; set; }

    /// <summary>
    /// Gets the Item image path.
    /// </summary>
    public string ImagePath { get; set; } = string.Empty;
}
