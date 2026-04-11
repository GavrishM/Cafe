using Cafe.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace Cafe.Pages.Workers
{
    public class EditModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public EditModel(ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Cafe.Model.Worker Worker { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int id)
        {
            Worker = await _context.Workers
                .FirstOrDefaultAsync(p => p.Id == id);

            if (Worker == null)
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

            var workerToUpdate = await _context.Workers.FindAsync(Worker.Id);
            if (workerToUpdate == null)
            {
                return NotFound();
            }

            workerToUpdate.FullName = Worker.FullName;
            workerToUpdate.Age = Worker.Age;
            workerToUpdate.Position = Worker.Position;
            workerToUpdate.Phone = Worker.Phone;

            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }

        private void LoadSelectLists()
        {

        }
    }
}
