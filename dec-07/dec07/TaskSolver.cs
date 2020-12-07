using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace dec07
{
    public class TaskSolver
    {
        string[] originalInput;
        List<Bag> BagList;
        public TaskSolver(string[] input)
        {
            this.originalInput = input;
            this.BagList = input.Select(x => new Bag(x)).ToList();
        }

        public int CountCanContain(string bagName)
        {
            var alreadyChecked = new List<string>();
            var toCheckNext = new Queue<string>();

            var directHolders = this.GetDirectHolderFor(bagName);

            foreach (var bag in directHolders)
            {
                toCheckNext.Enqueue(bag);
            }

            while (toCheckNext.Count > 0)
            {
                var bagToCheck = toCheckNext.Dequeue();
                if (alreadyChecked.Contains(bagToCheck))
                {
                    continue;
                }

                alreadyChecked.Add(bagToCheck);

                var indirectHolders = this.GetDirectHolderFor(bagToCheck);
                foreach (var ih in indirectHolders)
                {
                    toCheckNext.Enqueue(ih);
                }
            }

            return alreadyChecked.Count();
        }

        public int CountBagsInside(string bagToCheck)
        {
            int result = 1;
            var bag = this.BagList.Find(x => x.Name == bagToCheck);
            if (bag != null)
            {
                foreach (var cb in bag.Contains)
                {
                    result += cb.Count * this.CountBagsInside(cb.Name);
                }
            }

            return result;
        }

        private List<string> GetDirectHolderFor(string bagName)
        {
            return this.BagList.Where(x => x.Contains.Any(c => c.Name == bagName)).Select(x => x.Name).ToList();
        }
    }
}
