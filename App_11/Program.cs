
using System;
using System.Collections;

namespace App_11;
public class Program
{
    public static void Main(string[] args)
    {       
        RandomList arrayList = new RandomList();
        arrayList.Add(4);
        arrayList.Add(5);
        arrayList.Add(5);
        arrayList.Add(6);

        arrayList.RandomString();

        foreach (int i in arrayList)
        {
            System.Console.WriteLine(i);
        }
        
    }
}