using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
public    class LegajoItem
    {
        public Item item { get; set; }
        public ReciboSueldo ReciboSueldo { get; set; }
        public int valor { get; set; }
        public LegajoItem()
        {
            item = new Item();
            ReciboSueldo = new ReciboSueldo();
        }
    }
}
