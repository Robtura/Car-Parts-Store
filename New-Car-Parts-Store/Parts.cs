using System;
using System.Collections.Generic;
using System.Text;

namespace New_Car_Parts_Store
{
    class Parts
    {
        public string name;
        public double price;
        public string currency;
        public string identifier;

        // Constructor 

        public Parts(string aIdentifier, string aName, double aPrice, string aCurrency)
        {
            name = aName;
            price = aPrice;
            currency = aCurrency;
            identifier = aIdentifier;

            // Displaying the list
            Console.WriteLine(aIdentifier + aName + aPrice + aCurrency);
        }

    }
}

