using System;
namespace For8;
class Program 
{
    public static void Main(string[] args)
    {
        int num=int.Parse(Console.ReadLine());
        int n=1;
        int sum=0;
        for(int i=0;i<num;i++)
        {
            sum=sum+n;
            n=(n*10)+1;
        }
        Console.WriteLine(sum);

    }
}