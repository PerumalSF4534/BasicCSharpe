using System;
namespace While1;
class Program 
{
    public static void Main(string[] args)
    {
        /*
        int n=int.Parse(Console.ReadLine());
        int rev=0;
        int rem;
        while(n!=0)
        {
            rem=n%10;
            rev=rev*10+rem;
            n=n/10;
        }
        Console.WriteLine(rev); */
        int n=int.Parse(Console.ReadLine());
        int s=10;
        while(s<n)
        {
            if (s%2==0)
            {
                Console.WriteLine(s);
            }
            s=s+5;
        }

    }
}