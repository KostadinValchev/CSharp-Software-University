namespace Shopping_Spree
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var people = new List<Person>();
            var products = new List<Product>();

            var allPeople = Console.ReadLine().Split(new[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
            var allProducts = Console.ReadLine().Split(new[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
            try
            {

                foreach (var pair in allPeople)
                {
                    var personInfo = pair.Split('=');
                    var person = new Person(personInfo[0], decimal.Parse(personInfo[1]));
                    people.Add(person);
                }

                foreach (var pair in allProducts)
                {
                    var productInfo = pair.Split('=');
                    var productPrice = decimal.Parse(productInfo[1]);
                    var product = new Product(productInfo[0], productPrice);
                    products.Add(product);
                }

                string purchase;
                while ((purchase = Console.ReadLine()) != "END")
                {
                    var purchaseInfo = purchase.Split(' ');
                    var buyerName = purchaseInfo[0];
                    var productName = purchaseInfo[1];

                    var buyer = people.FirstOrDefault(b => b.Name == buyerName);
                    var boughtProdict = products.FirstOrDefault(bp => bp.Name == productName);

                    try
                    {
                        buyer.BuyProduct(boughtProdict);
                        Console.WriteLine($"{buyerName} bought {productName}");
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }
                }
                foreach (var person in people)
                {
                    var boughtProducts = person.GetProducts();
                    var result = boughtProducts.Any() ? string.Join(", ", boughtProducts.Select(pr => pr.Name)) : "Nothing bought";
                    Console.WriteLine($"{person.Name} - {result}");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
