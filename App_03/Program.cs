
using System;
public class Program
{
    public static void Main(string[] args)
    {       
        Car car1 = new Car();
        Car car2 = new Car(200, "3 - ка");
        Car car3 = new Car(150, "VW", "Passat");
        Car car4 = new Car("Opel", "Corsa");
        Car car5 = new Car();

        //car1.Info();
        //car2.Info();
        //car3.Info();
        //car4.Info();

        System.Console.WriteLine(Car.Count);

        if (car1.HP == car2.HP)
        {
            System.Console.WriteLine("yes");
        }
        else
        {
            System.Console.WriteLine("no");
        }
    }
}