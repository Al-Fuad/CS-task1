using System;

public class Program
{
    public static void Main()
    {
        int a, b, c;
        double d, x1, x2;
        Console.Write("Input the value of a : ");
        a = Convert.ToInt32(Console.ReadLine());
        Console.Write("Input the value of b : ");
        b = Convert.ToInt32(Console.ReadLine());
        Console.Write("Input the value of c : ");
        c = Convert.ToInt32(Console.ReadLine());

        d = b*b - 4*a*c;
        if (d == 0){
            x1 = -b/2/a;
            x2 = -b/2/a;
            Console.WriteLine("1st Root of Quadratic Equation : {0}",x1);
            Console.WriteLine("2nd Root of Quadratic Equation : {0}",x2);
        }
        else if (d > 0){
            x1 = (-b+Math.Sqrt(d))/2/a;
            x2 = (-b-Math.Sqrt(d))/2/a;
            Console.WriteLine("1st Root of Quadratic Equation : {0}",x1);
            Console.WriteLine("2nd Root of Quadratic Equation : {0}",x2);
        }
        else{
            Console.WriteLine("Root are imaginary;\nNo Solution.");
        }
    }
}