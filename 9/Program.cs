using System;
public class Program
{
    public static void Main()
    {
        Console.Write("Input the value for X coordinate : ");
        int x = Convert.ToInt16(Console.ReadLine());
        Console.Write("Input the value for Y coordinate : ");
        int y = Convert.ToInt16(Console.ReadLine());
        Console.WriteLine("The coordinate point ({0},{1}) lies in the First quadrant.", x, y);
    }
}