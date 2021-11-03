using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Millionaire
{
    class Answer
    {
        public string AnswerOfQuestion { get; set; }
        public bool Accuracy;
        public Answer(string answer, bool accuracy)
        {
            AnswerOfQuestion = answer;
            Accuracy = accuracy;
        }
    }
}
