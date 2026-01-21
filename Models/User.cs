using System.ComponentModel.DataAnnotations;

namespace IntelligentMealPreparationAPI.Models
{
    public class User
    {
        // Primary properties
        public int Id { get; set; }
        public string Email { get; set; } = "";
        public string PasswordHash { get; set; } = "";
        public string FirstName { get; set; } = "";
        public string LastName { get; set; } = "";
        public int Age { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;

        // Navigation properties
        public Preference? Preference { get; set; }
        public List<PantryItem> PantryItems { get; set; } = new();
        public List<MealPlan> MealPlans { get; set; } = new();

    }
}
