using System;
using System.IO;

namespace ShoppinListFileAndFolder
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


            if (Directory.Exists($"{rootDirectory}\\{newDirectory}") || File.Exists($"{rootDirectory}\\{newDirectory}\\{fileName}"))
            {
                Console.WriteLine($"Directory and file exist");
            }
            else
            {
                Directory.CreateDirectory($"{rootDirectory}\\{newDirectory}");
                File.Create($"{rootDirectory}\\{newDirectory}\\{fileName}");
            }
        }
    }
    
}
