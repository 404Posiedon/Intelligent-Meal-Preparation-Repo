namespace IntelligentMealPreparationAPI.Models
{
    public class Allergies
    {
        public int Id { get; set; }
        public string Name { get; set; } = "";
        public string Description { get; set; } = "";
        // Foreign key
        public int PreferenceId { get; set; }
        // Navigation property
        public required Preference Preference { get; set; }
    }
}
