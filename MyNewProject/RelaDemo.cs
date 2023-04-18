using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject
{
    internal class RelaDemo
    {
        int a = 10;
        int b = 3;

        public void compareNumbers()
        {

            Console.WriteLine(a > b);

            Console.WriteLine(a < b);

            Console.WriteLine(a >= b);

            Console.WriteLine(a <= b);

            Console.WriteLine(a == b);

            Console.WriteLine(a != b);
        }

        public static void Main(string[] args)
        {
            RelaDemo demo = new RelaDemo();
            demo.compareNumbers();
        }

    }
}
