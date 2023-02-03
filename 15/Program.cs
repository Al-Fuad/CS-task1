using System;
public class Program
{
    public static void Main()
    {
        Console.Write("Enter Angles of Triangle : ");
        var angles = Console.ReadLine().Split(' ');
        int angle1 = Convert.ToInt32(angles[0]), angle2 = Convert.ToInt32(angles[1]), angle3 = Convert.ToInt32(angles[2]);
        if (angle1+angle2+angle3 == 180)
        {
            Console.Write("The triangle is valid.\n");
        }
        else
        {
            Console.Write("The triangle is not valid.\n");
        }
    }
}