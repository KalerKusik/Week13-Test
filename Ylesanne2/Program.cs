using System;
using System.IO;

namespace Ylesanne2
{
    class Program
    {
        static void Main(string[] args)
        {
            string rootPath = @"C:\Users\admin\samples\kasutajaKaust";
            string toyota = @$"{rootPath}\toyota.txt";
            string bmw = @$"{rootPath}\bmw.txt";
            string tesla = @$"{rootPath}\tesla.txt";

            if(File.Exists(toyota))
            {
                Console.WriteLine($"{toyota} already exists.");
            }
            else 
            {
                File.Create(toyota);
                Console.WriteLine($"{toyota} has been created.");
            }
            if (File.Exists(bmw))
            {
                Console.WriteLine($"{bmw} already exists.");
            }
            else
            {
                File.Create(bmw);
                Console.WriteLine($"{bmw} has been created.");
            }
            if (File.Exists(tesla))
            {
                Console.WriteLine($"{tesla} already exists.");
            }
            else
            {
                File.Create(tesla);
                Console.WriteLine($"{tesla} has been created.");
            }
        }
    }
}