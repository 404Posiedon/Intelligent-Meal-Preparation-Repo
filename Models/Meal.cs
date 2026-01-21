namespace IntelligentMealPreparationAPI.Models
{
    public class Meal
    {
        public int Id { get; set; }
        public DayOfWeek Day { get; set; }
        public MealType Type { get; set; }
        public string RecipeName { get; set; } = "";
        public string RecipeInstructions { get; set; } = "";
        public int PreTimeMinutes { get; set; }
        public int CookTimeMinutes { get; set; }
        public int Servings { get; set; }
        public string NutritionInfo { get; set; } = "{}";

        // Foreign key
        public int MealPlanId { get; set; }

        // Navigation property
        public required MealPlan MealPlan { get; set; }
        public ICollection<MealIngredient> Ingredients { get; set; } = [];

    }
    public enum MealType
    {
        Breakfast,
        Lunch,
        Dinner,
        Snack
    }
}
