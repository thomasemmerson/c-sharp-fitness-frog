using System;

namespace Treehouse.CodeChallenges
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter the number of times to print \"Yay!\": ");
            try {
                int num = Convert.ToInt32(Console.ReadLine()); //potential format exception occurs here
                if (num < 0) {
                    Console.WriteLine("You must enter a positive number.");
                }
                else {
                    while (num > 0) {
                        Console.WriteLine("Yay!");
                        num--;
                    }
                }
            }
            catch (FormatException num) {
                Console.WriteLine("You must enter a whole number."); // catches earlier format exception error
            }
        }
    }
}