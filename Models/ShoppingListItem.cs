using System.ComponentModel.DataAnnotations.Schema;

namespace IntelligentMealPreparationAPI.Models
{
    public class ShoppingListItem
    {
        public int Id { get; set; }
        public string Name { get; set; } = "";
        [Column(TypeName = "decimal(18.2)")]
        public decimal Quantity { get; set; }
        public FoodUnit Unit { get; set; } = FoodUnit.Grams;
        public FoodCategory Category { get; set; } = FoodCategory.Other;
        public bool IsCheckedOff { get; set; } = false;
        [Column(TypeName = "decimal(18.2)")]
        public decimal? EstimatedCost { get; set; }

        // Foreign key
        public int ShoppingListId { get; set; }
        // Navigation property
        public required ShoppingList ShoppingList { get; set; }
    }
}
