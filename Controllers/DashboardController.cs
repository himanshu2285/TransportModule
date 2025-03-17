using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;
using TransportModule1.Data; // Your DbContext namespace
using TransportModule1.Models; // Your Bills model namespace

namespace TransportModule.Controllers
{
    public class DashboardController : Controller
    {
        private readonly AppDbContext _context;

        public DashboardController(AppDbContext context)
        {
            _context = context;
        }

        // Display Bills
        public async Task<IActionResult> Index()
        {
            var bills = _context.Bills.ToList();
            return View(bills);
        }

        // Create New Bill (GET)
        public IActionResult CreateBill()
        {
            return View();
        }

        // Create New Bill (POST)
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateBill(Bills bill)
        {
            if (ModelState.IsValid)
            {
                _context.Bills.Add(bill);
                await _context.SaveChangesAsync(); // Fixed: Added await
                return RedirectToAction("Index", "Dashboard");
            }
            return View(bill);
        }
        // Edit Bill (GET)
        public IActionResult EditBill(int id)
        {
            var bill = _context.Bills.FirstOrDefault(b => b.Id == id);
            if (bill == null)
            {
                return NotFound();
            }
            return View(bill);
        }
        // Edit Bill (POST)
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditBill(int id, Bills bill)
        {
            if (id != bill.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(bill);  // EF Core will track changes automatically
                    await _context.SaveChangesAsync();
                }
                catch (Exception ex)
                {
                    ModelState.AddModelError("", "An error occurred while updating the bill.");
                    return View(bill);
                }

                return RedirectToAction("Index", "Dashboard"); // Redirect to list
            }

            return View(bill);
        }

    }
}
