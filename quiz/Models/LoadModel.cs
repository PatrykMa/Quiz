using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using quiz.odd;
using System.IO;

namespace quiz.Models
{
    class LoadModel
    {

        Quizz quiz;
        Quizz answers;
        int actualQuestionNumber = 0;
        bool first = true;
        bool isInit = false;
        public bool loadDialog = true;

        public string actionText;
        public string secondActionText;

        public LoadModel()
        {
            actionText = "load";
            secondActionText = "";
            quiz = new Quizz("");
            answers = new Quizz("");
        }

        public void loadQuiz(string path)
        {
            using (StreamReader sr = new StreamReader(path))
            {
                // Read the stream to a string, and write the string to the console.
                String line = sr.ReadToEnd();
                quiz.deserialize(line);
                answers = new Quizz("");
                for (int i = 0; i < quiz.size(); i++)
                    answers.add(new Question(""));
            }
            isInit = true;
            secondActionText="End";
        }
        public void setAnswers(Question quest)
        {
            answers[actualQuestionNumber] = quest;
        }
        public Question nextQuestion()
        {
            if (isInit == false)
                return cleanQuestions();
            if (first)
            {
                first = false;
                return quiz[0];
            }
            actualQuestionNumber++;
            if (actualQuestionNumber >= quiz.size())
                actualQuestionNumber = 0;
            return quiz[actualQuestionNumber];
        }
        public Question previousQuestion()
        {
            if (isInit == false)
                return cleanQuestions();
            if (first)
            {
                first = false;
                return quiz[0];
            }
            actualQuestionNumber--;
            if (actualQuestionNumber <0)
                actualQuestionNumber = quiz.size()-1;
            return quiz[actualQuestionNumber];
        }

        public Question cleanQuestions()
        {
            Question temp = new Question("");
            for (int i = 0; i < 4; i++)
                temp.addAnswer("", false);
            return temp;


        }

        bool isAnswerCorrect(Question q1,Question q2)
        {
            if (q1.size() != q2.size())
                return false;
            for (int i = 0; i < q1.size(); i++)
                if (q1[i].isCorrect != q2[i].isCorrect)
                    return false;
            return true;
        }

        public string checkAnswers()
        {
            if (isInit == false)
                throw new Exception("nie ma quizu");
            isInit = false;
            first = false;
            secondActionText = "";
            int wynik=0;
            for(int i=0;i<quiz.size();i++)
            {
                if (isAnswerCorrect(quiz[i], answers[i]))
                    wynik++;
            }
            return "Twój wynik to " + wynik.ToString() + " na " + quiz.size().ToString();
        }


    }

}
