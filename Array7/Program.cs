using System;
namespace Array7;
class Program 
{
    public static void Main(string[] args)
    {
        int input=int.Parse(Console.ReadLine());
        int row=input;
        int col=input;
        int[,] array1=new int[row,col];
        int[,] array2=new int[row,col];
        int[,] array3=new int[row,col];


        for(int i=0;i<row;i++)//get array 1
        {
            for(int j=0;j<col;j++)
            {
                array1[i,j]=Convert.ToInt32(Console.ReadLine());
            }
        }
        for(int i=0;i<row;i++)// get array2
        {
            for(int k=0;k<col;k++)
            {
                array2[i,k]=Convert.ToInt32(Console.ReadLine());
            }
        }

         for(int i=0;i<row;i++)// add two array
        {
            for(int j=0;j<col;j++)
            {
              array3[i,j]=array1[i,j]+array2[i,j];
            }
           
        }
        for(int i=0;i<row;i++)
        {
            for(int j=0;j<col;j++)
            {
                Console.Write(array3[i,j]+" ");
            }
            Console.WriteLine();

        }
    }
}