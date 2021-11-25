using System.ComponentModel.DataAnnotations;

namespace WebAPI.Models
{
    public class RegisterVm
    {
        [Required]
        public string Username { get; set; }
        [Required]

        public string Password { get; set; }
        [Required]
        [Compare("Password")]
        public string ConfirmPassword { get; set; }
    }
}
