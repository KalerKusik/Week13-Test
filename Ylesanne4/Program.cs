using System;
using System.IO;

namespace Ylesanne4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Car Name:");
            string userInput = Console.ReadLine().ToLower();
            
            string rootPath = @"C:\Users\admin\samples\kasutajaKaust";
            string toyota = @$"{rootPath}\toyota.txt";
            string bmw = @$"{rootPath}\bmw.txt";
            string tesla = @$"{rootPath}\tesla.txt";

            if (userInput == "toyota")
            {
                if(File.Exists(toyota))
                {
                    string[] toyotaOutput = File.ReadAllLines(toyota);
                    foreach (string s in toyotaOutput)
                    {
                        Console.WriteLine(s);
                    }
                }
                else
                {
                    Console.WriteLine("File doesn't exist");
                }
            }
            else if(userInput == "bmw")
            {
                if (File.Exists(bmw))
                {
                   string[] bmwOutput = File.ReadAllLines(bmw);
                   foreach(string s in bmwOutput)
                    {
                        Console.WriteLine(s);
                    }
                }
                else
                {
                    Console.WriteLine("File doesn't exist");
                }
            }
            else if(userInput == "tesla")
            {
                if (File.Exists(tesla))
                {
                    string[] teslaOutput = File.ReadAllLines(tesla);
                    foreach (string s in teslaOutput)
                    {
                        Console.WriteLine(s);
                    }
                }
                else
                {
                    Console.WriteLine("File doesn't exist");
                }
            }
            else 
            {
                Console.WriteLine($"{userInput} does not exist.");
            }
        }
    }
}
