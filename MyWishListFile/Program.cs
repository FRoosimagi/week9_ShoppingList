using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace myShoppingListFile
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileLocation = @"C:\Users\...\samples\shoppingList";
            string fileName = @"\\myshoppingList.txt";

            string[] arrayFromFile = File.ReadAllLines($"{fileLocation}{fileName}");
            List<string> myShoppingList = arrayFromFile.ToList<string>();

            bool loopActive = true;

            while (loopActive)
            {
                Console.WriteLine("Would you like to add an iteam to your shopping list? Y/N:");
                char userInput = Convert.ToChar(Console.ReadLine().ToLower());

                if(userInput == 'y')
                {
                    Console.WriteLine("Add an item:");
                    string shoppingitem = Console.ReadLine();
                    myShoppingList.Add(shoppingitem);
                }
                else
                {
                    loopActive = false;
                    Console.WriteLine("Take care!");
                }

            }

            Console.Clear();

            foreach(string item in myShoppingList)
            {
                Console.WriteLine($"Your list: {item}");
            }
            
            File.WriteAllLines($"{fileLocation}{fileName}", myShoppingList);
        }
    }
}
