using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM
{
    public class Customer
    {
        public int Id { get; set; }
        public string Fname { get; set; } //auto property
        public string Lname { get; set; }
        public string Email { get; set; }
    }
}
