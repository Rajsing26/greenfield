using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderProcessing
{
    public class Orderservice : Iorderservices
    {
        List<Order> _orderlist;

        public Orderservice() 
        {
            _orderlist = new List<Order>();
        }
        public bool delete(int id)
        {
           Order theorder = this.Get(id);
            return _orderlist.Remove(theorder); 
        }

        public Order Get(int id)
        {
            foreach (Order theorder in _orderlist) 
            {
                if(theorder.id == id) return theorder;

            }
            return null;
        }

        public List<Order> GetAll()
        {
            return _orderlist;  
        }

        public bool insert(Order order)
        {
            _orderlist.Add(order);  
            return true;    
        }

        public bool update(Order order)
        {
            Order theorder =this.Get(order.id);
            order.amount = theorder.amount;
            order.id = theorder.id; 
            order.date = theorder.date; 
            order.status = theorder.status; 
            return true;    
        }
    }
}
