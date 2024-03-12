using System;
namespace For9;
class Program 
{
    public static void Main(string[] args)
    {
        int row=int.Parse(Console.ReadLine()); //input row
        int len=1;
        int num=0;
        int space=row-1;
        do
        {
            for(int i=1;i<=row;i++)
        {
            for(int r=1;r<=space;r++)
            {
                Console.Write(" "); //print Space
            }
            for(int s=1;s<=len;s++)
            {
                Console.Write(num+i); //print *
            }
            space--;
            len+=2;
            Console.WriteLine();
        }

        }while(len<row);
    }
}
