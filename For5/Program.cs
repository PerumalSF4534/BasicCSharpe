using System;
namespace For5;
class Program
{
    public static void Main(string[] args)
    {
        int count=0;
        int n=int.Parse(Console.ReadLine());
        for (int i=1;i<n;i++)
        {
            for (int j=0;j<n;j++)
            {
                if(i+j==n)
                {
                    count++;
                }
            }

        }
        Console.WriteLine(count);


    }
}