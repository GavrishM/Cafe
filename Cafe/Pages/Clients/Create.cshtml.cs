using Cafe.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Cafe.Pages.Clients
{
    public class CreateModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public CreateModel(ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Cafe.Model.Client Client { get; set; } = new("", "", "", 0);

        //public SelectList TypeList { get; set; } = default!;
        //public SelectList PublisherList { get; set; } = default!;

        public void OnGet()
        {
            //LoadSelectLists();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                //LoadSelectLists();
                return Page();
            }

            _context.Clients.Add(Client);
            await _context.SaveChangesAsync();

            return RedirectToPage("Index");
        }

        //private void LoadSelectLists()
        //{
        //    TypeList = new SelectList(_context.ProductTypes, "Id", "Name");
        //    PublisherList = new SelectList(_context.Publishers, "Id", "Name");
        //}
    }
}
