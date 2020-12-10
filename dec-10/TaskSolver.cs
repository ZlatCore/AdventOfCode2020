using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace dec_10
{
    class TaskSolver
    {
        private int[] originalInput;
        private int[] sortedInput;
        public TaskSolver(int[] input)
        {
            this.originalInput = input;
            var tmp = input.OrderBy(x => x);
            var highest = tmp.Last();
            this.sortedInput = tmp.Prepend(0).Append(highest + 3).ToArray();
        }

        public (int, int) CountDifferencesBetweenEntries()
        {
            var diff1 = 0;
            var diff3 = 0;
            var currentValue = 0;
            for (int i = 0; i < this.sortedInput.Length; i++)
            {
                var diff = this.sortedInput[i] - currentValue;
                if (diff == 1)
                {
                    diff1++;
                }

                if (diff == 3)
                {
                    diff3++;
                }
                currentValue = this.sortedInput[i];
            }

            diff3++;
            return (diff1, diff3);
        }

        // Third and final idea for task 2. Works fast.
        public long FindRoadsVariation()
        {
            long[] results = new long[this.sortedInput.Length];
            for (int i = 0; i < results.Length; i++)
            {
                results[i] = 0;
            }

            results[0] = 1;

            for (int i = 0; i < results.Length; i++)
            {
                
                for (int j = 1; j < 4; j++)
                {
                    if (i + j < results.Length && this.sortedInput[i + j] - this.sortedInput[i] < 4)
                    {

                        results[i + j] += results[i];
                    }
                }
            }

            return results[results.Length - 1];
        }

        // First idea, doesn't work.
        public long CountVariations()
        {
            long result = 0;
            var interResults = new List<int>();
            result += this.sortedInput[1] - this.sortedInput[0] < 4 ? 1 : 0;
            result += this.sortedInput[2] - this.sortedInput[0] < 4 ? 1 : 0;
            result += this.sortedInput[2] - this.sortedInput[1] < 4 ? 1 : 0;
            for (int i = 3; i < this.sortedInput.Length; i++)
            {
                interResults.Add(this.GetInterNumber(this.sortedInput[i - 3], this.sortedInput[i - 2], this.sortedInput[i - 1], this.sortedInput[i]));
            }

            foreach (var res in interResults)
            {
                result *= res;
            }

            return result;
        }

        private int GetInterNumber(int n1, int n2, int n3, int n4)
        {
            var result = 0;
            result += n4 - n1 < 4 ? 1 : 0;
            result += n4 - n2 < 4 ? 1 : 0;
            result += n4 - n3 < 4 ? 1 : 0;
            return result;
        }

        // Second idea for task 2. Works but slow for large sets of data.
        public long CountVariationsRecursive()
        {
            return cvr(this.sortedInput.ToList());
        }

        private long cvr(List<int> inList)
        {
            if (inList.Count < 2)
            {
                return 1;
            }

            var currentNode = inList.First();
            inList.RemoveAt(0);
            var takeNext = true;
            int i = 0;
            long result = 0;
            do
            {
                var toCheckList = inList.Skip(i).ToList();
                var toCheck = toCheckList.FirstOrDefault();
                if (toCheck < 1)
                {
                    takeNext = false;
                }
                else 
                {
                    if (toCheck - currentNode < 4)
                    {
                        result += this.cvr(toCheckList);
                    }
                    else
                    {
                        takeNext = false;
                    }
                }
                i++;
            } while (takeNext);

            return result;
        }
    }
}
