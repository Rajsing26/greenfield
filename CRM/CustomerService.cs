using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM
{
    public class CustomerService : IcustomerService
    {
        private List<Customer> _customerList;

        public CustomerService() 
        {
            _customerList = new List<Customer>();   
        }
        public bool delete(int id)
        {
            Customer thecustomer = this.Get(id);
            return _customerList.Remove(thecustomer);
        }

        public List<Customer> GetAll()
        {
            return _customerList;
        }

        public Customer Get(int id)
        {
            foreach (Customer customer in _customerList) 
            { 
                if(customer.Id == id) return customer;
            }
            return null;
        }

        public bool insert(Customer customer)
        {
            this._customerList.Add(customer);
            return true;    
        }

        public bool update(Customer customer)
        {
           Customer thecustomer = this.Get(customer.Id);    
            customer.Fname = thecustomer.Fname;
            customer.Lname = thecustomer.Lname;
            customer.Email = thecustomer.Email;
            return true;
        }
    }
}
