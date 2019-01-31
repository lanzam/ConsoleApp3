using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome! Please enter your name...");
            
            try
            {
                string input;
                input = Console.ReadLine();
                Console.WriteLine("Hello " + input);
                Console.ReadKey(true);


            }
            catch
            {
                Console.WriteLine("Please enter valid characters...");
                Console.WriteLine("To exit the program press any key...");
            }
           
        }
    }
}
