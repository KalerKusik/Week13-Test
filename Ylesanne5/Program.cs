using System;
using System.IO;

namespace Ylesanne5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of facts:");
            int userNumber = Convert.ToInt32(Console.ReadLine());

            GetJokes(userNumber);
        }

        private static void GetJokes(int jokesNumber)
        {
            string filePath = @"C:\Users\admin\samples\funFacts.txt";
            string[] jokesAboutChuck = File.ReadAllLines(filePath);

            if (jokesNumber > jokesAboutChuck.Length)
            {
                jokesNumber = jokesAboutChuck.Length;
            }
            else if (jokesNumber < 0)
            {
                jokesNumber = 1;
            }

            for (int i = 0; i < jokesNumber; +1 i++)
            {
                Console.WriteLine(jokesAboutChuck[i]);
            }
        }
    }
}