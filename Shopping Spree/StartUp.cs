using System;
using System.Collections.Generic;

namespace P03ShoppingSpree
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<Person> personList = new List<Person>();
            string [] names = Console.ReadLine().Split(';',StringSplitOptions.RemoveEmptyEntries);
            try
            {
                foreach (var person in names)
                {
                   string [] personAndMoney= person.Split('=');
                    Person genericPerson = new Person(personAndMoney[0], decimal.Parse(personAndMoney[1]));
                    personList.Add(genericPerson);
                }
             List<Product> productsToBuy = new List<Product>();
             string[] Startingproducts = Console.ReadLine().Split(';',StringSplitOptions.RemoveEmptyEntries);
                foreach (var p in Startingproducts)
                {
                    string[] quantityOfProducts = p.Split('=');
                    Product product = new Product(quantityOfProducts[0], decimal.Parse(quantityOfProducts[1]));
                    productsToBuy.Add(product);
                }
                string input = Console.ReadLine();
                while (input != "END")
                {
                   string[] strings =input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                    Person person = personList.Find(p => p.Name == strings[0]);
                    Product productsToAddToPerson = productsToBuy.Find(p => p.Name == strings[1]);
                    person.AddProduct(productsToAddToPerson);

                    input = Console.ReadLine();
                }
                foreach (var person in personList)
                {
                    Console.WriteLine(person);
                }
            }
            catch (ArgumentException ex)
            {

                Console.WriteLine(ex.Message);
            }
        }
    }
}
