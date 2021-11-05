using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Millionaire
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Question[] questions = new Question[10];
            Question.Questions(questions);
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("              Who wants to be a millionaire");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("       Answer questions right and you will win million");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("If you don't know right answer you can use the help provided to you");
            Console.WriteLine("\n");
            int inviolable_money = 0;
            int Money = 0;
            int i = 1;
            
           
           
            while (questions.Length != 0)
            {
               
                int command = 0;
                Money = Money_.MoneyWin(i);

                if (Money_.MoneyWin(i - 1) == 10000)
                {
                    inviolable_money = 10000;
                }
                if (Money_.MoneyWin(i - 1) == 100000)
                {
                    inviolable_money = 100000;
                }
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine(i + " question.If you answer right you will win " + Money + "$\n");
                Question question = Question.RandQuestion(ref questions);
                QuestionPrint: Console.ForegroundColor = ConsoleColor.White;
                question.Print();
                Command: Console.Write("\n1.Answer  2.Help  3.Get inviolable money :  ");
                command = int.Parse(Console.ReadLine());
                switch (command)
                {
                    case 1:
                        RightAnswer: Console.Write("Enter right answer: ");
                        int right_answer = int.Parse(Console.ReadLine());
                        switch (right_answer)
                        {
                            case 1:
                            case 2:
                            case 3:
                            case 4:
                                if (question.answers[right_answer - 1].Accuracy)
                                {
                                    Console.ForegroundColor = ConsoleColor.Yellow;
                                    Console.WriteLine("\nRight answer.You win " + Money + "$.");
                                    if (Money == 10000)
                                    {
                                        Console.Write("It's inviolable\n");
                                    }
                                    if (Money == 100000)
                                    {
                                        Console.Write("It's inviolable\n");
                                    }
                                    if (Money == 1000000)
                                    {
                                        Console.WriteLine("Congratulations.You are Millionaire");
                                        Thread.Sleep(2000);
                                        return;
                                    }
                                    Thread.Sleep(2000);
                                }
                                else
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("Wrong answer");
                                    Console.ForegroundColor = ConsoleColor.White;
                                    if ((Money_.MoneyWin(i - 1) >= 10000 && (Money_.MoneyWin(i - 1) < 100000)))
                                    {
                                        Console.WriteLine("You have  inviolable " + inviolable_money + "$");
                                        Console.WriteLine("Thank you.You win " + inviolable_money + "$");
                                    }
                                    else if ((Money_.MoneyWin(i - 1) >= 100000))
                                    {
                                        Console.WriteLine("You have  inviolable " + inviolable_money + "$");
                                        Console.WriteLine("Thank you.You win " + inviolable_money + "$");
                                    }
                                    else
                                    {
                                        Console.WriteLine("You will win another time don't worry");
                                        Console.WriteLine("Thank you");                                       
                                    }
                                    Thread.Sleep(2000);
                                    return;
                                }
                                break;
                            default:
                                Console.WriteLine("You can choose only 4 answers");
                                goto RightAnswer;
                        }
                        break;
                    case 2:
                        Console.Write("1.50-50   2.Call friend  3.Hall help    :  ");
                        int help = int.Parse(Console.ReadLine());
                        switch (help)
                        {
                            case 1:
                                question = FiftyFifty.Fiftyfifty(question);
                                goto QuestionPrint;
                            case 2:
                                CallFriend.Callfriend(question);
                                goto Command;
                            case 3:
                                HallHelp.hallhelp(question);
                                goto Command;
                            default:
                                goto Command;
                        }
                        break;
                    case 3:
                        Console.WriteLine("You win " + inviolable_money + "$");
                        Thread.Sleep(3000);
                        return;

                    default:
                        Console.WriteLine("Wrong command.Try again");
                        goto Command;                       
                }
                i++;
                Console.Clear();
            }
        }
    }
}
