using Microsoft.AspNetCore.Mvc;
using TaskTracker.Services.Implementation;
using TaskTracker.Services.Interface;
using TaskTracker.ViewModel;

namespace TaskTracker.Controllers
{
    public class TaskCategoryController : Controller
    {

        private readonly ITaskCategoryService _taskCategoryService;

        public TaskCategoryController(ITaskCategoryService taskCategoryService)
        {
            _taskCategoryService = taskCategoryService;
        }

        public async Task<IActionResult> Index()
        {
            var categories = await _taskCategoryService.GetTaskCategories();

            if (categories == null)
            {
                return View(new List<TaskCategoryViewModel>());
            }
            return View(categories);
        }


        [HttpGet]
        public IActionResult Create()
        {

            var model = new TaskCategoryViewModel();
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Create(TaskCategoryViewModel model)
        {

            if (ModelState.IsValid)
            {
                var result = await _taskCategoryService.AddAsync(model);

                if (result.Id > 0)
                {
                    return RedirectToAction("Index");
                }
            }
            ViewBag.Message = "Plz try agian";
            return View(new TaskCategoryViewModel());
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            var categories = await _taskCategoryService.GetTaskCategories();
            var category = categories.FirstOrDefault(x => x.Id == id);

            if (category == null)
            {
                return NotFound();
            }

            return View(category);
        }


        [HttpPost]
        public async Task<IActionResult> Edit(TaskCategoryViewModel model)
        {

            if (ModelState.IsValid)
            {
                var result = await _taskCategoryService.UpdateAsync(model);

                if (result.Id > 0)
                {
                    return RedirectToAction("Index");
                }
            }
            ViewBag.Message = "Plz try agian";
            return View(new TaskCategoryViewModel());
        }

        [HttpPost]
        public async Task<IActionResult> Delete(int id)
        {
            if (id <= 0)
            {
                return BadRequest("Invalid ID");
            }
            var result = await _taskCategoryService.DeleteAsync(id);
            if (result != null && result.Id > 0)
            {
                return RedirectToAction("Index");
            }
            ViewBag.Message = "Error deleting category";
            return View("Index", await _taskCategoryService.GetTaskCategories());

        }
    }
}