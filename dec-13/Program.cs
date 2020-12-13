using System;

namespace dec_13
{
    class Program
    {
        static void Main(string[] args)
        {
            var ts = new TaskSolver(TaskInput.GetInput());

            var result1 = ts.SolveTask1();

            Console.WriteLine($"result1 is: {result1}");

            var result2 = ts.SolveTask2();

            Console.WriteLine($"result1 is: {result2}");
        }
    }
}
