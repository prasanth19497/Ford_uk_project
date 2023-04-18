using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject
{
    internal class ShortHand
    {

        int a = 10;
        int b = 3;

        public void compareNumbers()
        {

            // a = a + b;

            Console.WriteLine(a += b); //13
            Console.WriteLine(a -= b); //10
            Console.WriteLine(a *= b); //30
            Console.WriteLine(a %= b); //0
            Console.WriteLine(a /= b); // 0
        }

        public static void Main(string[] args)
        {
            ShortHand hand= new ShortHand();
            hand.compareNumbers();
        }
    }
}
