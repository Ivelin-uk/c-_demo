
using System;
public class Program
{
    public static void Main(string[] args)
    {       
        //Създаване на обект от тип Peson
        Peson peson2 = new Peson();
        peson2.Age = 10;
        peson2.Name = "Pesho";
        peson2.IntroduceYourself();

        BankAccount BankAccount1 = new BankAccount();
        BankAccount1.ID = 4;
        BankAccount1.Balance = 500;

        BankAccount BankAccount2 = new BankAccount();
        BankAccount2.ID = 6;
        BankAccount2.Balance = 2000;

        BankAccount BankAccount3 = new BankAccount();
        BankAccount3.ID = 55;
        BankAccount3.Balance = 800;


        Peson peson3 = new Peson();
        peson3.Age = 20;
        peson3.Name = "Ivan";
        peson3.AddBankAccount(BankAccount1);
        peson3.AddBankAccount(BankAccount2);
        peson3.AddBankAccount(BankAccount3);
        //System.Console.WriteLine(peson3.GetBalance());

        peson3.IntroduceYourself();

        /*
        int[] numbers = new int[5];
        string[] names = new string[5];
        double[] grades = new double[5];

        //Създавене на масив от обекти от тип Peson
        Peson[] pesons = new Peson[5];
        pesons[0] = peson1;
        pesons[2] = peson2;
        /*

        /*
        //Сравянване на два обекта
        if(peson1.age == peson2.age)
        {
            System.Console.WriteLine("yes");
        }
        else
        {
            System.Console.WriteLine("no");
        }
        */
    }
}