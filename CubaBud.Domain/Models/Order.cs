using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CubaBud.Domain.Models
{
    public class Order : BaseModel
    {
        public House House { get; set; }
        public int Discount { get; set; }
    }
}
