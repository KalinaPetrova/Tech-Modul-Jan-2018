﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _005_Compare_Char_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] firstArr = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(char.Parse)
                .ToArray();

            char[] secondArr = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(char.Parse)
                .ToArray();

            if (firstArr.Length==secondArr.Length)
            {
                if (firstArr[0]<secondArr[0])
                {
                    Console.WriteLine(String.Join("", firstArr));
                    Console.WriteLine(String.Join("", secondArr));
                }
                else
                {
                    Console.WriteLine(String.Join("", secondArr));
                    Console.WriteLine(String.Join("", firstArr));
                }
            }
            else if (firstArr.Length>secondArr.Length)
            {
                Console.WriteLine(String.Join("", secondArr));
                Console.WriteLine(String.Join("", firstArr));
            }
            else
            {
                Console.WriteLine(String.Join("", firstArr));
                Console.WriteLine(String.Join("", secondArr));
            }
        }
    }
}
