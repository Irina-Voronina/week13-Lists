using System;
using System.Collections.Generic;

namespace Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> fruitSalad = new List<string>();

            fruitSalad.Add("yogurt");

            for(int i =0; i < 3; i++)
            {
                Console.WriteLine($"Enter the ingredient {i + 1}:");
                string userIngridient = Console.ReadLine();
                fruitSalad.Add(userIngridient);
            }

            Console.WriteLine($"Your salad consists of: {fruitSalad.Count} ingridients.");

            DisplayIngridients(fruitSalad);

        }

        public static void DisplayIngridients(List<string> someList)
        {
            foreach (string ingridient in someList)
            {
                Console.WriteLine(ingridient);
            }
        }


    }
}
