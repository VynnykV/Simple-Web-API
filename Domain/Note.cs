using System;
using System.ComponentModel.DataAnnotations;

namespace Domain
{
    public class Note
    {
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Details { get; set; }
        [Required]
        public DateTime CreationDate { get; set; }
        public DateTime? EditDate { get; set; }
        [Required]
        public int UserId { get; set; }
        public User User { get; set; }
    }
}
