using System;


namespace Millionaire
{
    class FiftyFifty
    {
        private static Question fiftyFifty;

        public static void Helper(Question question)
        {
            if (fiftyFifty == null)
            {

                if (question.answers[0].Accuracy == question.answers[2].Accuracy)
                {
                    question.answers[0].AnswerOfQuestion = "";
                    question.answers[2].AnswerOfQuestion = "";
                    fiftyFifty = new Question(question.m_Question, question.answers);
                }
                if (question.answers[1].Accuracy == question.answers[3].Accuracy)
                {
                    question.answers[1].AnswerOfQuestion = "";
                    question.answers[3].AnswerOfQuestion = "";
                    fiftyFifty = new Question(question.m_Question, question.answers);
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("You have already used 50-50");
            }

        }
    }
}
