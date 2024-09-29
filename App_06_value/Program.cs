
using System;
public class Program
{
    public static void Main(string[] args)
    {       
        //Прости дипове данни 
        //byte, ubyte, short, ushort, int, uint, long ulong, float , double , bool 

        //Референтни
        //Масиви , обектите

        int number = 10;
        System.Console.WriteLine(number);
        Update(number);
        System.Console.WriteLine(number);
    }

    public static void Update(int number) 
    {
        number = 100;
    }
}