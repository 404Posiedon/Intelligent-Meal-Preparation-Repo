using System.ComponentModel.DataAnnotations.Schema;

namespace IntelligentMealPreparationAPI.Models
{
    public class MealIngredient
    {
        public int Id { get; set; }
        public string Name { get; set; } = "";

        [Column(TypeName ="decimal(18.2)")]
        public decimal Quantity { get; set; }
        public FoodUnit Unit { get; set; } = FoodUnit.Grams;
        public bool IsInPantry { get; set; }

        // Foreign key
        public int MealId { get; set; }

        // Navigation property
        public required Meal Meal { get; set; }

    }
}
