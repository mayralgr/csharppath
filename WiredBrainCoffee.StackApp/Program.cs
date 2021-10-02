using System;

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
            var stack = new SimpleStack<double>();
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
            var stack = new SimpleStack<String>();
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
