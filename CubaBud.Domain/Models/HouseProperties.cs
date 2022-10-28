using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CubaBud.Domain.Models
{
    public class HouseProperties
    {
        public int FloorQuantity { get; set; }
        public int KitchenQuantity { get; set; }
        public int BedRoomQuantity { get; set; }
        public int BathRoomQuantity { get; set; }
        public int LivingRoomQuantity { get; set; }
        public int TotalRoomQuantity { get
            {
                return KitchenQuantity + BedRoomQuantity + LivingRoomQuantity;
            } 
        }
    }
}
