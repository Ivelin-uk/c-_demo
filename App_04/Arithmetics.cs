public class Arithmetics
{
    public static int Add(int n1, int n2)
    {
        int sum = n1 + n2;
        return sum;
    }

    public static double Add(double n1, double n2)
    {
        return n1 + n2;
    }

    public static int Add(int n1, int n2, int n3)
    {
        int sum = n1 + n2 + n3;
        return sum;
    }

    public static int Multiply(int a, int b) {
        return a * b;
    }

    public void Test()
    {
        System.Console.WriteLine("Test");
    }
}