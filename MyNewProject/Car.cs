using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject
{
    public class Student
    {
        protected internal string name = "nikhil";
    }

    class Program : Student
    {
        public static void Main(string[] args)
        {
            Program p = new Program();
            Console.WriteLine(p.name);

        }
    }
}
