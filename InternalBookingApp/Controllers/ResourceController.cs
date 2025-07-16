using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using InternalBookingApp.Data;
using InternalBookingApp.Models;
using System.Linq;
using System.Threading.Tasks;

namespace InternalBookingApp.Controllers
{
    public class ResourceController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ResourceController(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _context.Resources.ToListAsync());
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Description,Location,Capacity,IsAvailable")] Resource resource)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    _context.Add(resource);
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
                catch (Exception ex)
                {
                    ModelState.AddModelError(string.Empty, "Database error: " + ex.Message);
                }
            }
            return View(resource);
        }
    }
}
