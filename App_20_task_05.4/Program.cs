
using System;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

public class Program
{
    public static void Main(string[] args)
    {     
        IMakeNoise cat1 = new Cat();
        IMakeNoise dog1 = new Dog();
        System.Console.WriteLine(cat1.MakeNoise());
        System.Console.WriteLine(dog1.MakeNoise());

        IMakeTrick cat2 = new Cat();
        IMakeTrick dog2 = new Dog();
        System.Console.WriteLine(cat2.MakeTrick());
        System.Console.WriteLine(dog2.MakeTrick());

        IAnimal cat3 = new Cat();
        IAnimal dog3 = new Dog();
        System.Console.WriteLine(cat3.Perform());
        System.Console.WriteLine(dog3.Perform());

        Cat cat4 = new Cat();
        Dog dog4 = new Dog();
        System.Console.WriteLine(cat4.Jump_cat());
        System.Console.WriteLine(dog4.Jump_dog());

        System.Console.WriteLine("-------------");
        Trainer trainer = new Trainer(cat3);
        trainer.Make();

    }
}
