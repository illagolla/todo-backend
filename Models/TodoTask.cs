using System.ComponentModel.DataAnnotations;

namespace todo_backend.Models
{
    public class TodoTask
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "A title is required")]
        [StringLength(20, ErrorMessage = "Maximum 20 characters.")]
        public string Title { get; set; } = string.Empty;

        [StringLength(100, ErrorMessage = "Maximum 100 characters.")]
        public string Description { get; set; } = string.Empty;

        public bool IsCompleted { get; set; } = false;
    }
}
