using ProgressionLibrary;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace ProgressionLibrary;
internal class Program
{
    private static void Main(string[] args)
    {
        Progression p1 = new Progression(2, 5);
        Progression p2 = new Progression(-8, 3);
        Progression p3 = new Progression(100, -2.5);
        Progression p4 = new Progression(0, 0);
        Progression p5 = new Progression(10, 2);

        Progression res = (p1 + p2) - p3 * -2;
        Console.WriteLine(res);

        Console.WriteLine("The element with index 100 is " + res[100]);

        if (p4)
        {
            Console.WriteLine(p4);
        } else
        {
            Console.WriteLine("Progression is empty");
        }
        
        if (p3 > p1) { Console.WriteLine(p1 + " is less than " + p3); }
        if (p2 < p1) { Console.WriteLine(p1 + " is greater than " + p2); }
        if (p1 == p2 + p5) { Console.WriteLine("The sum of " + p2 + p5 + " is equal " + p1); }

    }
}