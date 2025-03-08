using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    public class Product {
        public string Name { get; set; }
        double Price { get; set; }
        int Quantity { get; set; }

        public Product(string name, double price, int quantity)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
        }

        public double TotalPrice() {
            double result = Price * Quantity;
            if (Quantity > 5) {
                result -= result * 0.1;
            }

            return result;


        }
    }


    internal class Program
    {
            static void Main(string[] args)
            {
                Product pr1 = new Product("Apple", 2, 10);
                Product pr2 = new Product("Notebook", 100, 2);
                Product pr3 = new Product("T-Shirt", 15, 6);
            
            Console.WriteLine($"{pr1.Name}: {pr1.TotalPrice()}$");
            Console.WriteLine($"{pr2.Name}: {pr2.TotalPrice()}$");
            Console.WriteLine($"{pr3.Name}: {pr3.TotalPrice()}$");

            Console.ReadLine();
            }
        }
    }

