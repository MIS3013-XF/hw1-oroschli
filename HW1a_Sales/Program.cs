// HW1a Sales Total

// Your Name: Olivia Roschli
// Did you seek help ? If yes, specify the helper or web link here: No

using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace HW1a_Sales
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string prodname;
            double quantity;
            double price;
            double sub;
            double tax;
            const double taxamt = 0.085;
            double total;

            string quantityAsString;
            string priceAsString;

            Console.WriteLine("What is the product name of the item you are purchasing?");
            prodname = Console.ReadLine();
            Console.WriteLine($"How many {prodname}'s do you want to buy?");
            quantityAsString = Console.ReadLine();
            Console.WriteLine($"What is the price for each {prodname}?");
            priceAsString = Console.ReadLine();

            quantity = Convert.ToDouble(quantityAsString);
            price = Convert.ToDouble(priceAsString);

            sub = quantity * price;
            Console.WriteLine("Your subtotal for your bill is $" + sub.ToString("N2") + ".");

            tax = taxamt * sub;
            Console.WriteLine("Your sales tax for your bill is $" + tax.ToString("N2") + ".");

            total = tax + sub;
            Console.WriteLine("Your total for your bill is $" + total.ToString("N2") + ".");

            Console.ReadKey();





        }
    }
}
