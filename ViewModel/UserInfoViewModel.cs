using System.ComponentModel.DataAnnotations;

namespace TaskTracker.ViewModel
{
    public class UserInfoViewModel
    {
        [Required(ErrorMessage = "First Name is required")]
        [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "First Name can only contain letters")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Last Name is required")]
        [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "Last Name can only contain letters")]
        public string LastName { get; set; }
        [DataType(DataType.Date)]
        public DateTime Dob { get; set; }

    }
}
