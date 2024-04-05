using System;
namespace AssismentTest1;
class Program
{
    public static void Main(string[] args)
    {
        int number=int.Parse(Console.ReadLine());
        string input=Console.ReadLine();
        var price=input.Split(',');
        int min=int.Parse(price[0]);
        int c=0;
        for (int i=1;i<number;i++)
        {
            if(min>int.Parse(price[i]));
            {
                min=int.Parse(price[i]);
                c=i;
            }
        }
    
        Console.WriteLine(min);
        Console.WriteLine(c);
    }
}