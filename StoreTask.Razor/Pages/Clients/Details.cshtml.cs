using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using StoreTask.Core.Models;
using StoreTask.Core.Repositories.Contract;

namespace StoreTask.Razor.Pages.Clients
{
    public class DetailsModel : PageModel
    {
        private readonly IClientRepository _clientRepository;
        public Client Client { get; private set; }

        public DetailsModel(IClientRepository clientRepository)
        {
            _clientRepository = clientRepository;
        }

        public void OnGet(int id)
        {
            Client = _clientRepository.GetClientById(id);
        }
    }
}
