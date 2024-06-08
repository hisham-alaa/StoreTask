using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using StoreTask.Core.Models;
using StoreTask.Core.Repositories.Contract;
using StoreTask.Razor.ViewModels;

namespace StoreTask.Razor.Pages.Clients
{
    public class CreateModel : PageModel
    {
        [BindProperty]
        public ClientViewModel ClientVM { get; set; }

        private readonly IClientRepository _clientRepository;
        private readonly IMapper _mapper;


        public CreateModel(IClientRepository clientRepository, IMapper mapper)
        {
            _clientRepository = clientRepository;
            _mapper = mapper;
        }

        public void OnGet()
        {

        }

        public IActionResult OnPost()
        {
            var client = _mapper.Map<Client>(ClientVM);
            _clientRepository.CreateClient(client);
            return RedirectToPage("Index");
        }
    }
}