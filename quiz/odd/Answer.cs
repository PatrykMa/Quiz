using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quiz.odd
{
    class Answer
    {
        public string text;
        public bool isCorrect;
        public Answer(string text, bool corect)
        {
            this.text = text;
            isCorrect = corect;
        }
    }
}
