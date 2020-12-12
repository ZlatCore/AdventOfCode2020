using System;

namespace dec_12
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var ts = new TaskSolver(TaskInput.GetInput());

            var result = ts.GetManhattanDistanceOfLastPosition();

            var result2 = ts.GetWaypointShipDistance();

            Console.WriteLine($"Distance: {result}");
            Console.WriteLine($"Distance: {result2}");
        }
    }
}
