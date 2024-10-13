
using System;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace App_16;
public class Program
{
    public static void Main(string[] args)
    {   
        System.Console.WriteLine(MathOperation.Sum(4,5));
        System.Console.WriteLine(MathOperation.Sum(4,5,4));
        System.Console.WriteLine(MathOperation.Sum(4,5.4));
    }
}