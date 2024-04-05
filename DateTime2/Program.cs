using System;
namespace DateTime1;
class Program 
{
    public static void Main(string[] args)
    {
        DateTime date=DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy",null);
        DateTime newDate=date.AddYears(15);
        string dayofweeek=DateTime.ToLongDateString(date);

        Console.WriteLine(newDate.ToString("dd/MM/yyy"));
        Console.WriteLine(newDate.DayOfWeek);
    }
}
