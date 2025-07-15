namespace QuizzApp
{
    internal class Quiz
    {
        private Question[] _questions;
        private int _score;

        public Quiz(Question[] questions)
        {
            _questions = questions;
            _score = 0;
        }
        public void StartQuiz()
        {
            Console.WriteLine("Welcome to the Quiz");
            int questionNumber = 1;
            foreach (Question question in _questions)
            {
                Console.WriteLine($"Question {questionNumber++}: ");
                DisplayQuestion(question);
                int userChoice = GetUserChoice();
                if (question.IsCorrectAnswer(userChoice))
                {
                    Console.WriteLine("Correct!");
                    _score++;
                }
                else
                {
                    Console.WriteLine($"Wrong! The correct answer was: {question.Answers[question.CorrectAnswerIndex]}");
                }
            }
            DisplayResult();
        }
        private void DisplayResult()
        {

            Console.WriteLine($"Quiz finished. Your score is: {_score} out of {_questions.Length}");

            double percentage = (double)_score / _questions.Length;
            if (percentage >= 0.8)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Excelent Work!");
            } else if (percentage >= 0.5)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Good Effort");
            }
            else
            {
                Console.ForegroundColor= ConsoleColor.Red;
                Console.WriteLine("Keep practicing");
            }
            Console.ResetColor();
        }
        private void DisplayQuestion(Question question)
        {
            Console.WriteLine(question.QuestionText);
            for (int i = 0; i < question.Answers.Length; i++)
            {
                Console.ForegroundColor = ConsoleColor.Red; // change the text color
                Console.Write(" ");
                Console.Write(i + 1);
                Console.ResetColor(); // reset the text color to normal
                Console.WriteLine($". {question.Answers[i]}");

            }
        }

        private int GetUserChoice()
        {
            Console.WriteLine("Your answer (number): ");
            string userInput = Console.ReadLine();
            int choice = 0;
            while (!int.TryParse(userInput, out choice) || choice < 1 || choice > 4)
            {
                Console.WriteLine("Invalid choice. Please enter a valid number");
                userInput = Console.ReadLine();
            }
            return choice - 1;
        }
    }
}
