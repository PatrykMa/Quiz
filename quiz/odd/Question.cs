using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quiz.odd
{
    class Question
    {
        public string question;
        public bool correct;
        public Question(string quest, bool corr)
        {
            question = quest;
            correct = corr;
        }

    }
}
