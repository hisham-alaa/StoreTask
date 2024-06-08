using Microsoft.EntityFrameworkCore;
using StoreTask.Core.Models;
using StoreTask.Core.Repositories.Contract;
using StoreTask.Repository.Contexts;

namespace StoreTask.Repository.Repository.Implementation
{
    public class ClientRepository : IClientRepository
    {
        private protected readonly StoreTaskDbContext _dbContext;

        public ClientRepository(StoreTaskDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IEnumerable<Client> GetClients()
        {
            return _dbContext.Clients;
        }

        public Client GetClientById(int id)
        {
            var client = _dbContext.Clients.Include(c => c.ClientProducts).FirstOrDefault(c => c.Id == id);
            return client;
        }

        public Client CreateClient(Client client)
        {
            _dbContext.Clients.Add(client);
            _dbContext.SaveChanges();
            return client;
        }

        public Client UpdateClient(Client updatedClient)
        {
            _dbContext.Clients.Update(updatedClient);
            _dbContext.SaveChanges();
            return updatedClient;
        }

        public Client DeleteClient(int id)
        {
            var clientToDelete = GetClientById(id);
            if (clientToDelete != null)
            {
                _dbContext.Clients.Remove(clientToDelete);
                _dbContext.SaveChanges();
            }
            return clientToDelete;
        }

    }
}
