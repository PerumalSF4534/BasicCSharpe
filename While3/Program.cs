﻿using System;
namespace While3;
class Program 
{
    public static void Main(string[] args)
    {
        int n1=0,n2=1,n3;
        int number=int.Parse(Console.ReadLine());
        Console.WriteLine(n1);
        Console.WriteLine(n2);
        for (int i=2;i<=number;i++)
        {
            n3=n1+n2;
            Console.WriteLine(n3);
            n1=n2;
            n2=n3;

        }
    }
}
