using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


abstract public class Animal
{
    public void Eat()
    {
        System.Console.WriteLine("Eating...");
    }

    public abstract void Move();
}
