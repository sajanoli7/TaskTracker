using Microsoft.EntityFrameworkCore;
using System;
using TaskTracker.Data;
using TaskTracker.Models;
using TaskTracker.Services.Interface;
using TaskTracker.ViewModel;

namespace TaskTracker.Services.Implementation
{
    public class TaskCategoryService : ITaskCategoryService
    {
        private readonly ApplicationDbContext _context;

        public TaskCategoryService(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<List<TaskCategoryViewModel>> GetTaskCategories()
        {

            List<TaskCategoryViewModel> taskCategoryList = new List<TaskCategoryViewModel>();

            var categories = await _context.TaskCategories.ToListAsync();

            if (categories != null)
            {
                foreach (var category in categories)
                {
                    var data = new TaskCategoryViewModel();
                    data.Id = category.Id;
                    data.Name = category.Name;
                    taskCategoryList.Add(data);

                }
            }
            return taskCategoryList;
        }


        public async Task<TaskCategoryViewModel> AddAsync(TaskCategoryViewModel model)
        {
            TaskCategory category = new TaskCategory();
            category.Name = model.Name;

            var isExist = await _context.TaskCategories.AnyAsync(x => x.Name.ToLower() == model.Name.ToLower());

            if (isExist)
            {
                return model;
            }
            await _context.TaskCategories.AddAsync(category);
            await _context.SaveChangesAsync();
            model.Id = category.Id;
            return model;
        }

        public async Task<TaskCategoryViewModel> UpdateAsync(TaskCategoryViewModel model)
        {

            var dbData = await _context.TaskCategories.Where(x => x.Id == model.Id).FirstOrDefaultAsync();
            if (dbData != null)
            {
                dbData.Name = model.Name;
                _context.TaskCategories.Update(dbData);
                await _context.SaveChangesAsync();
            }
            return model;
        }

        public async Task<TaskCategoryViewModel> DeleteAsync(int id)
        {
            var dbData = await _context.TaskCategories.Where(x => x.Id == id).FirstOrDefaultAsync();
            if (dbData != null)
            {
                _context.TaskCategories.Remove(dbData);
                await _context.SaveChangesAsync();
            }
            return new TaskCategoryViewModel { Id = id };
        }
    }
}