using System;
namespace DateTime8;

        public class Program
        {
            public static void Main(string[] args)
            {
                DateTime date1=DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy ",null);

                for(int i=0;i<12;i++)
                {
                    Console.WriteLine("{0}",date1.ToString("MMMM"));
                    date1=date1.AddMonths(1);
                }
            
            }
        }
