﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace string2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Kirjoita jotain: ");
            string userInput;
            userInput = Console.ReadLine();


            Console.WriteLine($"{userInput.Replace("e", "@")}");
            Console.ReadKey();
        }
    }
}
