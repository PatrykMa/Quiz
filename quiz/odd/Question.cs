using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quiz.odd
{
    class Question
    {
		public List<Answer > answers;// lista odpowiedzi
        public string Title;// tresc pytania        
        public Question(string title)
        {
           Title=title;
        }
		public Answer this[int i]
        {
            get { return answers[i]; }
            set{answers[i]=value;}
        }

    }
	
	class Answer
	{
		public string answer;
		public bool isCorect;
		
		public Answer(string answer, bool corect)
		{
			this.answer=answer;
			isCorect=corect;
		}
		
	}
}
