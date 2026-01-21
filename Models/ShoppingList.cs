namespace IntelligentMealPreparationAPI.Models
{
    public class ShoppingList
    {
        //Primary properties
        public int Id { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
        public ShoppingListStatus Status { get; set; } = ShoppingListStatus.Pending;

        // Foreign key
        public int MealPlanId { get; set; }

        // Navigation property
        public required MealPlan MealPlan { get; set; } 
        public ICollection<ShoppingListItem> Items { get; set; } = new List<ShoppingListItem>();
    }
    public enum ShoppingListStatus
    {
        Pending,
        Purchased,
        Cancelled
    }
}
