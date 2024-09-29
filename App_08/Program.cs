
using System;
namespace App_08;
public class Program
{
    public static void Main(string[] args)
    {       
        Hore h1 = new Hore();
        h1.Attact();

        Hunter hunter1 = new Hunter();
        hunter1.Attact();

        Mage mage1 = new Mage();
        mage1.Attact();

        Warior warior1 = new Warior();
        warior1.Attact();
    }
}