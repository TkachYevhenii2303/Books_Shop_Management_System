using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Books_Shop_Management_System_DTO.Data_transfer_objects.Response_Result_DTO
{
    public class GetBooksByPriceResultDTO
    {
        public string Title { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;

        public string Total { get; set; } = string.Empty;
    }
}
