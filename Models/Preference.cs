namespace IntelligentMealPreparationAPI.Models
{
    public class Preference
    {
        //Primary properties
        public int Id { get; set; }
        public string DietaryRestrictions { get; set; } = "";
        public int ServingSize { get; set; }
        public int MaxCookingTimeMinutes { get; set; }
        public SkillLevel SkillLevel { get; set; } = SkillLevel.Beginner;
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;


        // Foreign key
        public int UserId { get; set; }

        // Navigation property
        public required User User { get; set; }
        public ICollection<DietaryRestriction> DietaryRestrictionsList { get; set; } = [];
        public ICollection<Allergies> AllergiesList { get; set; } = [];
    }
    // Enum for SkillLevel
    public enum SkillLevel
    {
        Beginner,
        Intermediate,
        Advanced
    }

}
