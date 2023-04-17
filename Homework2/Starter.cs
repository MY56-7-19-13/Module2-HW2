using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2
{
    public class Starter
    {
        public void Run()
        {
            Positions cart = new Positions();
            List<Product> getProducts = cart.GetProduct();
            List<Product> addProductToOrder = new List<Product>();
            User[] user =
           {
                new User(32156, "Tom Holland", 400),
                new User(6575, "Jack Sparrow", 320),
                new User(10283, "Milania Tramp", 584),
           };

            for (int i = 0; i < user.Length; i++)
            {
                Console.WriteLine(new string('-', 20));
                user[i].ShowUsers();
            }

            Console.Write("Choose user: ");
            int choose = Convert.ToInt32(Console.ReadLine());
            if (choose == 1 || choose == 2 || choose == 3)
            {
                bool isRunning = true;
                Console.Clear();
                User firstUser = user[choose - 1];
                firstUser.ShowUsers();
                Console.Write("For next press (y): ");
                string? pressNext = Console.ReadLine();
                if (pressNext == "y")
                {
                    while (isRunning)
                    {
                        Console.Clear();
                        firstUser.ShowUsers();
                        Console.WriteLine();
                        Console.WriteLine("Menu:");
                        Console.WriteLine("-----");
                        Console.WriteLine("1. Show products");
                        Console.WriteLine("2. Checkout order");
                        Console.WriteLine("3. Contact us");
                        Console.WriteLine("4. Exit");
                        Console.Write("Enter your choice (1-4): ");
                        string? input = Console.ReadLine();
                        switch (input)
                        {
                            case "1":
                                Console.Clear();
                                Console.WriteLine("Full list of products:");
                                Console.WriteLine(new string('-', 30));
                                for (int i = 0; i < getProducts.Count; i++)
                                {
                                    Console.WriteLine($"Title: {getProducts[i].NameProduct} | Price: {getProducts[i].PriceOfProduct} USD");
                                }

                                Console.WriteLine(new string('-', 30));

                                Console.Write("\nWhat product to add: ");
                                int takeProduct = Convert.ToInt32(Console.ReadLine());
                                if (takeProduct == 1 || takeProduct == 2 || takeProduct == 3 || takeProduct == 4
                                    || takeProduct == 5 || takeProduct == 6)
                                {
                                    addProductToOrder.Add(getProducts[takeProduct - 1]);
                                    Console.WriteLine("Successfully add!");
                                    Console.Write("Press enter for continue... ");
                                    Console.ReadLine();
                                }

                                break;
                            case "2":
                                Console.Clear();
                                var sumOfOrder = 0;
                                Order order = new Order(addProductToOrder);
                                Console.WriteLine("| Order is ready |");
                                Console.WriteLine(new string('-', 20));
                                Console.WriteLine($"Order ID: {order.OrderId}");
                                Console.WriteLine(new string('-', 20));
                                Console.WriteLine($"Order placed on {firstUser.UserFullName}");
                                Console.WriteLine(new string('-', 20));
                                Console.WriteLine("Shopping list:");
                                for (int i = 0; i < addProductToOrder.Count; i++)
                                {
                                    Console.Write(i + 1 + ". ");
                                    Console.WriteLine($"{addProductToOrder[i].NameProduct} ({addProductToOrder[i].PriceOfProduct} USD)");
                                }

                                for (int i = 0; i < addProductToOrder.Count; i++)
                                {
                                    sumOfOrder += addProductToOrder[i].PriceOfProduct;
                                }

                                Console.WriteLine(new string('-', 20));
                                Console.Write($"To pay: {sumOfOrder} USD\n");
                                Console.WriteLine(new string('-', 20));
                                Console.Write("Press enter for continue... ");
                                Console.ReadLine();
                                break;
                            case "3":
                                Console.Clear();
                                ContactUs contactUs = new ContactUs();
                                contactUs.ShowContact();
                                Console.Write("Press enter for continue... ");
                                Console.ReadLine();
                                break;
                            case "4":
                                isRunning = false;
                                break;
                            default:
                                Console.Clear();
                                Console.WriteLine("We don`t have this option!\nTry again!");
                                Console.ReadKey();
                                break;
                        }
                    }
                }
            }
        }
    }
}
