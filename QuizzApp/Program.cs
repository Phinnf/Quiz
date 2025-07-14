namespace QuizzApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Question questions = new Question("What is the most profit vegetable in Stardew Valley",
                                 new string[] { "Strawberries", "Cauliflower", "Potatoes", "Green Beans" },
                                 1
            );

            Question[] arrayQuestion = { questions };

            Quiz myQuiz = new Quiz(arrayQuestion);
            myQuiz.DisplayQuestion(arrayQuestion[0]);
            Console.WriteLine("im do a bit of test");
        }
    }
}