﻿using System;
using System.Collections.Generic;

namespace WiredBrainCoffee.StackApp
{
    class Program
    {
        static void Main(string[] args)
        {
            StackDoubles();
            StackString();
            Console.ReadLine();
        }

        
        private static void StackDoubles()
        {
            var stack = new Stack<double>();
            stack.Push(1.2);
            stack.Push(2.8);
            stack.Push(3.0);
            // stack.Push("hi");
            double sum = 0.0;

            while (stack.Count > 0)
            {
                double item = stack.Pop();
                Console.WriteLine($"Item: {item}");
                sum += item;
            }
            Console.WriteLine($"Sum: {sum}");
        }

        private static void StackString()
        {
            var stack = new Stack<string>();
            stack.Push("Wired brain coffee");
            stack.Push("Pluralsight");

            while (stack.Count > 0)
            {
                string item = stack.Pop();
                Console.WriteLine($"Item: {item}");
            }
        }
    }
}
