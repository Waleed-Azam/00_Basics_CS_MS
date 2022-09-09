using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Methods_CS_MS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("Here in this code, we going to have a brief introduction to C# Methods");
            Console.WriteLine("_______________________________________________");
            Console.WriteLine("Methods, having a return type, and we need to do some functionality here");
            Console.WriteLine("Press any key to continue....");
            Console.ReadLine();

            Console.WriteLine("Enter your Name");
            string name = Console.ReadLine();
            Console.WriteLine("You entered\t{0}", name);
            Console.ReadLine();

            Console.ReadLine();
            Console.WriteLine("_______________________________________________");
            Console.WriteLine("______________Below are the some WriteLine Commands that can help us in future__________");
            Console.WriteLine("c format: {0:c}", 99999);
            Console.WriteLine("d9 format: {0:d9}", 99999);
            Console.WriteLine("f3 format: {0:f3}", 99999);
            Console.WriteLine("n format: {0:n}", 99999);
            Console.WriteLine("e format: {0:e}", 99999);
            Console.WriteLine("X format: {0:X}", 99999);
            */

            // below are going to be all examples where my goal is to believe in 
            // In all the datatypes. Some of the datatype are not helpful at all
            // but in the end I need to consider all the datatypes..


            /*
            int number;
            double rate;
            string countryName = "Pakistan";
            float cgpa;
            long area = 3.142325677;
            char c = 'A';
            bool flag = true;
            */

            /*

            // Below are some examples for the Ternary Operator
            //int result;
            Console.WriteLine("Enter your result");
            string result = Console.ReadLine();
            Console.WriteLine("Here what you entered:", result);
            //string marks;
            marks = (result > 50) ? "Pass" : "Fail";
            */
            /*
            int value = 10 / 2;
            if(value == 5)
            {
                Console.WriteLine(true);   
                Console.ReadLine();
            }
            // Here is the code the if-else statement and some more information
            // Some of the practical information
           
            Console.WriteLine("Enter the number to check if it is more or less then 50");
            int x = Console.ReadLine();

            if (x > 50)
            {
                Console.Write("pass");
            }
            else
            {
                Console.Write("Fail");
            }
            */
            // Below is the Switch Statement:
            char choice;
            switch(choice)
            {
                case 1:
                    Console.Write("Excellent");
                    break;
                case 2:
                    Console.Write("VeryGood");
                    break;
                    default: Console.Write("Invalid Input");
                    break ;
            }

        }
    }
}
