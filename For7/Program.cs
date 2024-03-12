using System;
namespace For7;
class Program
{
    public static void Main(string[] args)
    {
        int num=int.Parse(Console.ReadLine());
        double sum=0;
        for(double i=1;i<=num;i++)
        {
            sum=sum+(1/i);
           
        }
        Console.WriteLine(sum);
    }
}