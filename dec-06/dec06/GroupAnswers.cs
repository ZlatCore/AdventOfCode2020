using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace dec06
{
    public class GroupAnswers
    {
        public string[] originalInput;

        public List<AnswerCount> Answers { get; set; }

        public GroupAnswers(string[] input)
        {
            this.originalInput = input;
            var answersMerged = string.Join("", input);

            this.Answers = answersMerged.GroupBy(c => c).Select(x => new AnswerCount(x.Key, x.Count())).ToList();
        }
    }

    public class AnswerCount
    {
        public char Answer { get; private set; }
        public int Count { get; private set; }

        public AnswerCount(char c, int count)
        {
            this.Answer = c;
            this.Count = count;
        }
    }
}
