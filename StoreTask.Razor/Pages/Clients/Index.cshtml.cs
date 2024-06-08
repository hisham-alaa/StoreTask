using Microsoft.AspNetCore.Mvc.RazorPages;
using StoreTask.Core.Models;
using StoreTask.Core.Repositories.Contract;

namespace StoreTask.Razor.Pages.Clients
{
    public class IndexModel : PageModel
    {
        private readonly IClientRepository _clientRepository;
        public IEnumerable<Client> clients { get; set; }
        public IndexModel(IClientRepository clientRepository)
        {
            _clientRepository = clientRepository;
        }

        //everytime the page loading this method is going to be called.
        //so prepare everything here.
        public void OnGet()
        {
            clients = _clientRepository.GetClients();
        }
    }
}
