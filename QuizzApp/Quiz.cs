using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizzApp
{
    internal class Quiz
    {
        private Question[] _questions;

        public Quiz(Question[] questions)
        {
            _questions = questions;
        }
        public void DisplayQuestion(Question question)
        {
            Console.WriteLine(question.QuestionText);
        }
    }
}
