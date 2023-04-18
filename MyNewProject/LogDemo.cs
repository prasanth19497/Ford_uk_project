using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject
{
    internal class LogDemo
    {

        int a = 10;
        int b = 5;

        public void compareNumbers()
        {
            
            Console.WriteLine((a > b) && (a == b)); // false

            Console.WriteLine((a < b) && (a > b)); // false

            Console.WriteLine((a > b) || (a < b));   // true

            Console.WriteLine((b < a) || (b > a)); // true

            Console.WriteLine(!(a > b) && (a >= b));  //false

            Console.WriteLine(!(a < b));    //true
        }

        public static void Main(string[] args)
        {
            LogDemo demo = new LogDemo();
            demo.compareNumbers();
        }
    }
}
