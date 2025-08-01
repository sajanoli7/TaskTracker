using Microsoft.AspNetCore.Mvc;

namespace TaskTracker.Controllers
{
    public class TaskItemController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
