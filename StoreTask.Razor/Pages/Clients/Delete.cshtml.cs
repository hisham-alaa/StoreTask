using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using StoreTask.Core.Models;
using StoreTask.Core.Services.Contract;

namespace StoreTask.Razor.Pages.Clients
{
    public class DeleteModel : PageModel
    {
        private readonly IClientService _clientService;

        [BindProperty]
        public Client client { get; set; }

        public void OnGet()
        {
        }

        public void OnPost()
        {

        }
    }
}
