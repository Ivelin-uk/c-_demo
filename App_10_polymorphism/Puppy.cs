using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace App_10_polymorphism
{
    public class Puppy : Dog
    {
        public void Weep()
        {
            System.Console.WriteLine("weeping...");
        }
    }
}