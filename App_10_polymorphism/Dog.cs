using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace App_10_polymorphism
{
    public class Dog : Animal
    {
        public void Bark()
        {
            System.Console.WriteLine("barking...");
        }

        public override void Move()
        {
            System.Console.WriteLine("Move dog");
        }
    }
}