using StoreTask.Core.Models;
using StoreTask.Core.Repositories.Contract;
using StoreTask.Core.Services.Contract;

namespace StoreTask.Service
{
    public class ClientService : IClientService
    {
        private readonly IClientRepository _clientRepository;

        public ClientService(IClientRepository clientRepository)
        {
            _clientRepository = clientRepository;
        }

        public Client AddClient(Client newClient)
        {
            return _clientRepository.CreateClient(newClient);
        }
    }
}
