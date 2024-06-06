using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreTask.Core.Models
{
    public class ClientProducts : BaseModel
    {
        public int ClientId { get; set; }
        public int ProductId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; } // Optional
        public string License { get; set; }
    }
}
