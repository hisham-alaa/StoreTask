using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace StoreTask.Core.Models
{
    public class ClientProducts : BaseModel
    {

        [ForeignKey("Client")]
        public int ClientId { get; set; }

        [ForeignKey("Product")]
        public int ProductId { get; set; }

        public DateTime StartDate { get; set; } = DateTime.Now;

        public DateTime? EndDate { get; set; } // Optional

        [StringLength(255)]
        public string License { get; set; }

        public Product Product { get; set; }
    }
}
