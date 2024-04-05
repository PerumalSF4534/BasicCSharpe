using System;
namespace Array6;
class Program 
{
    public static void Main(string[] args)
    {/*
        int num=int.Parse(Console.ReadLine());
        int[] arr=new int[num];
        int temp=0;
        for(int i=0;i<num;i++)
        {
            arr[i]=int.Parse(Console.ReadLine());
        }
        for(int i=0;i<num;i++)
        {
            for(int j=i+1;j<num;j++)
            {
                if (arr[j]<arr[i])
                {
                    temp=arr[i];
                    arr[i]=arr[j];
                    arr[j]=temp;
                }
                
            }
        }
        for(int k=0;k<num;k++)
                {
                    Console.Write(arr[k]+ " ");
                }
                */
                int side1=int.Parse(Console.ReadLine());
               int side2=int.Parse(Console.ReadLine());
               int side3=int.Parse(Console.ReadLine());
                int x;
               if (side1>side2&&side1>side3)
               {
                 x=side1;
               }
               else if(side2>side1&&side2>side3)
               {
                x=side2;
               }
               else 
               {
                x=side3;
               }

                Console.WriteLine(x);
               int sumofTwoside=(side1+side2+side3)-x;

               if(sumofTwoside>x)
               {
                Console.WriteLine("yes");
               }
               else
               {
                Console.WriteLine("no");
               }
             
        }
}