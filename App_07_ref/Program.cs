
using System;
public class Program
{
    public static void Main(string[] args)
    {       
        //Прости дипове данни 
        //byte, ubyte, short, ushort, int, uint, long ulong, float , double , bool 

        //Референтни
        //Масиви , обектите

        int[] numbers = {1,2,3,4,5,6};
        System.Console.WriteLine(String.Join(",", numbers));
        Update(numbers);
        System.Console.WriteLine(String.Join(",", numbers));
    }

    public static void Update(int[] arr) 
    {
        arr[0] = 100; 
    }
}