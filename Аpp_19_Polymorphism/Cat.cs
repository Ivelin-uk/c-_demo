using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

public class Cat : Animal
{
    public override void Move()
    {
        System.Console.WriteLine("Move Cat");
    }

    public void Jump_cat()
    {
        System.Console.WriteLine("Jump_cat");
    }
}
