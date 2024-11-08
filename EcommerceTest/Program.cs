using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using CRM;
using Catlog;
using OrderProcessing;

namespace EcommerceTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.Id = 1;
            customer1.Fname = "Raj";
            customer1.Lname = "Jadhav";


            Customer customer2 = new Customer();
            customer2.Id = 2;
            customer2.Fname = "shri";
            customer2.Lname = "patil";

            IcustomerService customerService = new CustomerService();
            customerService.insert(customer1);
            customerService.insert(customer2);




            List<Customer> cservice = customerService.GetAll();
            foreach (Customer customer in cservice)
            {
                Console.WriteLine(customer.Fname);
                Console.WriteLine(customer.Lname);

            }

            Console.WriteLine("-------INTO Product Section----- ");


            Product product1 = new Product();
            product1.Id = 1;
            product1.title = "mobile";


            Product product2 = new Product();
            product2.Id = 2;
            product2.title = "charger";

            Iproductservice productService = new ProductService();  
            productService.insert(product1);    
            productService.insert(product2);    

            List<Product> pservice = productService.GetAll();
            foreach(Product product in pservice) 
            {
                Console.WriteLine(product.Id);
                Console.WriteLine(product.title);
                

            }

            Console.WriteLine(" ");
            Console.WriteLine("-------INTO Order Section----- ");

            Order ord1= new Order();
            ord1.id = 1;
            ord1.date = DateTime.Now;



            Order ord2 = new Order();
            ord2.id = 2;
            ord2.date = DateTime.Now;

            Iorderservices orderservice = new Orderservice();
            orderservice.insert(ord1);
            orderservice.insert(ord2);

            List<Order> orders = orderservice.GetAll();
            foreach (Order order in orders)
            {
                Console.WriteLine(order.id);
                Console.WriteLine(order.date);    
            }





            Console.ReadLine(); 




        }
    }
}
