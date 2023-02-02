using System;

public class Program
{
    public static void Main()
    {
        Console.Write("Enter sides : ");
        var sides = Console.ReadLine().Split(' ');
        int side1 = Convert.ToInt32(sides[0]), side2 = Convert.ToInt32(sides[1]), side3 = Convert.ToInt32(sides[2]);
        if (side1==side2 && side2==side3){
            Console.WriteLine("This triangle is equilateral triangle");
        }
        else if (side1==side2 || side2==side3 || side1==side3){
            Console.WriteLine("This triangle is isosceles triangle");
        }
        else{
            Console.WriteLine("This triangle is scalene triangle");
        }
    }
}