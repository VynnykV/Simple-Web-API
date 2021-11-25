using System.ComponentModel.DataAnnotations;

namespace WebAPI.Models
{
    public class UpdateNoteDto
    {
        [Required]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Details { get; set; }
    }
}
