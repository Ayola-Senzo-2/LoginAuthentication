using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;


namespace CustomAuth.Entities
{
    [Index(nameof(Email), IsUnique = true)]
    [Index(nameof(Username), IsUnique = true)]
    public class UserAccount
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "First name is required.")]
        [MaxLength(50, ErrorMessage = "Max character allowed is 50.")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Last name is required.")]
        [MaxLength(50,ErrorMessage = "Max character allowed is 50")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "Email is required.")]
        [MaxLength(100, ErrorMessage = "Max character allowed is 100.")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Username is required.")]
        [MaxLength(20,ErrorMessage = "Max character allowed is 20.")]
        public string Username { get; set; }
        [Required(ErrorMessage = "Password is required")]
        [MaxLength(20, ErrorMessage = "Max 20 allowed characters allowed.")]
        public string Password { get; set; }

    }
}
