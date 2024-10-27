
using System;
using System.Linq;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

public class Program
{
    public static void Main(string[] args)
    {   
        try
        {
            Car car1 = new Car(100,"VW");
            Car car2 = new Car(70,"AUDI");
            Car car3 = new Car(200,"BMW");
            Car car4 = new Car(150,"OPEL");
            Car car5 = new Car(230,"FORD");
            Car car6 = new Car(60,"FORD");

            Car[] cars = new Car[] { car1, car2, car3, car4, car5, car6};


            //Car[] upgadeCars = cars.Select(car => new Car(car.Hp * 2,car.Brand)).ToArray();
            //Car[] filterCars = cars.Where(car => car.Hp > 100).OrderBy(n => n).ToArray(); TO DOTO

            //int sumHp = cars.Sum(x => x.Hp);
            //System.Console.WriteLine(sumHp);

            //int maxHp = cars.Max(x => x.Hp);
            //System.Console.WriteLine(maxHp);


            /*
            for (int i = 0; i < filterCars.Length; i++)
            {
                Car currrnetCar = filterCars[i];
                System.Console.WriteLine( currrnetCar);
            } 


            if(car1 == car2)
            {
                System.Console.WriteLine("yes");   
            }
            else
            {
                System.Console.WriteLine("no");
            }
            */
        }
        catch (Exception ex)
        {
            System.Console.WriteLine(ex.Message);
        }
    }
}