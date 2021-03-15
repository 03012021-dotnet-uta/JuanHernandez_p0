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
            // AsACustomer();
            MeatPizza meatPizza = new MeatPizza();
            meatPizza.Crust.Name = "Hand Tossed";
            Topping top = new Topping();
            top.Name = "Mushrooms";
            meatPizza.Toppings.Add(top);
            meatPizza.Size.Name = "Large";

            Console.WriteLine("Pizza Type: " + meatPizza.Name);
            Console.WriteLine("Crust Type: " + meatPizza.Crust.Name);
            Console.WriteLine("Pizza Size: " + meatPizza.Size.Name);
            meatPizza.ShowToppings(meatPizza);
        }

        // public static void AsACustomer()
        // {
        //     var stpProgram = false;
        //     var ss = StoreSingleton.Instance;

        //     ss.Seeding();

        //     Console.Clear();

        //     do
        //     {
        //         // print all the stores available, must be from file or db

        //         Console.WriteLine("\nSelect a store\n");
        //         int count = 1;
        //         foreach (var item in ss.Stores)
        //         {
        //             Console.Write("{0}. ", count);
        //             Console.WriteLine(item);
        //             count++;
        //         }

        //         Console.Write("Choice: ");
        //         // select a store
        //         var input = Console.ReadLine();
        //         var input2 = "";

        //         switch (input)
        //         {
        //             case "1":
        //                 // run the code for store1
        //                 stpProgram = true;
        //                 StoreChoice(input2, stpProgram);
        //                 break;
        //             case "2":
        //                 // run the code for store2
        //                 stpProgram = true;
        //                 StoreChoice(input2, stpProgram);
        //                 break;

        //             case "3":
        //                 // run the code for store2
        //                 stpProgram = true;
        //                 StoreChoice(input2, stpProgram);
        //                 break;
        //             default:
        //                 stpProgram = false;
        //                 Console.Clear();
        //                 Console.WriteLine("Incorrect Input");
        //                 break;
        //         }
        //     } while (!stpProgram);

        //     Console.Clear();
        // }

        // public static void StoreChoice(string input, bool stpProgram)
        // {
        //     do
        //     {
        //         // print the customer menu
        //         System.Console.WriteLine("\n1. Place Order");
        //         System.Console.WriteLine("2. View Order History");
        //         System.Console.WriteLine("3. Exit");

        //         Console.Write("Choice: ");
        //         // select a menu option
        //         input = Console.ReadLine();

        //         switch (input)
        //         {
        //             case "1":
        //                 stpProgram = true;
        //                 // run the code dor placing order
        //                 Console.WriteLine("\nWhat type of Pizza would you like?");
        //                 Console.WriteLine("\n1. Meat Pizza");
        //                 Console.Write("Choice: ");
        //                 var choice = Console.ReadLine();

        //                 switch (choice)
        //                 {
        //                     case "1":
        //                         MeatPizza meatPizza = new MeatPizza();
        //                         meatPizza.Crust.Name = "";
        //                         Topping top = new Topping();
        //                         top.Name = ""
        //                         meatPizza.Toppings.Add();
        //                         break;
        //                     default:

        //                         break;
        //                 }
        //                 break;
        //             case "2":
        //                 stpProgram = true;
        //                 // run the code for view order history
        //                 break;

        //             case "3":
        //                 stpProgram = true;
        //                 return;

        //             default:
        //                 stpProgram = false;
        //                 Console.Clear();
        //                 Console.WriteLine("Incorrect Input");
        //                 break;
        //         }
        //     } while (!stpProgram);
        // }
    }
}
