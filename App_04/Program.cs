
using System;
public class Program
{
    public static void Main(string[] args)
    {       
        //int sum = Arithmetics.Add(3,3);
        //System.Console.WriteLine(Arithmetics.Add(3,10));
        //System.Console.WriteLine(Arithmetics.Add(5,5,3));
        //System.Console.WriteLine(Arithmetics.Add(5.2, 4.3));

        Arithmetics arithmetics = new Arithmetics();
        arithmetics.Test();
        System.Console.WriteLine(Math.PI);
    }
}