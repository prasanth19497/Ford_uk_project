using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject
{
     class AxisBank
    {
        public void SavingsAccount()
        {
            Console.WriteLine("7 % interest");
        }

        public void currentAccount()
        {
            Console.WriteLine("10 % interest");
        }
    }

    class RBLBank : AxisBank
    {
        public void SavingsAccount()
        {
            Console.WriteLine("8 % interest");
        }

        public void currentAccount()
        {
            Console.WriteLine("12 % interest");
        }
        public static void Main(String[] args)
        {
            RBLBank rbl = new RBLBank();
            AxisBank ax = new AxisBank();
            ax.currentAccount();
            rbl.SavingsAccount();
            rbl.currentAccount();
           
        }

    }
}
