using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject
{
    class ArithmeticOperations
    {
        // non parameterized method
        public void addNumbers()
        {
            Console.WriteLine("Addtion is " + (10+20));
        }
        // parameterized method
        public void addNumbers(int a, int b)
        {
            Console.WriteLine("Addtion is " + (a + b));
        }

        public void addNumbers(int a, double b)
        {
            Console.WriteLine("Addtion is " + (a + b));
        }

        public void addNumbers(double a, int b)
        {
            Console.WriteLine("Addtion is " + (a + b));
        }

        public void addNumbers(int a, int b, int c)
        {
            Console.WriteLine("Addtion is " + (a + b));
        }


        public static void Main(string[] args) {

            ArithmeticOperations op = new ArithmeticOperations();
            op.addNumbers();
            op.addNumbers(15, 20);
            op.addNumbers(10, 20.10);
            op.addNumbers(30.0, 40);
            op.addNumbers(10, 20, 30);

        }
    }
}
