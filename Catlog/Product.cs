using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catlog
{
    public class Product
    {
        public int Id { get; set; } 
        public string title { get; set; }            

        public string Description { get; set; } 

        public int Unitp { get; set; }

        public int Quantity { get; set; }
        //public int Id { get; set; }
        public string Name { get; set; }
        //public string Description { get; set; }
        public int UnitPrice { get; set; }
        //public int Quantity { get; set; }
        public string Image { get; set; }

    }
}
