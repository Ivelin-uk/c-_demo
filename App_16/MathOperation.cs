using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace App_16
{
    public class MathOperation
    {
        public static int Sum(int n1, int n2)
        {
            System.Console.WriteLine("int, int");
            return n1 + n2;
        }

        public static double Sum(double n1, int n2)
        {
            System.Console.WriteLine("double, int");
            return n1 + n2;
        }

        public static double Sum(int n1, double n2)
        {
            System.Console.WriteLine("int, double");
            return n1 + n2;
        }

        public static double Sum(int n1, int n2, int n3)
        {
             System.Console.WriteLine("int, int, int");
            return n1 + n2 + n3;
        }
    }
}