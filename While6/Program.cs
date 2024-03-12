using System;
namespace while6;
class Program
{
    public static void Main(string[] args)
    {
        int num=int.Parse(Console.ReadLine());
        
        int sum=0;
        while(num!=0)
        {
            int rem = num%10;
            if (rem%2!=0)
            {
                sum=sum+rem;

            }
            num=num/10;
        }
        if (sum%2==0)
        {
            Console.WriteLine("Even");
        
        }
        else{
            Console.WriteLine("Odd");
        }
        
     
        
    }
}