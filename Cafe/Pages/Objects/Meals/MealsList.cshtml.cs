using Cafe.Data;
using Cafe.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Cafe.Pages.Objects.Meals
{
    public class MealsListModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public MealsListModel(ApplicationDbContext context)
        {
            _context = context;
        }
        public List<Meal> MealsList { get; set; }

        public void OnGet()
        {
            MealsList = _context.Meals.ToList();
        }
    }
}
