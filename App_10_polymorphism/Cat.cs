using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace App_10_polymorphism
{
    public class Cat : Animal
    {
        public void Meow()
        {
            System.Console.WriteLine("meowing...");
        }

        public override void Move()
        {
            System.Console.WriteLine("Move cat");
        }
    }
}