using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Deligation;

namespace Banking
{
    public class Account
    {
        public event Operation underBalance;
        public event Operation overBalance;
        public double balance {  get; set; }
        
        public Account(double initialbalance)
        {
            balance = initialbalance;   
        }
        public void Withdraw(double amount) 
        {
            double result = balance-amount; 
            if(result<=10000)
            {

                //Raise an event under balance
                underBalance(5);
            }
            balance -= result;   
        
        }    
        public void Deposit(double amount)
        {
            balance += amount;
            if(balance>=250000)
            {
                overBalance(10);
                //Raise an event : OverBalance
            }
        }  
    }
}
