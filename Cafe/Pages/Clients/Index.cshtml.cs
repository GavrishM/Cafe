using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Cafe.Data;
using Cafe.Model;

namespace Cafe.Pages.Objects.Clients
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public IndexModel(ApplicationDbContext context)
        {
            _context = context;
        }
        public List<Client> ClientsList { get; set; }

        public void OnGet()
        {
            ClientsList = _context.Clients.ToList();
        }
    }
}
