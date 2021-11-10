using System;

namespace Millionaire
{
    public class Question
    {

        public string m_Question { get; set; }

        public Answer[] answers = new Answer[4];

        public Question(string question, Answer[] answers)
        {
            m_Question = question;
            this.answers = answers;
        }

        public void Print()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\t\t" + m_Question);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\n1." + answers[0].AnswerOfQuestion + "\t\t2." + answers[1].AnswerOfQuestion);
            Console.WriteLine("3." + answers[2].AnswerOfQuestion + "\t\t4." + answers[3].AnswerOfQuestion);

        }

        public static void Questions(Question[] questions)
        {
            Answer[] answers = new Answer[4];
            answers[0] = new Answer("Bill Gates", false);
            answers[1] = new Answer("Mark Zuckerberg", true);
            answers[2] = new Answer("Steve Jobs", false);
            answers[3] = new Answer("Elon Musk", false);
            questions[0] = new Question("Who invented facebook?", answers);
            answers = new Answer[4];
            answers[0] = new Answer("February 14, 1878", false);
            answers[1] = new Answer("February 14, 1879", false);
            answers[2] = new Answer("February 14, 1876", true);
            answers[3] = new Answer("February 14, 1870", false);
            questions[1] = new Question("When was invented telephone?", answers);
            answers = new Answer[4];
            answers[0] = new Answer("Italy", true);
            answers[1] = new Answer("France", false);
            answers[2] = new Answer("Spain", false);
            answers[3] = new Answer("Germany", false);
            questions[2] = new Question("Who win euro 2020?", answers);
            answers = new Answer[4];
            answers[0] = new Answer("Amerigo Vespucci", false);
            answers[1] = new Answer("Christopher Columbus", true);
            answers[2] = new Answer("Ferdinand Magellan", false);
            answers[3] = new Answer("Willem Janszoon", false);
            questions[3] = new Question("Who discovered america?", answers);
            answers = new Answer[4];
            answers[0] = new Answer("Delhi", false);
            answers[1] = new Answer("Jakarta", false);
            answers[2] = new Answer("Tokyo", true);
            answers[3] = new Answer("Manila", false);
            questions[4] = new Question("Which city has the most population?", answers);
            answers = new Answer[4];
            answers[0] = new Answer("Bjarne Stroustrup", false);
            answers[1] = new Answer("James Gosling", false);
            answers[2] = new Answer("Anders Hejlsberg ", true);
            answers[3] = new Answer("Brendan Eich", false);
            questions[5] = new Question("Who is the inventor of c#?", answers);
            answers = new Answer[4];
            answers[0] = new Answer("Yangtze", false);
            answers[1] = new Answer("Mississippi", false);
            answers[2] = new Answer("Amazon ", false);
            answers[3] = new Answer("Nile", true);
            questions[6] = new Question("Which is the longest river in the world?", answers);
            answers = new Answer[4];
            answers[0] = new Answer("October 1939  ", false);
            answers[1] = new Answer("September 1939", true);
            answers[2] = new Answer("September 1941", false);
            answers[3] = new Answer("October 1941", false);
            questions[7] = new Question("When world war 2 started?", answers);
            answers = new Answer[4];
            answers[0] = new Answer("Sipan ", false);
            answers[1] = new Answer("Ara", false);
            answers[2] = new Answer("Ararat", false);
            answers[3] = new Answer("Aragats", true);
            questions[8] = new Question("Which is the highest mountain in armenia?", answers);
            answers = new Answer[4];
            answers[0] = new Answer("Ernest Hemingway", false);
            answers[1] = new Answer("William Shakespeare", true);
            answers[2] = new Answer("Charles Dickens ", false);
            answers[3] = new Answer("Alexandre Duma", false);
            questions[9] = new Question("Who wrote Hamlet?", answers);

        }

        public static Question RandQuestion(ref Question[] questions)
        {
            Random r = new Random();
            Question question;


            int question_index = r.Next(0, questions.Length);
            question = questions[question_index];

            Question[] temp = new Question[questions.Length - 1];

            for (int j = 0; j < questions.Length; j++)
            {
                if (j < question_index)
                {
                    temp[j] = questions[j];
                }
                if (j > question_index)
                {
                    temp[j - 1] = questions[j];
                }
            }
            questions = temp;
            return question;
        }
    }
}