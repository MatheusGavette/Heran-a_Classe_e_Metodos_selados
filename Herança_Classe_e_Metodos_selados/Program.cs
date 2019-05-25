using Herança_Classe_e_Metodos_selados.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace Herança_Classe_e_Metodos_selados
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Entre com o número de produtos: ");
            int n = int.Parse(Console.ReadLine());
            List<Product> items = new List<Product>();

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("--------------");
                Console.Write("Commom, used or imported : ");
                string opc = Console.ReadLine().ToUpper();

                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (opc == "USED")
                {
                    Console.Write("Manufacture Date (DD/MM/YYYY: ");
                    DateTime date = DateTime.Parse(Console.ReadLine());
                    UsedProduct prod = new UsedProduct(name, price, date);
                    items.Add(prod);
                }
                else if (opc == "IMPORTED")
                {
                    Console.Write("Custom Fee: ");
                    double customFee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    ImportedProduct prod = new ImportedProduct(name, price, customFee);
                    items.Add(prod);
                }
                else
                {
                    Product prod = new Product(name, price);
                    items.Add(prod);
                }
            }

            Console.WriteLine("Price Tags: \n");

            foreach (var p in items)
            {
                Console.WriteLine(p);
            }
        }
    }
}
