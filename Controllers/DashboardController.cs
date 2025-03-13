using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

namespace TransportModule1.Controllers
{
    [Authorize] // Only allow authenticated users
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
