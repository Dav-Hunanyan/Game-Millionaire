using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Millionaire
{
    class HallHelp
    {
        private static Question Hallhelp;

        public static void hallhelp(Question question)
        {
            if (Hallhelp == null)
            {
                Hallhelp = question;
                Random random = new Random();
                int a = random.Next(40, 60);
                int b = random.Next(10, 20);
                int c = random.Next(10, 20);
                int d = 100 - a - b - c;
                for (int i = 0; i < question.answers.Length; i++)
                {
                    if (question.answers[i].Accuracy)
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

        }
    }
}
