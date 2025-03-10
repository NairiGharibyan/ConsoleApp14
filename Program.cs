using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    public class Product {
        public string Name { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }

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
            List<Product> cart = new List<Product>();
            cart.Add(new Product("Apple", 2, 10));
            cart.Add(new Product("Notebook", 100, 2));
            cart.Add(new Product("T-Shirt", 15, 6));

            double total_cost = 0;

            foreach (Product product in cart)
            {
                double productTotal = product.TotalPrice();
                total_cost += productTotal;
                Console.WriteLine($"{product.Name}: {productTotal}$");
           
            }

            Console.WriteLine("Total Cost: " + total_cost + "$");
            Console.ReadLine();

              
            }
        }
    }

