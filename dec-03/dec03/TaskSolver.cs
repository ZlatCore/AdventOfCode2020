using System;
using System.Collections.Generic;
using System.Text;

namespace dec03
{
    public class TaskSolver
    {
        string[] input;

        public TaskSolver(string[] input)
        {
            this.input = input;
        }

        public int CountTreesFor(int down, int right)
        {
            int result = 0;
            int curDown = 0;
            int curRight = 0;
            while (curDown < this.input.Length)
            {
                if (this.input[curDown][curRight] == '#')
                {
                    result++;
                }

                curDown += down;
                curRight = (curRight + right) % this.input[0].Length;
            }

            return result;
        }
    }
}
