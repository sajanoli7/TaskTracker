using System.ComponentModel.DataAnnotations;

namespace TaskTracker.Models
{
    public class Comment
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(500)]
        public string Text { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;

        public int? TaskItemId { get; set; }
        public TaskItem TaskItem { get; set; }
        public int? SubTaskId { get; set; }
        public SubTask SubTask { get; set; }
        public string UserId { get; set; }
        public UserInfo User { get; set; }


    }
}
