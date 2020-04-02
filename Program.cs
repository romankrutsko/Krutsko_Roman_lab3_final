using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace krlab3._0._1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Zavdannya 1
            List<int> listOfNumbers = new List<int>();
            int i = 0;
            string path = @"C:\Users\romak\Desktop\TestLab3.txt";
            using (StreamReader read = new StreamReader(path))
            {
                while (read.Peek() > -1)
                {
                    string s = read.ReadLine();
                    listOfNumbers.Add(s.Length);
                    Console.WriteLine(listOfNumbers[i]);
                    i++;
                }
            }
            //Zavdannya 2
            Dictionary<int, string> dict = new Dictionary<int, string>();

            while (Console.ReadKey(true).Key != ConsoleKey.Escape)
            {
                Console.WriteLine("Enter the key(integer value)first, then the value itself(string value)");
                Console.WriteLine("If you want to quit, press Esc");
                int key = Convert.ToInt32(Console.ReadLine());
                string value = Console.ReadLine();

                dict.Add(key, value);
            }
            int keyCompared = 100000;
            Console.WriteLine("Enter the key you want to compare with");
            int keyEntered = Convert.ToInt32(Console.ReadLine());
            foreach (KeyValuePair<int, string> keyValue in dict)
            {
                if (keyValue.Key >= keyEntered)
                {
                    if (keyValue.Key < keyCompared)
                    {
                        keyCompared = keyValue.Key;
                    }
                }
            }
            Console.WriteLine("The closest key value to your entered is: " + keyCompared);

            //Zavdannya 3
            int[] mas = new int[50];
            for (int k = 0; k<mas.Length; k++)
            {
                Random rnd = new Random();
                mas[k] = rnd.Next(-20,50);
            }
            foreach (int r in mas)
            {
                Console.Write(r + " ");
            }
            Console.WriteLine();
            IEnumerable<int> masSelected = mas.Where(n => n % 2 == 0 && n < 0).Reverse();
            foreach (int s in masSelected)
                Console.Write(s + " ");
        }
    }
}