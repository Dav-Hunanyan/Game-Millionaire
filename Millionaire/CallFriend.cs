using System;

namespace Millionaire
{
    class CallFriend
    {
        private static Question question1;
        public static void Helper(Question question)
        {
            if (question1 == null)
            {
                question1 = question;
                Random random = new Random();
                Console.ForegroundColor = ConsoleColor.Cyan;
                if (question.answers[0].AnswerOfQuestion == "" && question.answers[2].AnswerOfQuestion == "")
                {
                    Console.WriteLine("Your friend think the right answer is " + question.answers[1].AnswerOfQuestion);
                }
                else if (question.answers[1].AnswerOfQuestion == "" && question.answers[3].AnswerOfQuestion == "")
                {
                    Console.WriteLine("Your friend think the right answer is " + question.answers[2].AnswerOfQuestion);
                }
                else
                {
                    Console.WriteLine("Your friend think the right answer is " + question.answers[random.Next(0, 3)].AnswerOfQuestion);
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("You have already used Call Friend");
            }
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
