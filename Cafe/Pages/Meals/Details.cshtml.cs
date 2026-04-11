using Cafe.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace Cafe.Pages.Meals
{
    public class DetailsModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public DetailsModel(ApplicationDbContext context)
        {
            _context = context;
        }

        public Cafe.Model.Meal Meal { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int id)
        {
            Meal = await _context.Meals
                .FirstOrDefaultAsync(p => p.Id == id);

            if (Meal == null)
            {
                return NotFound();
            }

            return Page();
        }
    }
}
