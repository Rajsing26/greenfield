using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catlog
{
    public class ProductService : Iproductservice
    {
        List<Product> _productslist;
        public ProductService()
        {
            _productslist = new List<Product>();
        }

        public bool delete(int id)
        {
            Product theproduct = this.Getid(id);
            return _productslist.Remove(theproduct);    

        }

        public List<Product> GetAll()
        {
            List<Product> products = new List<Product>();
            products.Add(new Product { Id = 1, Name = "Garbera", Description = "Wedding Floer", UnitPrice = 12, Quantity = 200, Image = "/Images/gerbera.jfif" });
            products.Add(new Product { Id = 2, Name = "Rose", Description = "fragrant Floer", UnitPrice = 22, Quantity = 500, Image = "/Images/gerbera.jfif" });
            products.Add(new Product { Id = 3, Name = "Garbera", Description = "Wedding Floer", UnitPrice = 12, Quantity = 200, Image = "/Images/gerbera.jfif" });
            products.Add(new Product { Id = 4, Name = "Garbera", Description = "Wedding Floer", UnitPrice = 12, Quantity = 200, Image = "/Images/gerbera.jfif" });
            return products;    
        }

        public Product Getid(int id)
        {
            foreach (Product product in _productslist) 
            {
                if(product.Id==id) return product;
            }
            return null;    
        }

        public bool insert(Product product)
        {
            _productslist.Add(product);
            return true;
        }

        public bool update(Product product)
        {
            Product theproduct=this.Getid(product.Id);
            theproduct.Id = product.Id; 
            theproduct.title= product.title;
            theproduct.Description= product.Description;
            theproduct.Unitp=product.Unitp;
            return true;
            
        }
    }
}
