using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oopspillarsdemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Methodoverloading c1 = new Methodoverloading();
            Console.WriteLine(c1.Add(1, 2, 3)); //compile time polymorphism
            Console.WriteLine(c1.Add(2, 2));
            Console.WriteLine(c1.Add(3.4, 4));
            Console.WriteLine(c1.Add(5, 4.5));

        }
    }
}
