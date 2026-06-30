using Cafe.Data;
using Cafe.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Cafe.Pages.Orders
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public IndexModel(ApplicationDbContext context)
        {
            _context = context;
        }
        public List<Order> OrdersList { get; set; }

        public void OnGet()
        {
            OrdersList = _context.Orders.ToList();
        }
    }
}
