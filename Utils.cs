﻿using System;
using System.Collections.Generic;
using System.Text;

namespace GarageApp
{
    public static class Utils
    {
        public static void Print(this string str)
        {
            Console.WriteLine(str);
        }

        public static string ReadLine()
        {
            var input = Console.ReadLine();
            return input;
        }

        public static bool CheckForInput(string str)
            {
            return (String.IsNullOrEmpty(str) || String.IsNullOrWhiteSpace(str) )? true : false;
            }


    }
}
