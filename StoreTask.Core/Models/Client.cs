
namespace StoreTask.Core.Models
{
    public class Client : BaseModel
    {
        public string Name { get; set; }
        public string Code { get; set; }
        public ClientClass Class { get; set; }
        public ClientState State { get; set; }

    }
}
