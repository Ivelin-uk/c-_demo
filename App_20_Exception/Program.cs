
using System;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

public class Program
{
    public static void Main(string[] args)
    {   
        try
        {
            Console.WriteLine("Start");
            Console.Write("N1: ");
            int n1 = int.Parse(Console.ReadLine());

            Console.Write("N2: ");
            int n2 = int.Parse(Console.ReadLine());

            int r = n1 / n2;
            Console.Write("R: ");
            System.Console.WriteLine(r); 
        }
        catch (Exception error)
        {
            Console.WriteLine(error.Message);
            //logic
        }
        finally
        {
            Console.WriteLine("End");
        }
    }
}
