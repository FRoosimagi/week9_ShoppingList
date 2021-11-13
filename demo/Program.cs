using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace demo
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }

        private static void NewDirectoryfile(string directory)
        {
            Console.WriteLine("Enter directory name");
            string newDirectory = Console.ReadLine();
            

            string rootDirectory = @"C:\Users\Dell\samples";
            string fileLocation = @$"C:\Users\Dell\samples\{newDirectory}";


            if (!Directory.Exists($"{rootDirectory}\\{newDirectory}"))
            {
                Directory.CreateDirectory($"{rootDirectory}\\{newDirectory}");
            }
            else
            {
                Console.WriteLine($"Directory and file exist");

            }
        }
        private static void newFile(string file)
        {
            string newDirectory = NewDirectoryfile(newDirectory);

            Console.WriteLine("Enter file name");
            string fileName = Console.ReadLine();
            string rootDirectory = @"C:\Users\Dell\samples";

            if (!File.Exists($"{rootDirectory}\\{newDirectory}\\{fileName}"))
            {
                File.Create($"{rootDirectory}\\{newDirectory}\\{fileName}");
            }
            else
            {
                Console.WriteLine($"Directory and file exist");

            }
        }

        private static void second()
        {
            string fileLocation = @$"C:\Users\Dell\samples\{newDirectory}";
            string Shopinglist = @$"\\{fileName}";

            bool loopActive = true;

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
