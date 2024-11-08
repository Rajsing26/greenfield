using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Specification;
using POCO;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace BinaryDataRepositoryLib
{
    public class BinaryRepository : IDataRepository
    {
       public bool Serialize(string filename, List<Product> products)
        {
            bool status = false;
            //code for saving
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(filename, FileMode.OpenOrCreate);
            formatter.Serialize(stream, products);
            stream.Close(); 

            return status;  
        }
        public List<Product> Deserialize(string filename)
        {
            List<Product> products = new List<Product>();
            //Retrive all data from
            FileStream stream = new FileStream(filename, FileMode.Open);
            BinaryFormatter formatter = new BinaryFormatter();  
            if(stream != null ) 
            {
                products = (List<Product>)formatter.Deserialize(stream);
            }
            stream.Close();
            return products;


            //return products;
        }
    }
}
