﻿using System;
namespace If3;
class Program 
{
    public static void Main(string[] args)
    {
        int speed=int.Parse(Console.ReadLine());
               if (speed<=10)
               {
                Console.WriteLine("slow");
               }
               else if(speed>=30 &&speed<=50)
               {
                Console.WriteLine("average");
               }
               else if (speed>50 && speed<=150)
               {
                Console.WriteLine("fast");
               }
               else if (speed>150 &&speed<=1000)
               {
                Console.WriteLine("ultra fast");

               }
               else if(speed>1000)
               {
                Console.WriteLine("extremely fast");
               }
            
    }
}