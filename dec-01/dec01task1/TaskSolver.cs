using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace dec01task1
{
    public class TaskSolver
    {
        int neededSum;
        List<int> expenseReport;

        public TaskSolver(int neededSum, int[] expenseReport)
        {
            this.neededSum = neededSum;
            this.expenseReport = expenseReport.ToList();
        }

        public int GetSolutionTask1()
        {
            return SolveTask1ForInput(this.neededSum, this.expenseReport);
        }

        public int GetSolutionTask2()
        {
            int result = 0;
            while (result == 0 && expenseReport.Count > 0)
            {
                var current = expenseReport.First();
                expenseReport = expenseReport.Skip(1).ToList();
                var searchingFor = this.neededSum - current;
                var medium = SolveTask1ForInput(searchingFor, expenseReport);
                if (medium != 0)
                {
                    result = current * medium;
                }
            }

            return result;
        }


        private int SolveTask1ForInput(int sum, List<int> numbers)
        {
            var tmpNumbers = numbers;

            int result = 0;
            while (result == 0 && tmpNumbers.Count > 0)
            {
                var current = tmpNumbers.First();
                tmpNumbers = tmpNumbers.Skip(1).ToList();
                var searchingFor = sum - current;
                var tmp = tmpNumbers.Where(x => x == searchingFor).FirstOrDefault();
                if (tmp != 0)
                {
                    Console.WriteLine($"Found 3 numbers: {sum}, {current}, {tmp}");
                    result = current * tmp;
                }
            }

            return result;
        }
    }
}
