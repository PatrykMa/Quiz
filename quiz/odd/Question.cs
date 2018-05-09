using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quiz.odd
{
    class Question
    {
        public string questionContent;//tresc pytania
        public List<odd.Answer> answers;

        public Question(string quest)
        {
            answers = new List<odd.Answer>();
            questionContent = quest;
            
        }
        public int size()
        {
            return answers.Count;
        }
        public void addAnswer(odd.Answer odp)
        {
            answers.Add(odp);
        }
        public void addAnswer(string content, bool iscorect)
        {
            answers.Add(new odd.Answer(content,iscorect));
        }
        public Answer this[int i]
        {
            get
            {
                return this.answers[i];
            }
            set { this.answers[i]=value; }
        }

    }
}
