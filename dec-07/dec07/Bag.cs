using System;
using System.Collections.Generic;
using System.Text;

namespace dec07
{
    public class Bag
    {
        public string Name { get; set; }
        public List<ContainedBag> Contains { get; set; }

        public Bag(string input)
        {
            this.Contains = new List<ContainedBag>();
            var splitInput = input.Split(" contain ");
            this.Name = splitInput[0];
            this.Name = this.Name.Replace("bags", "bag");
            var containsString = splitInput[1].TrimEnd('.');
            if (containsString.StartsWith("no"))
            {
                return;
            }
            var contains = containsString.Split(", ");
            foreach (var cb in contains)
            {
                var tmp = cb.Split(new char[] { ' ' }, 2);
                int count = int.Parse(tmp[0]);
                var name = tmp[1];
                name = name.Replace("bags", "bag");
                this.Contains.Add(new ContainedBag() { Name = name, Count = count });
            }

        }
    }

    public class ContainedBag
    {
        public int Count { get; set; }
        public string Name { get; set; }
    }
}
