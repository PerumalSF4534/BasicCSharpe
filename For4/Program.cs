using System;
namespace For4;
class Program 
{
    public static void Main(string[] args)
    {
        
        int number=int.Parse(Console.ReadLine());
        double sum=0;
        for (double i=1;i<=7;i++)
        {
            sum=sum+((1/i)*(1/i));
        }
        Console.WriteLine(sum);
        
        
    }
}
