using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ShoppingList
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter directory name");
            string newDirectory = Console.ReadLine();
            Console.WriteLine("Enter file name");
            string fileName = Console.ReadLine();

            string rootDirectory = @"C:\Users\...\samples";
            string fileLocation = @$"C:\Users\...\samples\{newDirectory}";
            string Shopinglist = @$"\\{fileName}";
            bool loopActive = true;


                if (!Directory.Exists($"{rootDirectory}\\{newDirectory}") || !File.Exists($"{rootDirectory}\\{newDirectory}\\{fileName}"))
                {
                    Directory.CreateDirectory($"{rootDirectory}\\{newDirectory}");
                    File.Create($"{rootDirectory}\\{newDirectory}\\{fileName}");
                }
                else
                {
                    Console.WriteLine($"Directory and file exist");
                }

           



            string[] arrayFromFile = File.ReadAllLines($"{fileLocation}{Shopinglist}");
            List<string> myShoppingList = arrayFromFile.ToList<string>();

            while (loopActive)
            {
                Console.WriteLine("Would you like to add a wish? Y/N:");
                char userInput = Convert.ToChar(Console.ReadLine().ToLower());

                if (userInput == 'y')
                {
                    Console.WriteLine("Enter your wish:");
                    string userWish = Console.ReadLine();
                    myShoppingList.Add(userWish);
                }
                else
                {
                    loopActive = false;
                    Console.WriteLine("Take care!");
                }

            }

            Console.Clear();

            foreach (string wish in myShoppingList)
            {
                Console.WriteLine($"Your wish: {wish}");
            }

            File.WriteAllLines($"{fileLocation}{Shopinglist}", myShoppingList);



        }
    }
}
