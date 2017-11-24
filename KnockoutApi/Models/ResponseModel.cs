using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnockoutApi.Models
{
    public class ResponseModel
    {
        public bool IsSuccess { get; set; }
        public dynamic ResponseData { get; set; }
    }
}
