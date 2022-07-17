using System.Collections.Generic;
using System;
using System.Text;

namespace P03ShoppingSpree
{
    public class Product
    {
        private const int minNumber = 0;
        private string name;
        private decimal cost;
        public Product(string name, decimal cost)
        {
            this.Name = name;
            this.Cost = cost;
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
                    throw new ArgumentException("name can not be empty or whitespace");
                }
                this.name = value;
            }
        }
        public decimal Cost
        {
            get 
            {
                return this.cost; 
            }
            set
            {
                if (value < minNumber)
                {
                    throw new ArgumentException("cost should be positive number");
                }
                this.cost = value;
            }
        }
    }
}
