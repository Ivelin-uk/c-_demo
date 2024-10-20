using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace App_10_polymorphism
{
    abstract public class Animal
    {
        public void Eat()
        {
            System.Console.WriteLine("eating...");
        }

        public abstract void Move();
    }
}