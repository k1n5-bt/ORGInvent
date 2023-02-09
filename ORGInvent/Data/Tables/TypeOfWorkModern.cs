using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ORGInvent.Data.Tables
{
    public enum TypeOfWorkModern
    {
        [EnumMember(Value = "Ремонт")]
        Fix,

        [EnumMember(Value = "Модернизация")]
        Modernization,
    }
}
