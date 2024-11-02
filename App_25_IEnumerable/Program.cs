
using System;
using System.Linq;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

public class Program
{
    public static void Main(string[] args)
    {   
        CarCollection cars = new CarCollection();
        cars.Add(new Car(100, "VW"));
        cars.Add(new Car(70, "AUDI"));
        cars.Add(new Car(200, "BMW"));

        
   
        foreach (Car car in cars)
        {
            Console.WriteLine(car);
        }
    }
}