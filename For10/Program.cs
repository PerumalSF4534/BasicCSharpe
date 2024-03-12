using System;
namespace For9;
class Program 
{
    public static void Main(string[] args)
    {
        int row=int.Parse(Console.ReadLine()); //input row
        int num=0;
        for(int i=1;i<=row;i++)
        {
            for(int c=1;c<=i;c++)
            {
                Console.Write(num+1);
            }
            Console.WriteLine();
            num++;
        }
    }
}