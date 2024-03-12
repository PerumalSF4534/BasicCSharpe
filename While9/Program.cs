using System;
namespace While;
class Program 
{
    public static void Main(string[] args)
    {
        int N=int.Parse(Console.ReadLine());
        int c=0;
        int num=2;
        int i=1;
        while(c!=1)
        {
                if(N<num)
                {
                    Console.WriteLine(num);
                    c=1;
                }
                else
                {
                    num=num*2;
                    i++;
                }

        }
    }
}