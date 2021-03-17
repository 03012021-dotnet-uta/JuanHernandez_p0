using System;
using System.Collections.Generic;
using PizzaBox.Domain.Abstracts;
using PizzaBox.Domain.Models;
using PizzaBox.Domain.Singletons;



namespace PizzaBox.Client
{

    class Program
    {
        static void Main(string[] args)
        {
            AsACustomer();
        }

        public static void AsACustomer()
        {

            APizza pizzaType = null;
            AStore storeType = null;

            var stpProgram = false;
            var ss = StoreSingleton.Instance;

            ss.Seeding();

            Console.Clear();

            do
            {
                // print all the stores available, must be from file or db

                Console.WriteLine("\nSelect a store\n");
                int count = 1;

                foreach (var item in ss.Stores)
                {
                    Console.Write("{0}. ", count); // Labels the stores 1-3 //form the xml file
                    Console.WriteLine(item);
                    count++;
                }

                Console.Write("Choice: ");
                // select a store
                var input = Console.ReadLine();

                Console.Clear();
                switch (input)
                {
                    case "1":

                        stpProgram = true;
                        // run the code for store1
                        storeType = new ChicagoStore();

                        //take customer name
                        Customer cust = new Customer();
                        Console.Write("Enter your name: ");
                        cust.CustomerName = Console.ReadLine();
                        Console.Clear();

                        // print the customer menu
                        System.Console.WriteLine("1. Place Order");
                        System.Console.WriteLine("2. View Orders History");
                        System.Console.WriteLine("3. Exit");

                        Console.Write("Choice: ");
                        // select a menu option
                        var input2 = Console.ReadLine();
                        Console.Clear();
                        switch (input2)
                        {
                            case "1":
                                // run the code dor placing order
                                Console.Write("What type of Pizza would you like?\n");
                                ss.SeedingPizza();
                                //Print all pizzas 
                                int count2 = 1;
                                var stPizza = ss.storePizza;
                                foreach (var item in stPizza)
                                {
                                    Console.Write("{0}. ", count2);
                                    Console.WriteLine(item.GetType().ToString().Split(".")[3]);
                                    count2++;
                                }
                                Console.WriteLine("4. Custom Pizza");
                                Console.Write("Choice: ");
                                var choice = Console.ReadLine();

                                Console.Clear();
                                switch (choice)
                                {
                                    case "1":
                                        Console.WriteLine("What size of Crust would you like?\n");
                                        Console.WriteLine("1. Small");
                                        Console.WriteLine("2. Medium");
                                        Console.WriteLine("3. Large");
                                        Console.Write("Choice: ");
                                        var choice2 = Console.ReadLine();

                                        switch (choice2)
                                        {
                                            case "1":
                                                Size smallSize = new Size("Small");
                                                pizzaType = new MeatPizza(smallSize);
                                                break;

                                            case "2":
                                                Size mediumSize = new Size("Medium");
                                                pizzaType = new MeatPizza(mediumSize);
                                                break;

                                            case "3":
                                                Size largeSize = new Size("Large");
                                                pizzaType = new MeatPizza(largeSize);
                                                break;

                                            default:
                                                Console.WriteLine("Incorrect Input");
                                                break;
                                        }
                                        Console.Clear();
                                        //saves order
                                        Order orderInstance = new Order();  //new order
                                        orderInstance.orderPizzas = new List<APizza>(); //initialize out list
                                        orderInstance.orderCustomer = cust; //assigning cust to our new order
                                        orderInstance.orderStore = storeType; //assiging storeType to our store we chose

                                        //add pizzatype to our list
                                        orderInstance.orderPizzas.Add(pizzaType);
                                        ss.saveOrder(new List<Order>() { orderInstance }); //saves orderInstance to xml from list
                                        stpProgram = false;
                                        break;
                                    default:
                                        break;
                                }
                                break;
                            case "2":
                                stpProgram = false;
                                // run the code for view order history
                                var stOrder = ss.storeOrder;
                                foreach (var item in stOrder)
                                {
                                    Console.WriteLine(item.GetType().ToString().Split(".")[3]);
                                }
                                ss.readOrder(stOrder);
                                break;

                            case "3":
                                stpProgram = true;
                                return;

                            default:
                                stpProgram = false;
                                Console.Clear();
                                Console.WriteLine("Incorrect Input");
                                break;
                        }
                        break;

                    case "2": // run the code for store2
                        stpProgram = false;
                        break;

                    case "3": // run the code for store2
                        stpProgram = false;
                        break;
                    default:
                        stpProgram = false;
                        Console.Clear();
                        Console.WriteLine("Incorrect Input");
                        break;
                }
            }
            while (!stpProgram);

            Console.Clear();
        }

    }
}
