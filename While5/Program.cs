using System;
namespace While5;

        public class Program
        {
            public static void Main(string[] args)
            {
                int n1=int.Parse(Console.ReadLine());
                int n2=int.Parse(Console.ReadLine());
                while(n1!=n2)
                { 
                    if(n1>n2)
                    {
                        n1=n1-n2;
                    }
                    else
                    {
                        n2=n2-n1;
                    }

                }

               
                Console.WriteLine(n1);
            }
        }