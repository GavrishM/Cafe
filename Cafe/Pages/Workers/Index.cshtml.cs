using Cafe.Data;
using Cafe.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Cafe.Pages.Workers
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public IndexModel(ApplicationDbContext context)
        {
            _context = context;
        }
        public List<Worker> WorkersList { get; set; }

        public void OnGet()
        {
            WorkersList = _context.Workers.ToList();
        }
    }
}
