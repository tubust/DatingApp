using System.ComponentModel.DataAnnotations;

namespace DatingApp.API.DTO
{
    public class UserForRegisterDto
    {
        [Required]
        public string Username { get; set; }

        [Required]
        [StringLength(16,MinimumLength = 8,ErrorMessage = "Your password must be between 8 and 16 characters")]
        public string Password{ get; set;}
    }
}