using System.ComponentModel.DataAnnotations;

namespace WebAPI.Models
{
    public class CreateNoteDto
    {
        [Required]
        public string Title { get; set; }
        public string Details { get; set; }
    }
}
