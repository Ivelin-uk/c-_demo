using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace App_18_Polymorphism
{
    public class Mage : Hero
    {
        public override string Attack()
        {
            return "Mage ATTACK !!";
        }

        public string DoubleAttack()
        {
            return "Mage DoubleAttack !!";
        }

        public override string Defance()
        {
            return "Mage Defance !!";
        }
    }
}