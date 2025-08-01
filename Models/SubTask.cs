namespace TaskTracker.Models
{
    public class SubTask
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsCompleted { get; set; }
        public int TaskItemId { get; set; }
        public TaskItem TaskItem { get; set; }
        public ICollection<Comment> Comments { get; set; }
    }
}
