using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace App_17
{
    public class Dog : Animal
    {
        public Dog(string name, string favouriteFood) : base(name,favouriteFood)
        {

        }

        public override string ExplainMyself()
        {
            return base.ExplainMyself() + Environment.NewLine + "DJAAF";
        }
    }
}