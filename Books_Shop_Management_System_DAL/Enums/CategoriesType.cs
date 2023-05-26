using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Books_Shop_Management_System_DAL.Enums
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum CategoriesType
    {
        ActionAndAdventure = 0,
        
        Classics = 1,
        
        ComicBookGraphicNovel = 2,
        
        DetectiveAndMystery = 3,
        
        Fantasy = 4,
        
        HistoricalFiction = 5,
        
        Horror = 6,

        LiteraryFiction = 7
    }
}
