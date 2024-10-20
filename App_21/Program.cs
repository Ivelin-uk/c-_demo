
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
            Console.Write("Enter number: ");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine(int.MaxValue);
            Console.WriteLine(int.MinValue);

            Console.WriteLine("You entered a valid Int32 number {0}.", number);
        }
        catch (FormatException error) 
        {
            Console.WriteLine(error.Message);
            Console.WriteLine(error.InnerException);
            Console.WriteLine("Invalid integer number!");
        }
        catch (OverflowException error)
        {
            Console.WriteLine("The number is too big to fit in Int32!");
        }
        finally
        {
            Console.WriteLine("END");
        }
    }
}
