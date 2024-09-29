
using System;
namespace App_09;
public class Program
{
    public static void Main(string[] args)
    {       
        Student student = new Student("Ivan","Sofia","Vasil Levski");
        System.Console.WriteLine(student);

        Employee employee = new Employee("Pesho", "Varna" , "IT Varna");
        System.Console.WriteLine(employee);

        CollegeStudent collegeStudent = new CollegeStudent("Pesho2", "Varna2" , "IT Varna2");
        System.Console.WriteLine(collegeStudent);
    }
}