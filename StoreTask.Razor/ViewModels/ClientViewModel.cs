using StoreTask.Core.Models;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace StoreTask.Razor.ViewModels
{
    public class ClientViewModel
    {
        public int Id { get; set; }


        [Required]
        [Display(Name = "Client Name")]
        [MaxLength(50, ErrorMessage = "Maximum length is 50!")]
        [MinLength(3, ErrorMessage = "Minimum length is 3!")]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Client Code")]
        [RegularExpression(@"^\d{9}$", ErrorMessage = "code must be 9 digits only")]
        public string Code { get; set; }

        [Required]
        [Display(Name = "Client Class")]
        public ClientClass Class { get; set; }

        [Required]
        [Display(Name = "Client State")]
        public ClientState State { get; set; }
    }
}
