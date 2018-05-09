using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using quiz.odd;

namespace quiz.presenters
{
    class SavePresenter
    {
        Iquestions viev;
        SaveModel model;
        public SavePresenter(Iquestions viev, SaveModel model)
        {
            this.viev = viev;
            viev.Action += saveQuiz;
            this.model = model;
            this.viev.Forward += forWard;
            this.viev.Back += backWard;
            viev.ActionText = model.actionText;
            viev.ActionTextSecond = model.secondActionText;
            viev.ActionSecond += secondAction;
            viev.loadDialog = model.loadDialog;


        }

        void secondAction(Object obj)
        {
            
            model.clearQuizz();
            displayQuestion(model.cleanQuestions());
            viev.QName = model.Title;

        }

        void saveQuiz(object obj)
        {
            model.Title=viev.Qtitle;
            try
            {
                model.addQuestion(CreteQuestion());
            }
            catch
            {

            }
            //viev.saveDialog();
            model.saveQiuz(viev.path);

        }

        Question CreteQuestion()
        {
            Question quest=new Question(viev.Qtitle);
            quest.questionContent = viev.QName;
            for (int i = 1; i < 5; i++)
            {
                quest.addAnswer(viev.getQuestiontext(i), viev.isAnswerCorect(i));
                Console.WriteLine(quest[i - 1]);
            }
            return quest;
        }
        void forWard(Object obj)
        {
            try
            {
                model.Title=viev.Qtitle;
                model.addQuestion(CreteQuestion());
                Question que = model.nextQuestion();
                displayQuestion(que);
            }
            catch { }
            
        }


        void makeQuiz(Object obj)
        {


            /*odd.Question pyt=new odd.Question("pyt1");
            pyt.addAnswer("pyt1odp1t", true);
            pyt.addAnswer("pyt1odp2f", false);
            odd.Question pyt2=new odd.Question("pyt2");
            pyt.addAnswer("pyt2odp1t", true);
            pyt.addAnswer("pyt2odp2f", false);
            quiz.odd.Quizz quiz = new odd.Quizz("tytuł");
            quiz.add(pyt);
            quiz.add(pyt2);
            viev.Qtitle = quiz.parseToJSon();*/
        }

        void displayQuestion(Question que)
        {
            viev.Qtitle = que.questionContent;
            for (int i = 0; i < 4; i++)
            {
                viev.setAnswerCorrect(i + 1, que[i].isCorrect);
                viev.setQuestiontext(que[i].text, i + 1);
            }
        }

        void backWard(Object obj)
        {
            try
            {
                model.addQuestion(this.CreteQuestion());
                
            }
            catch
            {
            }
            try
            {
                this.displayQuestion(model.previousQuestion());
            }
            catch { }
            


        }


    }
}
