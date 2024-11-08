using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POCO
{
    //Plain Old CLR Object
    //Business entitiy class which conatins only data
    //Are called POCO classes in .NET
    [Serializable]
    public class Product
    {
        public int Id { get; set; } 
        public string Title { get; set; }            

        public string Description { get; set; } 

        //public int Unitp { get; set; }

        public int Quantity { get; set; }
        //public int Id { get; set; }
        public string Name { get; set; }
        //public string Description { get; set; }
        public int UnitPrice { get; set; }
        //public int Quantity { get; set; }
        public string Image { get; set; }

    }
}
