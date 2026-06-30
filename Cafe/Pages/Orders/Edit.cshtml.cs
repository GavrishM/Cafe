using Cafe.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace Cafe.Pages.Orders
{
    public class EditModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public EditModel(ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Cafe.Model.Order Order { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int id)
        {
            Order = await _context.Orders
                .FirstOrDefaultAsync(p => p.Id == id);

            if (Order == null)
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

            var orderToUpdate = await _context.Orders.FindAsync(Order.Id);
            if (orderToUpdate == null)
            {
                return NotFound();
            }

            orderToUpdate.NumberOrder = Order.NumberOrder;
            orderToUpdate.TotalAmount = Order.TotalAmount;
            orderToUpdate.Status = Order.Status;

            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }

        private void LoadSelectLists()
        {

        }
    }
}
