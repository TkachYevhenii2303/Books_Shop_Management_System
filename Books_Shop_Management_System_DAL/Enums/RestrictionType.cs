using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Books_Shop_Management_System_DAL.Enums
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum RestrictionType
    {
        Teen = 0, 
        
        Adult = 1,

        Minor = 2,
    }
}
