using System;
namespace DateTime4;
class Program 
{
    public static void Main(string[] args)
    {
       DateTime d1=DateTime.ParseExact(Console.ReadLine(),"MM/dd/yyyy",null);
       DateTime d2=DateTime.ParseExact(Console.ReadLine(),"MM/dd/yyyy",null);
       int n=(d2-d1).Days;
       Console.WriteLine(n);
       
    }
}