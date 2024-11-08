using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFeatureApp
{
    public class MathEngine
    {
        //instance variable
        public readonly double PI;
        public const int num = 98;

        public MathEngine() 
        {
            PI = 3.14;
        } 

        //params keywords can take any no of parameters but the implementation will be single 
        //we did not need to write different functions for different no of parameters
        public static void ViewNames(params string[] names)
        {
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }

        }

        public int Add(int op1,int op2) 
        {
            return op1 + op2;
        }
        public int Add(int op1,int op2,int op3)
        { return op1 + op2+op3;}


        //helper function
        public static void ShowDetails(object o)
        {
            Console.WriteLine(o);
            //it Automatically calls ToString() of dreived class 
        }
    }
}
