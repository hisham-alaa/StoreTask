using System.ComponentModel.DataAnnotations.Schema;

namespace StoreTask.Core.Models
{
    public class Client : BaseModel
    {
        public string Name { get; set; }
        public string Code { get; set; }
        public ClientClass Class { get; set; }
        public ClientState State { get; set; }

        public virtual ICollection<ClientProducts> ClientProducts { get; set; } = new List<ClientProducts>();

        [NotMapped]
        public IEnumerable<Product> Products => ClientProducts.Select(cp => cp.Product);

    }
}
