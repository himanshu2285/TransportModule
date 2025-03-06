using Microsoft.AspNetCore.Mvc;

namespace TransportModule1.Controllers
{
    public class BillsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
