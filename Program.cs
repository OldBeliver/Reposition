using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
