
using System;
using System.Collections;

namespace App_12;
public class Program
{
    public static void Main(string[] args)
    {       
        FullTimeEmployee fullTimeEmployee = new FullTimeEmployee("32131","Ivan","Sofia","Junier","IT");
        ContractEmployee contractEmployee = new ContractEmployee("32131","Ivan","Sofia","make site","IT");

        System.Console.WriteLine(fullTimeEmployee.Show());
        System.Console.WriteLine(contractEmployee.Show());
    }
}