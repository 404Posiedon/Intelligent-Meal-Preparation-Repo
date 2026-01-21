namespace IntelligentMealPreparationAPI.Models
{
    public class MealPlan
    {
        public int Id { get; set; }
        public DateTime WeekStartDate { get; set; }
        public DateTime WeekEndDate { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public MealPlanStatus Status { get; set; } = MealPlanStatus.Draft;

        // Foreign key
        public int UserId { get; set; }

        // Navigation properties
        public required User User { get; set; }
        public ICollection<Meal> Meals { get; set; } = new List<Meal>();
        public ShoppingList? ShoppingList { get; set; }
    }
    public enum MealPlanStatus
    {
        Draft,
        Active,
        Completed
    }
}
