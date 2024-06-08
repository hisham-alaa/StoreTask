using System.ComponentModel.DataAnnotations;

namespace StoreTask.Razor.ViewModels
{
    public class ProductViewModel
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(50, ErrorMessage = "Maximum length is 50!")]
        public string Name { get; set; }

        [Required]
        [MaxLength(150, ErrorMessage = "Maximum length is 150!")]
        public string Description { get; set; }

        [Required]
        [Display(Name = "Active")]
        public bool IsActive { get; set; }
    }
}
