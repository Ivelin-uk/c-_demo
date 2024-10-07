using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace App_14
{
    public class Dog : Animal 
    {
        public Dog(string name, int age) : base(name, age)
        {

        }

        public override string MakeNoise()
        {
            return "Woof! " + base.MakeNoise();
        }

        public override string MakeTrick()
        {
            return "Hold my paw, human! " + base.MakeTrick();
        }
    }
}