using System;
namespace If11;
class Program 
{
    public static void Main(string[] args)
    {
        char choice1=char.Parse(Console.ReadLine());
        char choice2=char.Parse(Console.ReadLine());
        if(choice1=='P')
        {
            if(choice2=='R')
            {
                Console.WriteLine("winner: P");
            }
            else if(choice2=='S')
            {
                Console.WriteLine("winner: S");
            }
            else
            {
                Console.WriteLine("Draw");
            }
        }
        else if(choice1=='S')
        {
            if(choice2=='R')
            {
                Console.WriteLine("winner: R");
            }
            else if(choice2=='P')
            {
                Console.WriteLine("winner: S");
            }
            else
            {
                Console.WriteLine("Draw");
            }
        }
        else if(choice1=='R')
        {
            if(choice2=='P')
            {
                Console.WriteLine("winner: P");
            }
            else if(choice2=='S')
            {
                Console.WriteLine("winner: R");
            }
            else
            {
                Console.WriteLine("Draw");
            }
        }
    }
}