using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace App_18_Polymorphism
{
    public class Hunter : Hero
    {
        public override string Attack()
        {
            return "Hunter ATTACK !!";
        }

        public override string Defance()
        {
            return "Hunter Defance !!";
        }
    }
}