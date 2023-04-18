using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject
{
    class StatDemo
    {
        static int a = 10;
        static int b = 20;

        public static void addNumbers()
        {
            Console.WriteLine("addition is " + (a +b));
        }

        public static void subNumbers()
        {
            Console.WriteLine(a - b);
        }

        public static void Main(string[] args)
        {
           /*StatDemo demo = new StatDemo();
            demo.subNumbers();*/
            addNumbers();
            StatDemo.subNumbers();
           
            
        }


    }
}
