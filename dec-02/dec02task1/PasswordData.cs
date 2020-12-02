using System;
using System.Collections.Generic;
using System.Text;

namespace dec02task1
{
    public class PasswordData
    {
        public int LowerLimit { get; private set; }
        public int UpperLimit { get; private set; }
        public char RequiredChar { get; private set; }
        public string Password { get; private set; }

        public bool IsValidOld { get; private set; }
        public bool IsValidNew { get; private set; }

        public PasswordData(string dataString)
        {
            var tmp = dataString.Split(" ");
            this.Password = tmp[2];
            this.RequiredChar = tmp[1][0];
            var limits = tmp[0].Split("-");
            this.LowerLimit = int.Parse(limits[0]);
            this.UpperLimit = int.Parse(limits[1]);

            var tmpCount = 0;
            foreach (var s in this.Password)
            {
                if (s == this.RequiredChar)
                {
                    tmpCount++;
                }
            }

            this.IsValidOld = tmpCount >= this.LowerLimit && tmpCount <= this.UpperLimit;
            this.IsValidNew = (this.Password[this.LowerLimit - 1] == this.RequiredChar) != (this.Password[this.UpperLimit - 1] == this.RequiredChar);
        }
    }
}
