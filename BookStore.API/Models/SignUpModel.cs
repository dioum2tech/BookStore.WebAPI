using System.ComponentModel.DataAnnotations;

namespace BookStore.API.Models
{
    public class SignUpModel
    {
        [Required]
        public string FirstName { get; set; } = string.Empty;
        [Required]
        public string LastName { get; set; } = string.Empty;
        [Required, EmailAddress]
        public string Email { get; set; } = string.Empty;
        [Required, Compare("ConfirmedPassword")]
        public string Password { get; set; } = string.Empty;
        [Required]
        public string ConfirmedPassword { get; set; } = string.Empty;
    }
}
