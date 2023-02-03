using System;
public class Program
{
    public static void Main()
    {
        double h, b;
        Console.WriteLine("Here are the options :\n1-Circle\n2-Square\n3-Triangle\n");
        Console.Write("Input your Choice : ");
        int choice = Convert.ToInt16(Console.ReadLine());
        if (choice == 1){
            Console.Write("Enter radius : ");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"The area of circle is : {b*b*3.14159}");
        }
        else if (choice == 2){
            Console.Write("Enter a  side : ");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"The area of square is : {b*b}");
        }
        else if (choice == 3){
            Console.Write("Enter height : ");
            h = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter Base : ");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"The area is : {h*b/2}");
        }
        else{
            Console.WriteLine("You have entered wrong number");
        }
    }
}