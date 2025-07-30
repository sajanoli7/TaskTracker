using Microsoft.AspNetCore.Mvc;

namespace TaskTracker.Controllers
{
    public class CommentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
