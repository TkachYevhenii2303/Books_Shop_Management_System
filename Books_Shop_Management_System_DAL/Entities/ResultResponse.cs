using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Books_Shop_Management_System_DAL.Entities
{
    public class ResultResponse<TResult>
    {
        public TResult? Result { get; set; }
        
        public string Message { get; set; } = string.Empty;

        public bool Success { get; set; } = true;
    }
}
