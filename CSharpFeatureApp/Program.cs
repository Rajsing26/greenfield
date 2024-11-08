using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using CSharpFeatureApp;
using HR;
using Penalty;
using Taxtion;
using Banking;

namespace Banking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Object creation 
            Account acct = new Account(15000);
            //Event Registration 
            acct.underBalance += PenaltyHandler.ServiceDiscontinuePenaltyCharges;
            acct.underBalance += PenaltyHandler.NotificationPenaltyCharges;
            //Object Invovation 
            acct.Withdraw(8000);


           
            acct.overBalance += TaxHandler.PayIncomeTax;
            acct.overBalance += TaxHandler.PayServiceTax;
            acct.Deposit(500000);





            Console.ReadLine();
        }
    }
}

/*
 
 MathEngine engine = new MathEngine();
            engine.Add(76, 89);
            engine.Add(76, 89, 87);

            MathEngine.ViewNames("Sarika", "Manoj", "Charan", "Chetan");
            MathEngine.ViewNames("Raj", "Amita", "Shishir");
            MathEngine.ViewNames("Sameer", "Sagar");


            //  MathEngine.ShowDetails(56);
            // MathEngine.ShowDetails("Ravi Tambade");
            //  MathEngine.ShowDetails(76.8);
            Person person = new Person();
            MathEngine.ShowDetails(person);
            Complex complex = new Complex();//early binding
            Complex c1 = new Complex(22, 33); // early binding
            Complex c2 = new Complex(11, 11);

            Complex c3 = c1 + c2;  //
            Console.WriteLine(c3);  //ToString () method 
                                    //C3 type is complex
                                    //Complex class inherited
                                    // Parent of Complext is Object
                                    //Complex has implementation ToString
                                    //Object also has implementation of ToString

            Employee emp = new Employee { Id = 12, Name = "Raj", BasicSalary = 5000, DA = 500, HRA = 20000 };
            double packageEmp = emp.ComputePay();
            Console.WriteLine(packageEmp);

            emp = new Manager { Id = 13, Name = "Manish", BasicSalary = 5000, DA = 500, HRA = 20000, Incentive = 45000 };
            double packageMgr = emp.ComputePay();
            Console.WriteLine(packageMgr);
 ========================================================================================================================================

//Compile time static linking
            /*Handler.PayGST();
            Handler.PayIncomeTax(); 
            Handler.PayServiceTax();*/

/*Operation opn1 = new Operation(Handler.PayIncomeTax);
Operation opn2 = new Operation(Handler.PayServiceTax);
Operation opn3 = new Operation(Handler.PayProfessionalTax);//u can create obj from delegate like class

Operation masteroperation = null;
masteroperation += opn1;
masteroperation += opn2;
masteroperation += opn3;

//opn1.Invoke(30);
masteroperation.Invoke(56);
Console.WriteLine(" ");

//after detachment
masteroperation += opn3;
Console.WriteLine("After detactment");
Console.WriteLine(" ");

masteroperation.Invoke(56);
*/