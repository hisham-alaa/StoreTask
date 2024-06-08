using StoreTask.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreTask.Core.Repositories.Contract
{
    public interface IClientRepository
    {
        public IEnumerable<Client> GetClients();
        public Client GetClientById(int id);
        public Client CreateClient(Client client);
        public Client UpdateClient(Client updatedClient);
        public Client DeleteClient(int id);
    }
}
