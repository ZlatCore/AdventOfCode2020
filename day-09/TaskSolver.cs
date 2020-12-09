using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace day_09
{
    class TaskSolver
    {
        string[] originalInput;
        int toCheck;
        long[] actualInput;
        public TaskSolver(int preamble, string[] input)
        {
            this.toCheck = preamble;
            this.originalInput = input;
            this.actualInput = input.Select(x => long.Parse(x)).ToArray();
        }

        public long GetFirstThatIsNotCorrect()
        {
            int toSkip = this.toCheck;
            while (toSkip < this.actualInput.Length - 1)
            {
                long checkingNumber = this.actualInput.Skip(toSkip).First();
                var arrToCheck = this.actualInput.Skip(toSkip - this.toCheck).Take(toCheck).ToArray();
                if (!this.HasSum(checkingNumber, arrToCheck))
                {
                    return checkingNumber;
                }
                toSkip++;
            }

            return 0;
        }

        public long FindWeaknessForNumber(long lookingFor)
        {
            LinkedList<long> checkingNumbers = new LinkedList<long>();

            for (int i = 0; i < this.actualInput.Length; i++)
            {
                if (checkingNumbers.Count < 2)
                {
                    checkingNumbers.AddLast(this.actualInput[i]);
                    continue;
                }

                var sum = checkingNumbers.Sum();
                while (sum > lookingFor)
                {
                    checkingNumbers.RemoveFirst();
                    sum = checkingNumbers.Sum();
                    var a = sum;
                }

                if (sum == lookingFor)
                {
                    return this.GetWeakness(checkingNumbers.ToList());
                }

                checkingNumbers.AddLast(this.actualInput[i]);
            }

            return 0;
        }

        private long GetWeakness(List<long> fromNumbers)
        {
            var ordered = fromNumbers.OrderBy(x => x);
            return ordered.First() + ordered.Last();
        }

        private bool HasSum(long sum, long[] arr)
        {
            var lookup = new HashSet<long>();
            for (int i = 0; i < arr.Length; i++)
            {
                if (lookup.Contains(sum - arr[i]))
                {
                    return true;
                }

                lookup.Add(arr[i]);
            }

            return false;
        }
    }
}
