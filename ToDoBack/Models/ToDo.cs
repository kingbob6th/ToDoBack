using System.ComponentModel.DataAnnotations;

namespace ToDoBack.Models
{
    public class ToDo
    {
        [Key]
        public int ToDoId { get; set; }
        [Required, MaxLength(250)]
        public string Details { get; set; }
        [Required]
        public bool IsCompleted { get; set; }
    }
}
