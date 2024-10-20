using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

public class Dog : Animal
{
    public override void Move()
    {
        System.Console.WriteLine("Move Dog");
    }

    public void Jump_dog()
    {
        System.Console.WriteLine("Jump_dog");
    }
}
