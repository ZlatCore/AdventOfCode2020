using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace dec02task1
{
    public class TaskSolver
    {

        List<string> input;
        List<PasswordData> convertedInput;

        public TaskSolver(List<string> input)
        {
            this.input = input;
            this.convertedInput = this.input.Select(x => new PasswordData(x)).ToList();
        }

        public int GetValidPasswordsNumber()
        {
            return this.convertedInput.Count(x => x.IsValid);
        }
    }
}
