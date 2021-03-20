using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Search_240221
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>();
            Random rnd = new Random();

            for (int i = 0; i < 5; i++)
            {
                Product product = new Product();
                product.Brand = string.Format("Brand_{0}", rnd.Next(1, 10));
                product.Name = string.Format("Name_{0}", rnd.Next(1, 10));
                product.PartNumber = rnd.Next(0, 9) * 1000;
                products.Add(product);
            }

            Search(products);
        }

        public static void Search(List<Product> products)
        {

            Console.Clear();
            Console.ResetColor();
            bool isFind = false;

            foreach (Product product in products)
            {
                product.ShowInfo();
            }
            Console.WriteLine("------------------------------");
            Console.WriteLine();

            Console.WriteLine("Что вы хотите сделать?");
            Console.WriteLine("1. Найти по номеру ");
            Console.WriteLine("2. Найти по бренду ");
            Console.WriteLine("3. Найти по названию ");
            Console.WriteLine("4. Вывести все имеющиеся товары ");

            int choose = int.Parse(Console.ReadLine());



            Console.ResetColor();



            switch (choose)
            {
                case 1:
                    {
                        int number = int.Parse(Console.ReadLine());
                        foreach (Product product in products)
                        {

                            if (product.PartNumber == number)
                            {
                                Console.WriteLine();
                                isFind = true;
                                Console.WriteLine("У нас есть такая запчасть!");
                                product.ShowInfo();
                                Console.WriteLine();
                            }

                        }
                        if (!isFind)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Нам не удалось найти подобную запчасть");
                        }
                        Console.ReadLine();
                    }
                    break;
                case 2:
                    {
                        string brand = Console.ReadLine();
                        foreach (Product product in products)
                        {
                            if (product.Brand == brand)
                            {
                                Console.WriteLine();
                                isFind = true;
                                Console.WriteLine("У нас есть такой бренд!");
                                product.ShowInfo();
                                Console.WriteLine();

                            }


                        }
                        if (!isFind)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Нам не удалось найти подобный бренд");
                        }
                        Console.ReadLine();

                    }
                    break;
                case 3:
                    {
                        string name = Console.ReadLine();
                        foreach (Product product in products)
                        {
                            if (product.Name == name)
                            {
                                Console.WriteLine();
                                isFind = true;
                                Console.WriteLine("У нас есть такой товар!");
                                product.ShowInfo();
                                Console.WriteLine();
                            }

                        }
                        if (!isFind)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Нам не удалось найти подобный товар");
                        }
                        Console.ReadLine();
                    }
                    break;
                case 4:
                    {
                        foreach (Product product in products)
                        {
                            isFind = true;
                            product.ShowInfo();
                        }
                        Console.WriteLine("------------------------------");
                        Console.ReadLine();
                    }
                    break;
            }
        }
    }
}


