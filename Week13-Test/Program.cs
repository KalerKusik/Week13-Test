
using System;
using System.IO;

namespace Week13_Test
{
    class Program
    {
        static void Main(string[] args)
        {
            string rootPath = @"C:\Users\admin\samples";
            Console.WriteLine("Directory Name:");
            string directoryName = Console.ReadLine();
            string directoryCreate = @$"{rootPath}\{directoryName}";

            bool directoryExists = Directory.Exists(directoryCreate);

            if (directoryExists)
            {
                Console.WriteLine($"Directory {directoryName} Already Exists");
            }
            else
            {
                Console.WriteLine("Creating Directory...");
                Directory.CreateDirectory(directoryCreate);
                Console.WriteLine("Success!");
            }
        }
    }
}
