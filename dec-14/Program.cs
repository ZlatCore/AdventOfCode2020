using System;

namespace dec_14
{
    class Program
    {
        static void Main(string[] args)
        {


            var ts = new TaskSolver(TestInput.GetInput());

            var result1 = ts.DoTask1();

            Console.WriteLine($"result1 is {result1}");

            var result2 = ts.DoTask2();

            Console.WriteLine($"result2 is {result2}");

        }
    }
}
