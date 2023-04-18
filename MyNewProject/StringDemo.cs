using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject
{
    class StringDemo
    {

        string str = ".NET DEVELOPER";

        public void demoMethods()


        {
     
            Console.WriteLine(str.Contains(".NET DEVELOPER"));

            
        }

        public static void Main(string[] args) { 
        
            StringDemo demo = new StringDemo();
            demo.demoMethods();
        }

    }
}
