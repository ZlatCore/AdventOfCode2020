using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace dec_14
{
    class TaskSolver
    {
        private string[] originalInput;
        private string currentMask;
        private Dictionary<string, long> values;
        private Dictionary<long, long> values2;

        public TaskSolver(string[] input)
        {
            this.originalInput = input;
            currentMask = string.Empty;
            values = new Dictionary<string, long>();
            values2 = new Dictionary<long, long>();
        }

        public long DoTask1()
        {
            for (int i = 0; i < originalInput.Length; i++)
            {
                if (originalInput[i].StartsWith("mask"))
                {
                    var tmp = originalInput[i].Split(" = ");
                    this.currentMask = tmp[1];
                    continue;
                }

                this.ApplyMaskAndSet(originalInput[i]);
            }

            long result = 0;
            foreach (var item in values.Values)
            {
                result += item;
            }

            return result;
        }

        public void ApplyMaskAndSet(string input)
        {
            var tmp = input.Split(" = ");

            var bs = Util.ToBinaryString(long.Parse(tmp[1])).ToCharArray();

            for (int i = 0; i < currentMask.Length; i++)
            {
                if (char.IsDigit(currentMask[i]))
                {
                    bs[i] = currentMask[i];
                }
            }

            var result = Util.FromCharArray(bs);

            this.values[tmp[0]] = result;
        }

        public long DoTask2()
        {
            for (int i = 0; i < originalInput.Length; i++)
            {
                if (originalInput[i].StartsWith("mask"))
                {
                    var tmp = originalInput[i].Split(" = ");
                    this.currentMask = tmp[1];
                    continue;
                }

                this.ApplyMaskV2(originalInput[i]);
            }

            long result = 0;
            foreach (var item in values2.Values)
            {
                result += item;
            }

            return result;
        }

        void ApplyMaskV2(string input)
        {
            var tmp = input.Split(" = ");
            var rootNum = Util.ToBinaryString(Int64.Parse(new string(tmp[0].Skip(4).SkipLast(1).ToArray()))).ToCharArray();
            var writeValue = Int64.Parse(tmp[1]);

            for (int i = 0; i < currentMask.Length; i++)
            {
                if (currentMask[i] != '0')
                {
                    rootNum[i] = currentMask[i];
                }
            }

            var variations = GetAllVariations(rootNum);
            var indexes = variations.Select(x => Util.FromBinaryString(x)).ToList();

            foreach (var index in indexes)
            {
                values2[index] = writeValue;
            }
        }

        string[] GetAllVariations(char[] input)
        {
            List<char[]> currentList = new List<char[]>();
            currentList.Add(input);

            for (int i = 0; i < input.Length; i++)
            {
                if (char.IsLetter(input[i]))
                {
                    List<char[]> newList = new List<char[]>();

                    foreach (var item in currentList)
                    {
                        var w0 = new char[36];
                        var w1 = new char[36];
                        Array.Copy(item, w0, 36);
                        Array.Copy(item, w1, 36);
                        w0[i] = '0';
                        w1[i] = '1';

                        newList.Add(w0);
                        newList.Add(w1);
                    }

                    currentList.Clear();
                    currentList = newList;
                }
            }

            return currentList.Select(x => new string(x)).ToArray();

        }
    }
}
