using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject
{
    internal class Incdec
    {

        int var1 = 10;

        public void execNumbers()
        {

            Console.WriteLine(var1); // 10

            Console.WriteLine(var1++); // 10

            Console.WriteLine(var1); //11

            Console.WriteLine(var1--); //11

            Console.WriteLine(var1);  //10

            Console.WriteLine(++var1); // 11

            Console.WriteLine(var1); //11

            Console.WriteLine(--var1); //10
                                    
        }

        public static void Main(string[] args) { 

            Incdec demo = new Incdec();
            demo.execNumbers();
        
        }
    }
}
