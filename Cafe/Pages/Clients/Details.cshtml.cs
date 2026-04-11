using Cafe.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace Cafe.Pages.Clients
{
    public class DetailsModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public DetailsModel(ApplicationDbContext context)
        {
            _context = context;
        }

        public Cafe.Model.Client Client { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int id)
        {
            Client = await _context.Clients
                .FirstOrDefaultAsync(p => p.Id == id);

            if (Client == null)
            {
                return NotFound();
            }

            return Page();
        }
    }
}
