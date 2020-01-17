using System;
public class Program
{   
     public static int Add(int x, int y)
    {
        return x + y;
    }
    public static int Multiply(int x, int y)
    {
        return x * y;
    }
    public static int Subtract(int x, int y)
    {
        return x - y;
    }
    public static float Division(int x, int y)
    {	
        return x / y;
    }
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter First Number:");
        int x = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter Second Number");
        int y = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(Add(x, y));
        Console.WriteLine(Multiply(x, y));
        Console.WriteLine(Subtract(x, y));
        Console.WriteLine(Division(x, y));
    }
}