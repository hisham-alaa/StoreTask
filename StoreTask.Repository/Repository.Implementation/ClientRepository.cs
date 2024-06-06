using StoreTask.Core.Models;
using StoreTask.Core.Repositories.Contract;

namespace StoreTask.Repository.Repository.Implementation
{
    public class ClientRepository : IClientRepository
    {
        public List<Client> clients;
        public ClientRepository()
        {
            clients = new List<Client>
            {
                new Client { Id = 1, Name = "Client A", Code = "123", Class = ClientClass.ClassA, State = ClientState.Active },
                new Client { Id = 2, Name = "Client B", Code = "456", Class = ClientClass.ClassB, State = ClientState.InActive },
                new Client { Id = 3, Name = "Client C", Code = "789", Class = ClientClass.ClassC, State = ClientState.Pending }
            };
        }
        public IEnumerable<Client> GetClients()
        {
            return clients;
        }
        public Client GetClientById(int id)
        {
            return clients.ElementAt(0);
        }
    }
}
