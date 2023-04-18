using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject
{
    class ArrayDemo
    {
        public static void Main(string[] args)
        {

            int[] myArray = {5,8,4,1,2,9};

            Array.Resize(ref myArray, 8);

           foreach(int i in myArray)
            {
                Console.WriteLine(i);
            }

        }
    }
}
