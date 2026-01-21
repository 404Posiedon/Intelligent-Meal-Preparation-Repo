using IntelligentMealPreparationAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace IntelligentMealPreparationAPI.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        //Register DbSets for the models
        public DbSet<User> Users { get; set; }
        public DbSet<Preference> Preferences { get; set; }
        public DbSet<DietaryRestriction> DietaryRestrictions { get; set; }
        public DbSet<Allergies> Allergies { get; set; }
        public DbSet<ShoppingList> ShoppingLists { get; set; }
        public DbSet<MealPlan> MealPlans { get; set; }
        public DbSet<Meal> Meals { get; set; }
        public DbSet<PantryItem> PantryItems { get; set; }
        public DbSet<MealIngredient> MealIngredients { get; set; }
        public DbSet<ShoppingListItem> ShoppingListItems { get; set; }


    }
}
