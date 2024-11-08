using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderProcessing
{
    public class Order
    {
        public int id {  get; set; }    
        public DateTime date { get; set; }    

        public int amount { get; set; }   
        
        public string status { get; set; }  
    }
}
