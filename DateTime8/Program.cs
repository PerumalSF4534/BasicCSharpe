using System;
namespace DateTime8;

        public class Program
        {
            public static void Main(string[] args)
            {
                int month=int.Parse(Console.ReadLine());
                int year=int.Parse(Console.ReadLine());
                int days=DateTime.DaysInMonth(year,month);
                int salary=days*500;
                Console.WriteLine(salary);
            }
        }