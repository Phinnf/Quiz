namespace QuizzApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Question[] questions = new Question[]
            {
                new Question("What is the most profit vegetable in Stardew Valley",
                new string[] { "Strawberries", "Cauliflower", "Potatoes", "Green Beans" },
                0
                ),
                new Question("What is 1 + 1",
                ["1", "2", "5", "4" ],
                1
                )
            };
            Quiz myQuiz = new Quiz(questions);
            myQuiz.StartQuiz();
        }
    }
}