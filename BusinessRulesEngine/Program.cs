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
                else if (inputValue == 3)       //This will be called when payment is done for New Membership
                {
                    Console.WriteLine("Enter registered EmailID");
                    emailID = Console.ReadLine();
                    new Membership("New Membership", emailID);
                }
                else if (inputValue == 4)       //This will be called when payment is done for Upgrading Membership
                {
                    Console.WriteLine("Enter registered EmailID");
                    emailID = Console.ReadLine();
                    new Membership("Upgrade Membership", emailID);
                }
                else if (inputValue == 5)       //This will be called when payment is done for Video (Learning to Ski)
                    new Video("Video (Learning to Ski)");
                else if (inputValue == 9)       //To exit out of loop and Console Application
                    Environment.Exit(0);
                else
                {
                    Console.WriteLine("Wrong Input...");
                }
            }
        }
    }
}
