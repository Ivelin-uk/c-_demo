
using System;
using System.Linq;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

public class Program
{
    public static void Main(string[] args)
    {   
        //string text =  "7,7,7,2,2,5,6,2,5,8";  
        //string[] numbersAsStirng = text.Split(new string[] { "-","," }, StringSplitOptions.RemoveEmptyEntries).ToArray();
        //int[] numbers = numbersAsStirng.Select(x => int.Parse(x)).ToArray();
        //int[] even_numbers = numbers.Where(element => element % 2 == 0).ToArray();
        //string result = String.Join(", ", even_numbers);

        //int[] numbers = Console.ReadLine().Split(' ').Select(e => int.Parse(e)).Where(e => e % 2 == 0).ToArray();

        int[] numbers = Console.ReadLine().Split(new string[] {", " }, StringSplitOptions.RemoveEmptyEntries).Select(e => int.Parse(e)).Where(e => e % 2 != 0).OrderBy(x => x).ToArray();
        Console.WriteLine(string.Join(", ", numbers));
    }
}