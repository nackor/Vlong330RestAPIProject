using System.ComponentModel.DataAnnotations;

namespace VlongFinalProject.Models
{
    public class User
    {
        public int UserID { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
        public DateTime Created { get; set; }
    }
}
