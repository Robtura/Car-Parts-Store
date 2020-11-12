using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace New_Car_Parts_Store
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---------------------------------------------------------------");
            Console.WriteLine("Welcome to cars part store!");
            Console.WriteLine("---------------------------------------------------------------");

            Parts part1 = new Parts("a", " Oil filter ", 10, " EUR");
            Parts part2 = new Parts("b", " Air bag ", 123.20, " EUR");
            Parts part3 = new Parts("c", " Battery ", 59.99, " EUR");
            Parts part4 = new Parts("d", " Bumper ", 205, " EUR");
            Parts part5 = new Parts("e", " Air flow metter ", 50, " EUR");

            Console.WriteLine("---------------------------------------------------------------");
            Console.WriteLine("--------To finish your order please type: Done/done------------");
            Console.WriteLine("---------------------------------------------------------------\n");

            // Selection functionality

            List<double> pricelist = new List<double>();
   
            string userinput2 = "";

            do
            {
                Console.WriteLine("Enter car part letter to select it:");
                userinput2 = Console.ReadLine();

                if (userinput2 == part1.identifier || userinput2 == "A")
                {
                    pricelist.Add(part1.price);
                    Console.WriteLine("----" +  part1.name + "Added");
                }
                if (userinput2 == part2.identifier || userinput2 == "B")
                {
                    pricelist.Add(part2.price);
                    Console.WriteLine("----" + part2.name + "Added");
                }
                if (userinput2 == part3.identifier || userinput2 == "C")
                {
                    pricelist.Add(part3.price);
                    Console.WriteLine("----" + part3.name + "Added");
                }
                if (userinput2 == part4.identifier || userinput2 == "D")
                {
                    pricelist.Add(part4.price);
                    Console.WriteLine("----" + part4.name + "Added");
                }
                if (userinput2 == part5.identifier || userinput2 == "E")
                {
                    pricelist.Add(part5.price);
                    Console.WriteLine("----" + part5.name + "Added");
                }
                if (userinput2 == "Done" || userinput2 == "done")
                {
                    Console.WriteLine("---------------------------------------------------------------");
                    Console.WriteLine("Total cost: " + pricelist.Sum());
                }

            } while (userinput2 != "Done" && userinput2 != "done");
            { 
            
            }

            Console.WriteLine("---------------------------------------------------------------");
            Console.WriteLine("---Press any button to close-----------------------------------");
            Console.WriteLine("---------------------------------------------------------------");
            Console.ReadKey();
        }
    }
}
