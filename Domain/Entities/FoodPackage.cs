using Core.Persistence.Repositories;

namespace Domain.Entities;

public class FoodPackage : Entity<Guid>
{
    public string Name { get; set; }
    public string Description { get; set; }
    public decimal OriginalPrice { get; set; }
    public decimal DiscountedPrice { get; set; }
    public DateTime AvailableFrom { get; set; }
    public DateTime AvailableUntil { get; set; }

    //public int BusinessId { get; set; }
    //public Business Business { get; set; }

    //public ICollection<Order> Orders { get; set; }

    public FoodPackage()
    {
        
    }

    public FoodPackage(Guid id, string name)
    {
        Id = id;
        Name = name;
    }

}
