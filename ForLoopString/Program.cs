﻿using System;

namespace ForLoopString
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Harry";

            for(int i = 5; i < name.Length; i++)
            {
                Console.WriteLine($"{i}. {name[i]}");
            }


        }
    }
}


