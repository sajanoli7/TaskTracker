using System.ComponentModel.DataAnnotations;

namespace TaskTracker.ViewModel
{
    public class CommentViewModel
    {
        public int Id { get; set; }
        [StringLength(150, ErrorMessage = "Comment cannot be longer than 150 characters.")]
        public string Text { get; set; }
        [DataType(DataType.Date)]
        public DateTime CreatedDate { get; set; }

    }
}
