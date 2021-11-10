using System;


namespace Millionaire
{
    class HallHelp
    {
        private static Question Hallhelp;

        public static void Helper(Question question)
        {
            if (Hallhelp == null)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Hallhelp = question;

                Random random = new Random();
                int a = random.Next(40, 60);
                int b = random.Next(10, 20);
                int c = random.Next(10, 20);
                int d = 100 - a - b - c;
                for (int i = 0; i < question.answers.Length; i++)
                {
                    if (question.answers[0].AnswerOfQuestion == "" && question.answers[2].AnswerOfQuestion == "")
                    {
                        Console.WriteLine("2." + a + "%  4." + (100 - a) + "%");
                        break;
                    }
                    else if (question.answers[1].AnswerOfQuestion == "" && question.answers[3].AnswerOfQuestion == "")
                    {
                        Console.WriteLine("1." + a + "%  3." + (100 - a) + "%");
                        break;
                    }
                    else if (question.answers[i].Accuracy)
                    {

                        switch (i)
                        {
                            case 0:
                                Console.WriteLine("1." + a + "%  2." + b + "%  3." + c + "%  4." + d + "%");
                                break;
                            case 1:
                                Console.WriteLine("1." + b + "%  2." + a + "%  3." + c + "%  4." + d + "%");
                                break;
                            case 2:
                                Console.WriteLine("1." + c + "%  2." + b + "%  3." + a + "%  4." + d + "%");
                                break;
                            case 3:
                                Console.WriteLine("1." + d + "%  2." + b + "%  3." + c + "%  4." + a + "%");
                                break;
                            default:
                                break;
                        }

                    }
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("You have already used Hall help");
            }
            Console.ForegroundColor = ConsoleColor.White;

        }
    }
}
