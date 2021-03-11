using System;

namespace SweetSpicy
{
    class Program
    {
        static void Main(string[] args)
        {
            var sweetCount = 0;
            var saltyCount = 0;
            var sweetNSaltyCount = 0;

            // For loop that counts to 1000
            for (int i = 1; i <= 1000; i++)
            {
                if (i % 3 == 0 && i % 5 == 0) // For numbers which are multiples of three and five, print “sweet’nSalty” to the console (instead of the number).  
                {
                    Console.Write("Sweet'N'Salty ");
                    sweetNSaltyCount += 1; //counts sweet'n'salty
                }
                else if (i % 3 == 0) // When the number is multiple of three, print “sweet” instead of the number on the console.  
                {
                    Console.Write("Sweet ");
                    sweetCount += 1; //counts sweet
                }
                else if (i % 5 == 0) // If the number is a multiple of five, print “salty” (instead of the number) to the console.  
                {
                    Console.Write("Salty ");
                    saltyCount += 1; //counts salty

                    if (i % 10 == 0)
                    {
                        Console.WriteLine(); // After every 10 numbers start a new line of numbers
                    }
                }
                else
                {
                    Console.Write(i + " ");
                }
            }

            //Shows the amount of times each word was counted
            Console.WriteLine("\n\nSweet Count: " + sweetCount);
            Console.WriteLine("Salty Count: " + saltyCount);
            Console.WriteLine("Sweet'N'Salty Count: " + sweetNSaltyCount);
        }
    }
}
