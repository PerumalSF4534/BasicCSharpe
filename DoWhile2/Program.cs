using System;
namespace Dowhile2;
class Program 
{
    public static void Main(string[] args)
    {
        int number=int.Parse(Console.ReadLine());
        int revNumber=0;
        do
        {
            int remainder=number%10;
            revNumber=revNumber*10+remainder;
            number=number/10;

        }while(number!=0);
        Console.WriteLine(revNumber);

    } 
}