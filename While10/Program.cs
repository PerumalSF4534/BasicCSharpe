using System;
namespace While10;
class Program 
{
        public static void Main(string[] args)
        {
            int N=int.Parse(Console.ReadLine());
            if (N<0)
            {
                N=2;
            }
            int count=0;
            while(count!=3)
            {
                for(int i=N;i>=N;i++)
                {   int c=0;
                    if(count==3)
                    {
                        break;
                    }
                    else
                    {
                        for(int j=2;j<i;j++)
                        {
                            if(i%j==0)
                            {
                                c++;
                            }
                        }
                    
                        if (c==0)
                        {
                            Console.WriteLine(i);
                            count++;
                        }
                    }
                    
                }

            }
            
        }
}