using System;
public class Program
{
    public static void Main()
    {
        Console.Write("Enter ID : ");
        int id = Convert.ToInt16(Console.ReadLine());
        double ac, bill, sa;
        Console.Write("Enter Name : ");
        string name = Convert.ToString(Console.ReadLine());
        Console.Write("Enter Unit : ");
        int unit = Convert.ToInt16(Console.ReadLine());
        if (unit < 200){
            ac = 1.20;
        }
        else if (unit < 400){
            ac = 1.50;
        }
        else if (unit < 600){
            ac = 1.80;
        }
        else{
            ac = 2;
        }
        bill = ac * unit; 
        if (bill > 400){
            sa = bill * 15 / 100;
        }
        else{
            sa = 0;
        }
        Console.WriteLine("Customer IDNO : {0}\nCustomer Name : {1}\nUnit Consumed : {2}\nAmount Change @Rs. {3} per unit : {4}.00\nSurcharge Amount : {5}.00\nNet Amount Paid By the Customer : {6}.00\n", id, name, unit, ac, bill, sa, sa+bill);
    }
}