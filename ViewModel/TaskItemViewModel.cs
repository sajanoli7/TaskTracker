using System.ComponentModel.DataAnnotations;

namespace TaskTracker.ViewModel
{
    public class TaskItemViewModel
    {
        public int Id { get; set; }
        [Required]
        [StringLength(30, ErrorMessage = "Title cannot be longer than 30 characters.")]
        public string Title { get; set; }
        [StringLength(60, ErrorMessage = "Title cannot be longer than 60 characters.")]
        public string Description { get; set; }
        public string Type { get; set; }
        [Required]
        [Display(Name = "Is Task completed")]
        public bool IsCompleted { get; set; }

    }
}
