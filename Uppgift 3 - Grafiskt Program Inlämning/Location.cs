using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift_3___Grafiskt_Program_Inlämning
{
    public class Location
    {
        public string Hideout { get; set; }
        public Item Loot { get; set; }
        public Location(String hideout, Item loot)
        {
            this.Hideout = hideout;
            this.Loot = loot;
        }
        public Item getLoot()
        {
            return this.Loot;
        }
    }
}
