﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3 };
            for (int i = 0; i<5; i++)
            {
                Console.WriteLine($"{i}번째 값 : {arr[i]}");
            }
        }
    }
}
