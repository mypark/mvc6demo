using System.ComponentModel.DataAnnotations;

namespace ttg_api.Models
{
    public class TodoItem {
        [Required]
        public string Key { get; set; }
        [Required(ErrorMessage = "name is always required")]
        public string Name { get; set; }
        public bool IsComplete { get; set; }
    }
}