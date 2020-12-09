using System;

namespace day_09
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var input = TaskInput.GetInput();
            TaskSolver ts = new TaskSolver(input.Item1, input.Item2);

            var result1 = ts.GetFirstThatIsNotCorrect();

            var result2 = ts.FindWeaknessForNumber(result1);

            Console.WriteLine($"Result1 is: {result1}");

            Console.WriteLine($"Result2 is: {result2}");
        }
    }
}
