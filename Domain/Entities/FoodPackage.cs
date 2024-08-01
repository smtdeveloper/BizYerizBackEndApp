namespace Domain.Entities;

public class FoodPackage
{
    public int PackageId { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public decimal OriginalPrice { get; set; }
    public decimal DiscountedPrice { get; set; }
    public DateTime AvailableFrom { get; set; }
    public DateTime AvailableUntil { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    //public int BusinessId { get; set; }
    //public Business Business { get; set; }

    //public ICollection<Order> Orders { get; set; }
}
