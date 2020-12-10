using System;

namespace dec_10
{
    class Program
    {
        static void Main(string[] args)
        {

            var ts = new TaskSolver(TaskInput.GetTestInput2());

            var results = ts.CountDifferencesBetweenEntries();

            var result2 = ts.FindRoadsVariation();


           // Console.WriteLine($"Results are: {results.Item1}, {results.Item2} and multiplied they are {results.Item1 * results.Item2}");
            Console.WriteLine($"Number of variations: {result2}");
        }
    }
}
