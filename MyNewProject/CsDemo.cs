using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject

{
    class FatherHouse
    {

        public void House()
        {

            Console.WriteLine("this is father's house");
        }

        public void scootyPep()
        {
            Console.WriteLine("this is father's scooty pep");
        }
    }
    
    class SonHouse : FatherHouse
    {

        public void hondsBike()
        {
            Console.WriteLine("this is son's bike");
        }

        public static void Main(String[] args)
        {
            SonHouse son = new SonHouse();
            DaughterHouse dh = new DaughterHouse();
            son.House();
            son.scootyPep();
            son.hondsBike();
            dh.vespaBike();
            
        }
    }

    class DaughterHouse : FatherHouse
    {

        public void vespaBike()
        {
            Console.WriteLine("this is daughter's vespa bike");
        }
    } }