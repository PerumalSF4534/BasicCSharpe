using System;
namespace DateTime8;

        public class Program
        {
            public static void Main(string[] args)
            {
                DateTime date1=DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy HH:mm:ss",null);
                DateTime date2=DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy HH:mm:ss",null);
                TimeSpan ts=date2-date1;
                Console.WriteLine(ts.TotalMinutes);
                int n=(int)ts.TotalMinutes;
                Console.WriteLine(n);
            }
        }