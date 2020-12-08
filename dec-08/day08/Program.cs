using System;

namespace day08
{
    class Program
    {
        static void Main(string[] args)
        {
            var ts = new TaskSolver(TaskInput.GetInput());

            var result = ts.FindAccumulatorOnSecondExecution();

            Console.WriteLine($"result is: {result}");

            var result2 = ts.FindFixedAccumulator();
            Console.WriteLine($"result2 is: {result2}");
        }
    }
}
