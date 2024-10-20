
using System;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

public class Program
{
    public static void Main(string[] args)
    {   
        string str = Console.ReadLine();
        try
        { 
            Int32.Parse(str);
        }
        catch (FormatException e)
        { 
            Console.WriteLine("Invalid integer number!");
        }
        catch (OverflowException e)
        { 
            Console.WriteLine("The number is too big to fit in Int32!");
        }
        catch (Exception e)
        { 
            Console.WriteLine("Cannot parse the number!");
        }
    }
}
