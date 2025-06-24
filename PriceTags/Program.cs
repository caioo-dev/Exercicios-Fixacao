using PriceTags.Entities;
using System.Globalization;

namespace PriceTags
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>();

            Console.Write("Enter the number of products: ");
            int N = int.Parse(Console.ReadLine());

            for (int i = 1; i <= N; i++)
            {
                Console.WriteLine($"Product {i} data:");
                Console.Write("Common, used or imported (c/u/i)? ");
                char question = char.Parse(Console.ReadLine());

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (question == 'c' || question == 'C')
                {
                    products.Add(new Product(name, price));
                    continue;
                }

                if (question == 'i' || question == 'I')
                {
                    Console.Write("Custom fee: ");
                    double customFee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    products.Add(new ImportedProduct(name, price, customFee));

                    continue;
                }

                Console.Write("Manufacture date (DD/MM/YYYY): ");
                DateTime manufactureDate = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);

                products.Add(new UsedProduct(name, price, manufactureDate));
            }

            Console.WriteLine("PRICE TAGS: ");
            foreach(Product p in products)
            {
                Console.WriteLine(p.PriceTag());
            }
        }
    }
}
