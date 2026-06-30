using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Cafe.Data;
using Cafe.Model;

namespace Cafe.Pages.Clients
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public IndexModel(ApplicationDbContext context)
        {
            _context = context;
        }
        public List<Client> Clients { get; set; }

        public void OnGet()
        {
            Clients = _context.Clients.ToList();
        }
    }
}
