
using System;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace App_18_Polymorphism;
public class Program
{
    public static void Main(string[] args)
    {   
        Hero mage1 = new Mage();
        Hero hunter1 = new Hunter();
        Hero warrior1 = new Warrior();

        Hero mage2 = new Mage();
        mage2.Attack();
        mage2.Defance();

        Mage mage3 = new Mage();
        mage3.Attack();
        mage3.DoubleAttack();
        mage3.Defance();

        //int[] numbers = new int[10];
        Hero[] heros = new Hero[5];
        heros[0] = mage1;
        heros[1] = mage2;
        heros[2] = mage3;
        heros[3] = hunter1;
        heros[4] = warrior1;
          
        for(int i = 0; i < heros.Length; i++)
        {
            Hero currentHero = heros[i];
            Click(currentHero);
        }

        /*
        Hero hero1 = new Mage();
        Hero hero2 = new Hunter();
        Hero hero3 = new Warrior();
    
        Click(hero1);
        Click(hero2);
        Click(hero3);
        */
    }

    public static void Click(Hero hero)
    {
        System.Console.WriteLine("============");  
        System.Console.WriteLine(hero.Attack());
        System.Console.WriteLine(hero.Defance());
        System.Console.WriteLine("============");  
    }
}