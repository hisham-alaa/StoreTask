using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace StoreTask.Core.Models
{
    public enum ClientState
    {
        [EnumMember(Value = "Active")]
        Active,

        [EnumMember(Value = "InActive")]
        InActive,

        [EnumMember(Value = "Pending")]
        Pending
    }
}
