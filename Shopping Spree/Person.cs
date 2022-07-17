using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace P03ShoppingSpree
{
    public class Person
    {
        private const int MinValue = 0;
        private const int minCount = 0;
        private string name;
        private decimal money;
        private List<Product> bagOfProducts;
        public Person(string name, decimal money)
        {
            Name = name;
            Money = money;
            bagOfProducts = new List<Product>();
        }

        public string Name 
        {
            get
            {
                return this.name;
            }

            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Name cannot be empty");
                }
                this.name = value;
            }
        }
        public decimal Money
        {
            get
            {
                return this.money;
            }

            set
            {
                if (value < MinValue)
                {
                    throw new ArgumentException("Money cannot be negative");
                }
                this.money = value;
            }
        }
         public void AddProduct(Product product)
         {
            if (this.money >= product.Cost)
            {
                this.bagOfProducts.Add(product);
                this.money -= product.Cost;
                Console.WriteLine($"{this.Name} bought {product.Name}");
            }
            else
            {
                Console.WriteLine($"{this.Name} can't afford {product.Name}");
            }
         }
        public override string ToString()
        {
            if (bagOfProducts.Count > minCount)
            {
                return $"{this.Name} - {string.Join(", ", bagOfProducts.Select(p => p.Name))}";
            }
            else
            {
                return $"{this.Name} - Nothing bought";
            }
        }

    }
}
