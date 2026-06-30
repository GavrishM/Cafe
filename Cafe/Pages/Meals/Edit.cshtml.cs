using Cafe.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace Cafe.Pages.Meals
{
    public class EditModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public EditModel(ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Cafe.Model.Meal Meal { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int id)
        {
            Meal = await _context.Meals
                .FirstOrDefaultAsync(p => p.Id == id);

            if (Meal == null)
            {
                return NotFound();
            }

            LoadSelectLists();
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                LoadSelectLists();
                return Page();
            }

            var mealToUpdate = await _context.Meals.FindAsync(Meal.Id);
            if (mealToUpdate == null)
            {
                return NotFound();
            }

            mealToUpdate.Name = Meal.Name;
            mealToUpdate.Type = Meal.Type;
            mealToUpdate.Description = Meal.Description;
            mealToUpdate.Contains = Meal.Contains;
            mealToUpdate.Price = Meal.Price;
            mealToUpdate.Weight = Meal.Weight;
            mealToUpdate.Status = Meal.Status;

            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }

        private void LoadSelectLists()
        {

        }
    }
}
