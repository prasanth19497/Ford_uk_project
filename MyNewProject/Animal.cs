using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject
{
    abstract class Animal
    {
        public abstract void MakeSound();

        public void animalsBehaviours()
        {
            Console.WriteLine("each animal has different behaviours");
        }

    }

    class Dog : Animal
    {

        public override void MakeSound()
        {
            Console.WriteLine("Dog barks");
        }
    }

    class Cat : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("cat meow");
        }

        public static void Main(String[] args)
        {
            Cat c = new Cat();
            Dog d = new Dog();
            d.MakeSound();
            c.MakeSound();
        }

    }
}
