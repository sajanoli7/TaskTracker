using System.ComponentModel.DataAnnotations;

namespace TaskTracker.ViewModel
{
    public class TaskCategoryViewModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="TaskCategory must be specified")]
        public string Name { get; set; }
    }
}
