using System;
namespace Dowhile6;
class Program 
{
    public static void Main(string[] args)
    {  /*
        int num=int.Parse(Console.ReadLine());
        double i=1;
        double sum=0;
        do
        {
            sum=sum+(1/i);
            i++;
        }while(i<=num);
        Console.WriteLine(sum);
         */
         int number=int.Parse(Console.ReadLine());
         do
         {
            
            int num=1;
            int temp=num;
            int sum=0;
            while(num!=0)
            {
                int rem=num%10;
                sum=sum+(rem*rem*rem);
                num=num/10;
            }
            num++;
            if(sum==temp)
            {
                Console.WriteLine(temp);
            }

         }while(number<500);
             
            
    }

}
