using System;

namespace dec_15
{
    class Program
    {
        static void Main(string[] args)
        {
            var ts = new TaskSolver(TaskInput.GetInput());

            var result1 = ts.GetElementAtPosition(2020);
            Console.WriteLine($"Result1 = {result1}");

            var result2 = ts.GetElementAtPosition(30000000);
            Console.WriteLine($"Result2 = {result2}");
        }
    }
}
