﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack stack = new Stack();
            Console.Write("0" + '>');
            string input="";
            int counter = 0;
            while (true)
            {
                counter++;
                input = Console.ReadLine();
                Console.WriteLine(Evaluate.Eval(input));
                Console.Write(counter.ToString() + '>');
                if (input == "exit") { break; }
            }
        }
    }
}
