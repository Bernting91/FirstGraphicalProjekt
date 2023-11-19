using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift_3___Grafiskt_Program_Inlämning
{
    public class Item
    {
        public string Type { get; set; }
        public Item(String type)
        {
            this.Type = type;
        }
        public override String ToString()
        {
            return this.Type;
        }
    }
}
