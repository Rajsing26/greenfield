using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderProcessing
{
    public interface Iorderservices
    {
        List<Order> GetAll(); 
        
        Order Get(int id);  

        bool insert(Order order);   
        bool update(Order order);   
        bool delete(int id);   
    }
}
