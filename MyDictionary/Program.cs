using System;

namespace homework2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kubilay TUNÇBAŞ'ın Film Puanlaması");
            MyDictionary<int, string> myDictionary = new MyDictionary<int, string>();
            myDictionary.Add(10, "The Lord Of The Rings:Two Towers");
            myDictionary.Add(8, "The Godfather");
            myDictionary.Add(8, "Pulp Fiction");
            myDictionary.Add(7, "Harry Potter");
            myDictionary.Add(8, "Star Wars:Part 2");

            myDictionary.Listing();
            
        }
    }
}
