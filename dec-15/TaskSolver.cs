using System.Collections.Generic;

namespace dec_15
{
    internal class TaskSolver
    {
        private int[] starting;

        public TaskSolver(int[] input)
        {
            this.starting = input;
        }

        public int GetElementAtPosition(int positon)
        {
            var dict = new Dictionary<int, int>();

            for (int i = 1; i <= starting.Length; i++)
            {
                dict.Add(starting[i-1], i);
            }

            int nextMove = 0;
            for (int i = starting.Length+1; i < positon; i++)
            {
                var lastOccurence = -1;
                if (dict.TryGetValue(nextMove, out lastOccurence))
                {
                    dict[nextMove] = i;
                    nextMove = i - lastOccurence;
                }
                else
                {
                    dict[nextMove] = i;
                    nextMove = 0;
                }
            }

            return nextMove;
        }
    }
}