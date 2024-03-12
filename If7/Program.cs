using System;
namespace If7;
class Program 
{
    public static void Main(string[] args)
    {
        int number=int.Parse(Console.ReadLine());
        string[] numberName={"Zero","one","two","three","four","five","six","seven","eight","nine","ten","eleven","twelve","thirteen","fourteen", "fifteen","sixteen","seventeen","eighteen","nineteen"};
        string [] numberName1={"twenty","thirty","forty","fifty","sixty","seventy","eighty","ninety"};
        int rem=0;
        if(number==0)
        {
            Console.WriteLine("zero");
        }
        else if(number==100)
        {
            Console.WriteLine("hundread");
        }
        else if(number<20)
        {
            Console.WriteLine(numberName[number]);
        }
        else
        {
            rem=number%10;
            int num=number/10;
            if(rem==0)
            {
                Console.WriteLine(numberName1[num-2]);
            }
            else
            {
        
            Console.WriteLine($"{numberName1[num-2]} {numberName[rem]}");
            }
        }

    }
}