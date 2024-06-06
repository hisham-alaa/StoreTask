using Microsoft.AspNetCore.Mvc.RazorPages;
using StoreTask.Core.Models;
using StoreTask.Core.Repositories.Contract;

namespace StoreTask.Razor.Pages.Clients
{
    public class IndexModel : PageModel
    {
        public readonly IClientRepository _clientRepository;
        public IEnumerable<Client> clients { get; set; }
        public IndexModel(IClientRepository clientRepository)
        {
            _clientRepository = clientRepository;
        }
        public void OnGet()
        {
            clients = _clientRepository.GetClients();
        }
    }
}
