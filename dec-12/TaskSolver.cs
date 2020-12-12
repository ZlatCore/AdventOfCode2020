using System;
using System.Collections.Generic;
using System.Text;

namespace dec_12
{
    class TaskSolver
    {
        string[] originalInput;
        public TaskSolver(string[] input)
        {
            this.originalInput = input;
        }

        public int GetManhattanDistanceOfLastPosition()
        {
            var result = (0, 0);

            var sp = new ShipPosition();

            for (int i = 0; i < originalInput.Length; i++)
            {
                result = sp.MoveNext(this.originalInput[i]);
                Console.WriteLine(this.originalInput[i]);
                Console.WriteLine($"({result.Item1}, {result.Item2})");
                Console.WriteLine("===");
            }

            return Math.Abs(result.Item1) + Math.Abs(result.Item2);
        }

        public int GetWaypointShipDistance()
        {
            var result = (0, 0);

            var sw = new ShipWaypoint();

            for (int i = 0; i < originalInput.Length; i++)
            {
               sw.MoveNext(this.originalInput[i]);
            }

            result = sw.Position;
            return Math.Abs(result.Item1) + Math.Abs(result.Item2);
        }
    }
}
