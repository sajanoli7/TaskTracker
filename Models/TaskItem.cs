namespace TaskTracker.Models
{
    public class TaskItem
{
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Type { get; set; }
        public bool IsCompleted { get; set; }
        public int TaskCategoryId { get; set; }
        public TaskCategory TaskCategory { get; set; }
        public string UserId { get; set; }
        public UserInfo UserInfo { get; set; }
        public ICollection<SubTask> SubTasks { get; set; }
        public ICollection<Comment> Comments { get; set; }
    }
}
