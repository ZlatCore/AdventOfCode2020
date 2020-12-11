using System;
using System.Collections.Generic;
using System.Text;

namespace dec_11
{
    class TaskSolver
    {
        private SeatingHall hall;
        public TaskSolver(string[] input)
        {
            this.hall = new SeatingHall(input);
        }

        public int CountStepsToBalance()
        {
            int result = 0;
            var hasChange = true;
            do
            {
                result++;
                hasChange = hall.DoStep();

            } while (hasChange);

            return result;
        }
    }
}
