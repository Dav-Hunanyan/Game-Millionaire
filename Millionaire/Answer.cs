namespace Millionaire
{
    public class Answer
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
