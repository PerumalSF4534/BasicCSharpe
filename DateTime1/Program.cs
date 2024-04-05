using System;
namespace DateTime2;
class Program 
{
    public static void Main(string[] args)
    {
        DateTime date=DateTime.ParseExact(Console.ReadLine(),"yyyy/MM/dd ",null);
        Console.Write($"year = {date.Year}\n month = {date.Month}\n day = {date.Day} \n hour = {date.Hour}\n minute= {date.Minute}\n second ={date.Second}\nmillisecond = {date.Millisecond}");
    }

}