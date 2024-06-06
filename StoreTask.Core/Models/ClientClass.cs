using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace StoreTask.Core.Models
{
    public enum ClientClass
    {
        [EnumMember(Value = "ClassA")]
        ClassA,

        [EnumMember(Value = "ClassB")]
        ClassB,

        [EnumMember(Value = "ClassC")]
        ClassC

    }
}
