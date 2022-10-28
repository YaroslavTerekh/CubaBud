using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CubaBud.Domain.Models
{
    public class CallBack : BaseModel
    {
        public string PhoneNumber { get; set; }
        public string? Email { get; set; }
        public string Wishes { get; set; }
    }
}
