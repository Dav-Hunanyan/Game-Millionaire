using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Millionaire
{
    class CallFriend
    {
        private static Question question1;
        public static void Callfriend(Question question)
        {
            if (question1 == null)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (question.answers[j].Accuracy)
                    {
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Your friend think the right answer is " + question.answers[j].AnswerOfQuestion);

                    }
                }
            }
        }
    }
}
