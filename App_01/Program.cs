
using System;
public class Program
{
    public static void Main(string[] args)
    {
        //C#
        //1 -> type data
        //int n = 4;

        //Console.WriteLine(10.0 / 3); //3
        //Console.WriteLine(10 / 3); //3
        //Console.WriteLine(10 % 3); //1
        //Console.WriteLine(4.04 + 3.02 + 5.01); //1

        //2 -> if else && ||

        /*
        int n = 4;
        int m = 5;
        if(n != m) // -> true
        {
            if(n < m) // -> true
            {
                System.Console.WriteLine("in1");
            }
            System.Console.WriteLine("in2");
        }
        else
        {
            System.Console.WriteLine("in3");
        }
        */

        //3 -> loops -> for, while, do while

        //2 4 6 8 10 ...... 100
        /*
       6
        {
            if(i % 2 == 0)
            {
                Console.WriteLine(i);
            }
        }

        System.Console.WriteLine(20 % 3);
        */
    
        //4 -> arrays, list, dictionary,  data structures 
        double[] gradesGroupSofia = {2,4,4,4,2,6,6,2,5,3,4,4,4,2};
        PrintGrades(gradesGroupSofia);
        double sum = SumGrades(gradesGroupSofia);
        Console.WriteLine(sum);

        double arerage = AverageGrades(gradesGroupSofia);
        Console.WriteLine(arerage);
    }

    public static void PrintGrades(double[] grades)
    {
        System.Console.WriteLine("--------------------");
        for(int i = 0; i < grades.Length; i++)
        {
            System.Console.WriteLine("index[" + i + "] = " +  grades[i]);
        }
        System.Console.WriteLine("--------------------");
    }

    public static double SumGrades(double[] grades)
    {
        double sum = 0;
        for(int i = 0; i < grades.Length; i++)
        {
            double current_grade = grades[i];
            sum += current_grade;
        }

        return sum;
    }

    public static double AverageGrades(double[] grades)
    {
        double sum = SumGrades(grades);
        return (double)sum / grades.Length;
    }
}