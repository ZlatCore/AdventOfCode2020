using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace day08
{
    class TaskSolver
    {
        private string[] originalInput;

        public TaskSolver(string[] input)
        {
            this.originalInput = input;
        }

        public int FindAccumulatorOnSecondExecution()
        {
            int acc = 0;
            int i = 0;
            List<int> visitedLines = new List<int>();
            bool lineWouldRepeat = false;
            
            while (!lineWouldRepeat)
            {
                var tmp = this.originalInput[i].Split(" ");
                visitedLines.Add(i);
                if (tmp[0] == "acc")
                {
                    int change = int.Parse(tmp[1]);
                    acc += change;
                    i++;
                }
                else if (tmp[0] == "jmp")
                {
                    int jump = int.Parse(tmp[1]);
                    i += jump;
                }
                else
                {
                    i++;
                }

                lineWouldRepeat = visitedLines.Contains(i);
            }

            return acc;
        }

        public int FindFixedAccumulator()
        {
            //var result = this.TestChange(0, new int[] { }, 0);
            //return result.Item2;
            List<int> localVisited = new List<int>();
            var i = 0;
            bool lineWouldRepeat = localVisited.Contains(i);
            var acc = 0;
            while (!lineWouldRepeat)
            {
                var tmp = this.originalInput[i].Split(" ");
                localVisited.Add(i);
                if (tmp[0] == "acc")
                {
                    int change = int.Parse(tmp[1]);
                    acc += change;
                    i++;
                }
                else if (tmp[0] == "jmp")
                {
                    var iToTest = i + 1;
                    if (!localVisited.Contains(iToTest))
                    {
                        var testJumpToNop = this.TestChange(iToTest, localVisited.ToArray(), acc);
                        if (testJumpToNop.Item1)
                        {
                            return testJumpToNop.Item2;
                        }

                    }

                    int jump = int.Parse(tmp[1]);
                    i += jump;
                }
                else
                {
                    var iToTest = i + int.Parse(tmp[1]);
                    if (!localVisited.Contains(iToTest))
                    {
                        var testNopToJump = this.TestChange(iToTest, localVisited.ToArray(), acc);
                        if (testNopToJump.Item1)
                        {
                            return testNopToJump.Item2;
                        }
                    }

                    i++;
                }

                lineWouldRepeat = localVisited.Contains(i);
            }

            return acc;
        }

        private (bool, int) TestChange(int newI, int[] visited, int currentAcc)
        {
            List<int> localVisited = visited.ToList();
            var i = newI;
            bool lineWouldRepeat = localVisited.Contains(i);
            var acc = currentAcc;
            while (!lineWouldRepeat)
            {
                var tmp = this.originalInput[i].Split(" ");
                localVisited.Add(i);
                if (tmp[0] == "acc")
                {
                    int change = int.Parse(tmp[1]);
                    acc += change;
                    i++;
                }
                else if (tmp[0] == "jmp")
                {
                    int jump = int.Parse(tmp[1]);
                    i += jump;
                }
                else
                {
                    i++;
                }

                if (i == this.originalInput.Length)
                {
                    return (true, acc);
                }

                lineWouldRepeat = localVisited.Contains(i);
            }

            return (false, 0);
        }
    }
}
