using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using InternalBookingApp.Data;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace InternalBookingApp.Controllers
{
    public class DashboardController : Controller
    {
        private readonly ApplicationDbContext _context;

        public DashboardController(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var today = DateTime.Today;
            var upcoming = today.AddDays(7);

            var bookings = await _context.Bookings
                .Include(b => b.Resource)
                .Where(b => b.StartTime.Date >= today && b.StartTime.Date <= upcoming)
                .OrderBy(b => b.StartTime)
                .ToListAsync();

            return View(bookings);
        }
    }
}
