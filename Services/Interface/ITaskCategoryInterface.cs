using TaskTracker.Models;
using TaskTracker.ViewModel;

namespace TaskTracker.Services.Interface
{
    public interface ITaskCategoryService
    {
        Task<List<TaskCategoryViewModel>> GetTaskCategories();
        Task<TaskCategoryViewModel> AddAsync(TaskCategoryViewModel model);
        Task<TaskCategoryViewModel> UpdateAsync(TaskCategoryViewModel model);
        Task<TaskCategoryViewModel> DeleteAsync(int id);
    }
}
