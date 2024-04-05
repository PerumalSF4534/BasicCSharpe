using System;
namespace Array1;
class Program 
{
    public static void Main(string[] args)
    {
        // to creat array and put input
        Console.WriteLine("Enter the number: ");
        int n=int.Parse(Console.ReadLine());
        int[] arr=new int[n];
        for(int i=0;i<arr.Length;i++)
        {
            int num=int.Parse(Console.ReadLine());
             arr[i]=num;
        }
        foreach(int a in arr)
        {
            Console.Write($" "+a);
        }
        for(int i= arr.Length - 1;i>=0;i--)
        {
            Console.WriteLine(arr[i]);
        }
    }
}