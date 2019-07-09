using System;

namespace ExtensionMethodSample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter String to remove space: ");
            string str = Console.ReadLine();
            Console.WriteLine("Output: " + str.RemoveSpace());

            Console.ReadLine();
        }
    }
}
