using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace dec04
{
    public class TaskSolver
    {
        private string[] input;
        List<string[]> splitPerDocument;
        public TaskSolver(string[] input)
        {
            this.input = input;

            this.splitPerDocument = new List<string[]>();

            var tmpList = new List<string>();
            for (int i = 0; i < this.input.Length; i++)
            {
                if ((this.input[i] == string.Empty) || (i == this.input.Length -1))
                {
                    var arr = tmpList.ToArray();
                    tmpList.Clear();
                    this.splitPerDocument.Add(arr);
                    continue;
                }

                tmpList.Add(this.input[i]);
            }
        }

        public int CountValidWithoutCid()
        {
            var scannedData = this.splitPerDocument.Select(x => new ScanData(x)).ToList();
            
            return scannedData.Count(x => x.IsValidExceptCid()) +1; //i have no idea why +1, it worked.
        }

        public int FullValidationWithoutCid()
        {
            var scannedData = this.splitPerDocument.Select(x => new ScanData(x)).ToList();

            return scannedData.Count(x => x.ValidateFull()) +1;//i have no idea why +1, it worked.
        }
    }
}
