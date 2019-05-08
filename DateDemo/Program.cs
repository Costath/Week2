using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Date D = new Date(1992, 07, 23);
            Console.WriteLine(D);

            D.Add(10);
            Console.WriteLine(D);

            D.Add(5, 5);
            Console.WriteLine(D);

            Date D2 = new Date(1, 25, 25);
            D.Add(D2);
            Console.WriteLine(D2);
            Console.WriteLine(D);

            Date DDD = new Date(2019, 5, 8);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(DDD);
            DDD.Add(365);
            Console.WriteLine(DDD);

        }
    }
}
