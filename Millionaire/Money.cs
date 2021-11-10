
namespace Millionaire
{
    class Money_
    {
        public static int MoneyWin(int question_number)
        {
            int money = 0;
            switch (question_number)
            {
                case 1:
                    money = 100;
                    break;
                case 2:
                    money = 500;
                    break;
                case 3:
                    money = 2500;
                    break;
                case 4:
                    money = 10000;
                    break;
                case 5:
                    money = 25000;
                    break;
                case 6:
                    money = 50000;
                    break;
                case 7:
                    money = 100000;
                    break;
                case 8:
                    money = 250000;
                    break;
                case 9:
                    money = 500000;
                    break;
                case 10:
                    money = 1000000;
                    break;
                default:
                    break;
            }
            return money;
        }
    }
}
