using System.ComponentModel.DataAnnotations.Schema;

namespace IntelligentMealPreparationAPI.Models
{
    public class PantryItem
    {
        //Primary properties
        public int Id { get; set; }
        public string Name { get; set; } = "";
        public FoodCategory Category { get; set; } = FoodCategory.Other;

        [Column(TypeName = "decimal(18.2)")]
        public decimal Quantity { get; set; }
        public FoodUnit Unit { get; set; } = FoodUnit.Grams;
        public DateTime ExpirationDate { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;

        // Foreign key
        public int UserId { get; set; }

        // Navigation property
        public required User User { get; set; }
    }

    //Enum for FoodCategory
    public enum FoodCategory
    {
        Proteins,
        Vegetables,
        Fruits,
        Dairy,
        Meat,
        Grains,
        Beverages,
        Snacks,
        Condiments,
        FrozenFoods,
        CannedGoods,
        BakingSupplies,
        SpicesAndHerbs,
        Other
    }
    public enum FoodUnit
    {
        Grams,
        Kilograms,
        Milliliters,
        Liters,
        Cups,
        Tablespoons,
        Teaspoons,
        Pieces,
        Ounces,
        
    }
}
