using System;
namespace Dowhile1;
class Program 
{
    public static void Main(string[] args)
    {
        int num=int.Parse(Console.ReadLine());
              int sum=0;
              do
              {
                int reminder=num%10;
                sum=sum+reminder;
                num=num/10;
              }while(num!=0);
              Console.WriteLine(sum);
    }
}