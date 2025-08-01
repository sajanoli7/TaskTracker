using System.ComponentModel.DataAnnotations;

namespace TaskTracker.ViewModel
{
    public class SubTaskViewModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Name of SubTask is required")]
        public string Name { get; set; }
        [StringLength(60, ErrorMessage = "Description cannot be longer than 60 characters.")]
        public string Description { get; set; }
        [Required]
        [Display(Name = "Is Task completed")]
        public bool IsCompleted { get; set; }

    }
}

