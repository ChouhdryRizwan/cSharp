using System;
using System.Collections;
using System.Collections.Generic;

namespace Collection
{
    class Collections
    {
        static void Main(string[] args)
        {
            //-----------------Non Generic Collection-------------------

            var list = new ArrayList();
            list.Add(true);
            list.Add("Unnar");
            list.Add(25);
            list.Add(35.6);

            //list.Remove(true);
            //list.RemoveAt(0);
            //list.Insert(0, true);
            //list.Contains("Unnar");
            //list.IndexOf("Unnar");
            //list.Reverse();
            //list.Sort();

            //Console.WriteLine(list.GetType().ToString()) ;

            //foreach (var item in list)
            //{
            //    Console.WriteLine(item);
            //}

            var list2 = new Hashtable();

            list2.Add("Name", "Ali");
            list2.Add("Age", 25);
            list2.Add("Country", "Pakistan");

            //Console.WriteLine(list2["Name"]); // Output: Ali

            //foreach (var item in list2)
            //{
            //    Console.WriteLine(item);
            //}

            //foreach (DictionaryEntry item in list2)
            //{
            //    Console.WriteLine($"Key: {item.Key}, Value: {item.Value}");
            //}

            //-----------------Generic Collection-------------------

            List<string> cart = new List<string>();
            cart.Add("Laptop");
            cart.Add("Mouse");
            cart.Add("Keyboard");

            //Console.WriteLine($"Total items: {cart.Count}");

            Dictionary<string, string> phoneBook = new Dictionary<string, string>();
            phoneBook.Add("Ali", "03001234567");
            phoneBook.Add("Ahmed", "03219876543");

            //Console.WriteLine(phoneBook["Ali"]);

            Queue<string> customers = new Queue<string>(); //FIFO
            customers.Enqueue("Ali");
            customers.Enqueue("Sara");

            //Console.WriteLine(customers.Dequeue()); // Ali first aya, pehle nikal gaya


            Stack<string> history = new Stack<string>(); //LIFO
            history.Push("Page1");
            history.Push("Page2");

            Console.WriteLine(history.Pop()); // Latest page delete

        }
    }
}