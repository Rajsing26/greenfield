using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taxtion
{
    public static class TaxHandler
    {
        public static void PayIncomeTax(float factor)
        {
            //
            Console.WriteLine("Income Tax " + factor + " has been deducted from  u r acc");
        }

        public static void PayServiceTax(float factor)
        {
            //
            Console.WriteLine("Service Tax " + factor + " has been deducted from  u r acc");
        }

        public static void PayProfessionalTax(float factor)
        {
            //
            Console.WriteLine("Professional Tax " + factor + "has been deducted from  u r acc");
        }

        public static void PayGST(float factor)
        {
            //
            Console.WriteLine("GST Tax " + factor + " has been deducted from  u r acc");
        }


    }
}
