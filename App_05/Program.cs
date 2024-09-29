
using System;
public class Program
{
    public static void Main(string[] args)
    {       
        //Прости дипове данни 
        //byte, ubyte, short, ushort, int, uint, long ulong, float , double , bool 

        //Референтни
        //Масиви , обектите
        String name1 = "Pesho";
        string name2 = "Ivan";
        String s = "You win some. You lose some.";
        System.Console.WriteLine(s.Lenght);

        Phone phoneOne = new Phone();
        phoneOne.price;
        phoneOne.Show();

        string[] subs = s.Split(' ');
        foreach (var sub in subs)
        {
            Console.WriteLine($"Substring: {sub}");
        }
    }
}