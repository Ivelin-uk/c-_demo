
using System;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

public class Program
{
    public static void Main(string[] args)
    {     
        Cat cat1 = new Cat();  
        Cat cat2 = new Cat();

        Dog dog1 = new Dog();
        Dog dog2 = new Dog();

        Snake snake1 = new Snake();
        Snake snake2 = new Snake();

        Animal[] animals = new Animal[10];
        animals[0] = dog1;
        animals[1] = dog2;
        animals[2] = cat1;
        animals[3] = cat2;
        animals[4] = snake1;
        animals[5] = snake2;
      
        /*
        for (int i = 0; i < animals.Length; i++)
        {
            Animal currentAninal = animals[i];
            if(currentAninal != null)
            {
                currentAninal.Move();
            }
        }  
        */  

        Attack(cat1);
        Attack(dog1);
        Attack(snake1);
    }

    public static void Attack(Animal animal)
    {
        System.Console.WriteLine("---------------");
        animal.Eat();
        animal.Move();
        System.Console.WriteLine("---------------");
    }
}
