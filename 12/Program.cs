using System;
public class Program
{
    public static void Main()
    {
        Console.Write("Input the Roll Number of the student : ");
        uint roll = Convert.ToUInt16(Console.ReadLine());
        Console.Write("Input the Name of the Student : ");
        string name = Convert.ToString(Console.ReadLine());
        Console.Write("Input the marks of Physics, Chemistry and Computer Application : ");
        var sub = Console.ReadLine().Split(' ');
        int s1 = Convert.ToInt16(sub[0]), s2 = Convert.ToInt16(sub[1]), s3 = Convert.ToInt16(sub[2]), total = s1 + s2 + s3;
        Console.WriteLine($"Roll No : {roll}\nName of Student : {name}\nMark in Physics : {s1}\nMark in Chemistry : {s2}\nMark in Computer Application : {s3}\nTotal Marks = {total}\nPercentage = {total / 3}%");

        if (total / 3 >= 80)
        {
            Console.WriteLine("Division = First");
        }
        else if (total / 3 >= 60)
        {
            Console.WriteLine("Division = Second");
        }
        else if (total / 3 >= 40)
        {
            Console.WriteLine("Division = Third");
        }
        else
        {
            Console.WriteLine("Division = Fail");
        }
    }
}