using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPCart
{
    internal class Item
    {
        // Class Information
        public string Name { get; set; }
        public double Price { get; set; }
        public double Quantity { get; set; } // เปลี่ยนเป็น double
        public bool IsChecked { get; set; }
    }
}
