using System;

namespace Reposition
{
    class Program
    {
        static void Main(string[] args)
        {
            string title = "Яга";
            string name = "баба";

            Console.WriteLine($"{title} {name}");

            string tempValue = title;
            title = name;
            name = tempValue;

            Console.WriteLine($"{title} {name}");
        }
    }
}
