using System;
namespace While7;
class Program 
{
    public static void Main(string[] args)
    {
        double number=double.Parse(Console.ReadLine());
        double range=double.Parse(Console.ReadLine());
        int c=0;
        while(number>=0)
        {
            double lastDigit=number%10;
            if(range>=lastDigit)
            {
                number=number/10;
            }
            else
            {
                c=0;
                break;
             }
        }

        if(c==0)
        {
            Console.WriteLine("no");
        }
        else
        { 
            Console.WriteLine("yes");

        }
    }
}