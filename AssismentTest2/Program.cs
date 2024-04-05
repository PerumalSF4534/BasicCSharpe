using System;
namespace AssismentTest2;
class Program 
{
    public static void Main(string[] args)
    {
       string input=Console.ReadLine();
       var arr=input.Split(',');
       int sum=0;
        foreach(var a in arr)
        {
            sum=sum+int.Parse(a);
        }

        if(sum%2==0 &&sum%3==0 &&sum%5==0)
        {
            Console.WriteLine("Beatiful");

        }
        else
        {
            Console.WriteLine("not beautiful");
        }
    }


}