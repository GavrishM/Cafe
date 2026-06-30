using Cafe.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace Cafe.Pages.Clients
{
    public class EditModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public EditModel(ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Cafe.Model.Client Client { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int id)
        {
            Client = await _context.Clients
                .FirstOrDefaultAsync(p => p.Id == id);

            if (Client == null)
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

            var clientToUpdate = await _context.Clients.FindAsync(Client.Id);
            if (clientToUpdate == null)
            {
                return NotFound();
            }

            clientToUpdate.FullName = Client.FullName;
            clientToUpdate.Email = Client.Email;
            clientToUpdate.Phone = Client.Phone;
            clientToUpdate.Age = Client.Age;

            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }

        private void LoadSelectLists()
        {
            
        }
    }
}
