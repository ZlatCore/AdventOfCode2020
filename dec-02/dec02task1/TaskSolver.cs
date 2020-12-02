using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace dec02task1
{
    public class TaskSolver
    {
         List<PasswordData> convertedInput;

        public TaskSolver(List<string> input)
        {
            this.convertedInput = input.Select(x => new PasswordData(x)).ToList();
        }

        public (int, int) GetValidPasswordsNumber()
        {
            return (this.convertedInput.Count(x => x.IsValidOld), this.convertedInput.Count(x => x.IsValidNew));
        }
    }
}
