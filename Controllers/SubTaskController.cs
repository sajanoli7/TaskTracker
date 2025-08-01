using Microsoft.AspNetCore.Mvc;

namespace TaskTracker.Controllers
{
    public class SubTaskController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
