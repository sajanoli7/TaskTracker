using Microsoft.AspNetCore.Identity;

namespace TaskTracker.Models
{
    public class UserInfo : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime Dob {  get; set; }

        public ICollection<TaskItem> TaskItems { get; set; }
        public ICollection<Comment> Comments { get; set; }
    }
}
