using System.ComponentModel.DataAnnotations;

namespace BookStore.API.Models
{
    public class SignUpModel
    {
        [Required]
        public string FirstName { get; set; } = null!;
        [Required]
        public string LastName { get; set; } = null!;
        [Required, EmailAddress]
        public string Email { get; set; } = null!;
        [Required, Compare("ConfirmedPassword")]
        public string Password { get; set; } = null!;
        [Required]
        public string ConfirmedPassword { get; set; } = null!;
    }
}
