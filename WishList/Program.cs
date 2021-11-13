using System;
using System.Collections.Generic;

namespace WishList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> myShoppingList = new List<string>();


            myShoppingList.Add("Coffee machine");
            myShoppingList.Add("New pair of socks");
            myShoppingList.Add("box of chocolates");
            myShoppingList.Add("new pillow");

            Console.WriteLine(myShoppingList.Count);

            foreach (string wish in myShoppingList)
            {
                Console.WriteLine(wish);
            }
        }
    }
}
