using System;

namespace dec_11
{
    class Program
    {
        static void Main(string[] args)
        {
            var ts = new TaskSolver(TaskInput.GetInput());

            var count = ts.CountStepsToBalance();

            // i have no clue why i was counting steps when it is not important.
            // There is a writeline in code that gives me correct information about taken seats.
            Console.WriteLine($"StepsCount = {count}");



        }
    }
}
