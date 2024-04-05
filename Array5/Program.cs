using System;
namespace Array5;
class Program 
{
    public static void Main(string[] args)
    {
        int num=int.Parse(Console.ReadLine());
        int [] arr=new int[num];
        int odd=0;
        int even=0;
        for (int i=0;i<num;i++)
        {

            int n=int.Parse(Console.ReadLine());
            if(n%2==0)
            {
                even++;
            }
            else
            {
               odd++;
            }
            arr[i]=n;
        }
        Console.WriteLine(odd);
       int[] oddArray=new int[odd];
        int[] evenArray=new int[even];
        
        foreach(int a in arr )
        {
        if(a%2==0)
        {    int i=0;
            evenArray[i]=a;
            i++;
        }
        else
        { int j=0;
            oddArray[j]=a;
        }
        }

        for (int i=0;i<odd;i++)
        {
        }
        for(int j=0;j<even;j++)
        {
            Console.Write("  "+evenArray[j]);
        }
        

    }
}