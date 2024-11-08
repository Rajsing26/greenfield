using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POCO;
using Specification;
using BinaryDataRepositoryLib;

namespace Catlog
{
    public class ProductService : Iproductservice
    {
        //sampling data for services
        public bool Seeding()
        {
            bool status = false;
            List<Product> products = new List<Product>();
            products.Add(new Product { Id = 1, Title = "Jasmine", Description = "Fragnance", UnitPrice = 32, Quantity = 30, Image = "/images/Jasmine.jpg" });
            products.Add(new Product { Id = 2, Title = "Rose", Description = "Love", UnitPrice = 12, Quantity = 80, Image = "/images/Rose.jpg" });
            products.Add(new Product { Id = 4, Title = "Lotus", Description = "Worship", UnitPrice = 40, Quantity = 70, Image = "/images/Lotus.jpg" });
            products.Add(new Product { Id = 1, Title = "Lily", Description = "Beautiful", UnitPrice = 20, Quantity = 100, Image = "/images/Lily.jpg" });
            
            IDataRepository repo = new BinaryRepository();
            repo.Serialize("products.dat", products);

            return status;
        }


        List<Product> _productslist;
        public ProductService()
        {
            _productslist = new List<Product>();
        }

        public bool delete(int id)
        {
            Product theproduct = this.Getid(id);
            if(theproduct != null)
            {
                List<Product> allproducts = GetAll();
                allproducts.Remove(theproduct);
                IDataRepository repo = new BinaryRepository();
                repo.Serialize("product.dat", allproducts);
            }

            return _productslist.Remove(theproduct);    

        }

        public List<Product> GetAll()
        {
            List<Product> products = new List<Product>();
            //Call logic of BinaryREpo

            IDataRepository repository = new BinaryRepository();
            products = repository.Deserialize("Products.dat");

            return products;    
        }

        public Product Getid(int id)
        {
            Product foundproduct = null;
            List<Product>products = GetAll();
            foreach (Product p in products) 
            {
                if (p.Id == id)
                {
                    foundproduct = p;   
                }
            }
            return null;    
        }

        public bool insert(Product product)
        {
           
            return true;
        }

        public bool update(Product product)
        {
            Product theproduct=this.Getid(product.Id);
            theproduct.Id = product.Id; 
            theproduct.Title= product.Title;
            theproduct.Description= product.Description;
            theproduct.UnitPrice = product.UnitPrice;
            return true;
            
        }
    }
}
