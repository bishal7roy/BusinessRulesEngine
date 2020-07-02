using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessRulesEngine
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductDetails productDetails = new ProductDetails();
            string emailID = "";

            while (true)
            {
                int inputValue = productDetails.GetInputValueFromCustomer();

                if (inputValue == 1)            //This will be called when payment is done for Physical Product
                    new PhysicalProduct();
                else if (inputValue == 2)       //This will be called when payment is done for Book
                    new Book();

                else
                {
                    Console.WriteLine("Wrong Input...");
                }
            }
        }
    }
}
