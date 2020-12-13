using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace dec_13
{
    class TaskSolver
    {
        private string[] originalInput;

        public TaskSolver(string[] input)
        {
            this.originalInput = input;
        }

        public int SolveTask1()
        {
            var goal = int.Parse(this.originalInput[0]);
            var lines = this.originalInput[1]
                .Replace("x", "")
                .Split(",", StringSplitOptions.RemoveEmptyEntries)
                .Select(x => int.Parse(x))
                .ToArray();


            var results = lines.Select(x => (x, this.FindSmallestDivisorGreaterThan(goal, x))).ToList();

            var result = results.Aggregate((min, next) => next.Item2 < min.Item2 ? next : min);

            return result.Item1 * (result.Item2 - goal);
        }

        public int FindSmallestDivisorGreaterThan(int min, int divisor)
        {
            var tmp = (min + divisor) % divisor;
            return tmp == 0 ? min : min + divisor - tmp;
        }

        public long SolveTask2()
        {
            var lines = this.originalInput[1]
                .Replace("x", "0")
                .Split(",", StringSplitOptions.RemoveEmptyEntries)
                .Select(x => int.Parse(x))
                .ToArray();

            List<long> lineIds = new List<long>();
            List<long> remains = new List<long>();
            for (int i = 0; i < lines.Length; i++)
            {
                if (lines[i] != 0)
                {
                    lineIds.Add(lines[i]);
                    var remain = i;
                    while (remain > 0)
                    {
                        remain -= lines[i];
                    }
                    remains.Add(Math.Abs(remain));
                }
            }

            var result = ChineseRemainderTheorem.Solve(lineIds.ToArray(), remains.ToArray());


            return result;
        }
    }
}
