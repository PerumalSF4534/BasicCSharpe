using System;
namespace Array3;
class Program 
{
    public static void Main(string[] args)
    {
       /*  // to creat array and put input
        Console.WriteLine("Enter the number: ");
        int n=int.Parse(Console.ReadLine());
        int[] arr=new int[n];
        for(int i=0;i<arr.Length;i++)
        {
            int num=int.Parse(Console.ReadLine());
             arr[i]=num;
        }
        int sum=0;
        foreach(int a in arr)
        {
            sum=sum+a;
        }
        Console.WriteLine(sum);
            
                    int n=int.Parse(Console.ReadLine());
                    int[] arr=new int[n];
                    int max=arr[0];
                    // Creat Array and give  input
                    for(int i=0;i<n;i++)
                    {
                        int num=int.Parse(Console.ReadLine());
                        arr[i]=num;
                    }
                    int min=arr[0];
                    for (int i=0;i<n;i++)
                    {
                        if(arr[i]>=max)
                        {
                            max=arr[i];
                        }
                
                        else if(arr[i]<=min)
                        {
                            min=arr[i];
                        }
                    }
                    
                    Console.WriteLine("Maximun Element : "+max);
                    Console.WriteLine("Minimun Element : "+min);
                    */
                    int[]arr={-5,-10};
                    int max=arr[0];
                    for (int i=0;i<2;i++)
                    {
                        if(arr[i]>max)
                        {
                            max=arr[i];
                        }
                    }
                    Console.WriteLine(max);
                
            
    }
}