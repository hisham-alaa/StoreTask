using StoreTask.Core.Models;

namespace StoreTask.Core.Services.Contract
{
    public interface IClientService
    {
        public Client AddClient(Client newClient);
    }
}
