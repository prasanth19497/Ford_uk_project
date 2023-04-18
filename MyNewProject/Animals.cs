using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject
{
    interface Animals
    {
        void animalSound();

    }

    interface Humans
    {
        void humanBehaviour();

    }

    class Dogs : Animals, Humans
    {
        public void animalSound()
        {
            Console.WriteLine("Dog barks");
        }
        public void humanBehaviour()
        {
            Console.WriteLine("Human speaks");
        }

         public static void Main(string[] args)
            {
                Dogs d = new Dogs();
                d.animalSound();
            }

        }
    }
