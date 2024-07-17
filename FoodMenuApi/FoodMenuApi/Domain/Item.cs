namespace FoodMenuApi.Domain;

public sealed class Item
{
    public Item()
    {
        this.CorrelationId = Guid.NewGuid();
    }

    /// <summary>
    /// Gets the Item CorrelationId.
    /// </summary>
    public Guid CorrelationId { get; private set; }
    
    /// <summary>
    /// Gets the Item Display Name.
    /// </summary>
    public string DisplayName { get; private set; } = string.Empty;

    /// <summary>
    /// Gets the Item Description.
    /// </summary>
    public string Description { get; private set; } = string.Empty;

    /// <summary>
    /// Gets the Item Price.
    /// </summary>
    public double Price { get; private set; }

    /// <summary>
    /// Gets the Item image path.
    /// </summary>
    public string ImagePath { get; private set; } = string.Empty;

    public void SetDisplayName(string name)
    {
        if (string.IsNullOrWhiteSpace(name))
        {
            throw new ArgumentNullException(nameof(name));
        }

        DisplayName = name;
    }

    public void SetDescription(string description)
    {
        if (string.IsNullOrWhiteSpace(description))
        {
            throw new ArgumentNullException(nameof(description));
        }

        Description = description;
    }

    public void SetPrice(double price)
    {
        if (double.IsNaN(price))
        {
            throw new ArgumentException($"The provided value is not a number: {price}");
        }

        if (price < 0)
        {
            throw new ArgumentException($"The price cannot be less than zero: {price}");
        }

        Price = price;
    }

    public void SetImagePath(string imagePath)
    {
        if (string.IsNullOrWhiteSpace(imagePath))
        {
            throw new ArgumentNullException(nameof(imagePath));
        }

        ImagePath = imagePath;
    }
}
