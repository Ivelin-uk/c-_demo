using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace App_18_Polymorphism
{
    public class Warrior : Hero
    {
        public override string Attack()
        {
            return "Warrior ATTACK !!";
        }

        public override string Defance()
        {
            return "Warrior Defance !!";
        }
    }
}