using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Books_Shop_Management_System_DAL.Enums
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum EditionType
    {
        None = 0,

        Traditional = 1,

        Self = 2,

        Partnership = 3,

        PopularMagazines = 4,

        TradeJournals = 5,

        ScholarlyJournals = 6
    }
}
