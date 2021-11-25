using System.ComponentModel.DataAnnotations;

namespace WebAPI.Models
{
    public class LoginVm
    {
        [Required]
        public string Username { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
