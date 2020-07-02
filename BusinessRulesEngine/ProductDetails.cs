using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessRulesEngine
{
    public class ProductDetails
    {
        public int GetInputValueFromCustomer()
        {
            Console.WriteLine("\n------Business Rule Engine----------\n");
            Console.WriteLine("Enter 1 for Physical Product");
            Console.WriteLine("Enter 2 for Book");
            Console.WriteLine("Enter 3 for New Membership");
            Console.WriteLine("Enter 4 for Upgrading Membership");
            Console.WriteLine("Enter 5 for Video(Learning to Ski)");
            Console.WriteLine("Enter 9 to exit\n");


            return InputUserValue(int.Parse(Console.ReadLine()));
        }

        public int InputUserValue(int inputValue)
        {
            return inputValue;
        }
    }
}
