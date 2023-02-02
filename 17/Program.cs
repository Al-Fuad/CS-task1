using System;

public class Program
{
    public static void Main()
    {
        Console.Write("Enter buying price & selling price : ");
        var bs = Console.ReadLine().Split(' ');
        int buy = Convert.ToInt32(bs[0]), sell = Convert.ToInt32(bs[1]);
        if (sell-buy > 0){
            Console.WriteLine($"You can book your profit amount : {sell-buy}");
        }
        else if (sell-buy < 0){
            Console.WriteLine($"You can book your loss amount : {-(sell-buy)}");
        }
        else{
            Console.WriteLine("No profit or loss");
        }
    }
}