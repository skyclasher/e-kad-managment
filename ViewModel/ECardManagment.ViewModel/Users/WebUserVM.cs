using System.ComponentModel.DataAnnotations;

namespace ECardManagment.ViewModel.Users
{
    public class WebUserVM
    {
        public int? Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        [Required]
        public string Username { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
