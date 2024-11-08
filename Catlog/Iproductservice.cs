using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catlog
{
    public interface Iproductservice
    {
        List<Product> GetAll();
        Product Getid(int id);

        bool insert(Product product);
        bool update(Product product);
        bool delete(int  id);   

    }
}
