using System;
using System.Security.Cryptography;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.Write("Please enter your password: ");
            string password = Console.ReadLine();
            Console.WriteLine($"your new password is \"{password}\"");
        }
    }
}