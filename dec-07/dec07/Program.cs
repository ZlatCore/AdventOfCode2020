using System;

namespace dec07
{
    class Program
    {
        static void Main(string[] args)
        {
            TaskSolver ts = new TaskSolver(TaskInput.GetInput());

            var result1 = ts.CountCanContain("shiny gold bag");

            Console.WriteLine($"Result1 is {result1}");

            var result2 = ts.CountBagsInside("shiny gold bag") -1; //minus one for our gold bag, it should not be counted.
            Console.WriteLine($"Result2 is {result2}");
        }
    }
}
