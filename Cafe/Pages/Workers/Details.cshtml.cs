using Cafe.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace Cafe.Pages.Workers
{
    public class DetailsModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public DetailsModel(ApplicationDbContext context)
        {
            _context = context;
        }

        public Cafe.Model.Worker Worker { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int id)
        {
            Worker = await _context.Workers
                .FirstOrDefaultAsync(p => p.Id == id);

            if (Worker == null)
            {
                return NotFound();
            }

            return Page();
        }
    }
}
