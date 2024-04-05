using System;
namespace AssismentTestE1;
        public class Program
        {
            public static void Main(string[] args)
            {
                int size=int.Parse(Console.ReadLine());
                string input=Console.ReadLine();
                var value=input.Split(',');
                if (size>5)
                
                {
                    int sum1=0;
                    int sum2=0;
                    for(int i=0;i<4;i++)
                    {
                        sum1=sum1+int.Parse(value[i]);
                    }
                    for(int i=size;i>size-3;i--)
                    {
                        sum2=sum2+int.Parse(value[i]);
                    }
                    if(sum1==sum2)
                    {
                        Console.WriteLine("1");
                    }
                    else
                    {
                        Console.WriteLine("0");
                    }

                }
                else
                {
                    Console.WriteLine("0");
                }
            }
        }
            