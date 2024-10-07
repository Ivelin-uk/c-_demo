
using System;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace App_14;
public class Program
{
    public static void Main(string[] args)
    {       
        Cat cat = new Cat("Pipe",11);

        Dog dog = new Dog("Pipe2",11);

        Console.WriteLine(cat.MakeNoise());
        Console.WriteLine(cat.MakeTrick());

        Console.WriteLine("-------------");

        Console.WriteLine(dog.MakeNoise());
        Console.WriteLine(dog.MakeTrick());



    }
}