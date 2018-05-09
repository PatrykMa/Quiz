using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using quiz.odd;

namespace quiz
{
    class LoadPresenter
    {
        Iquestions view;
        Models.LoadModel model;
        public LoadPresenter(Iquestions viev, Models.LoadModel model)
        {
            this.view = viev;
            this.model = model;
            view.loadDialog = model.loadDialog;
            view.Action += Firstaction;
            view.ActionText = model.actionText;
            view.ActionTextSecond = model.secondActionText;
            view.ActionSecond += secondAction;
            viev.Back += backward;
            view.Forward += forawrd;
            //view.openDialog();
        }

        void Firstaction(Object obj)
        {
            //view.openDialog();
            model.loadQuiz(view.path);
            displayQuestion(model.nextQuestion());
            view.ActionTextSecond = model.secondActionText;

        }

        Question CreteQuestion()
        {
            Question quest = new Question(view.Qtitle);
            quest.questionContent = view.QName;
            for (int i = 1; i < 5; i++)
            {
                quest.addAnswer(view.getQuestiontext(i), view.isAnswerCorect(i));
                Console.WriteLine(quest[i - 1]);
            }
            return quest;
        }

        void secondAction(Object obj)
        {
            model.setAnswers(CreteQuestion());
            try
            {
                view.info = model.checkAnswers();
            }
            catch
            {

            }
        }

        void displayQuestion(Question que)
        {
            view.Qtitle = que.questionContent;
            for (int i = 0; i < 4; i++)
            {
                view.setAnswerCorrect(i + 1, false);
                view.setQuestiontext(que[i].text, i + 1);
            }
        }

        void forawrd(Object obj)
        {
            model.setAnswers(CreteQuestion());
            displayQuestion(model.nextQuestion());
        }

        void backward(Object obj)
        {
            model.setAnswers(CreteQuestion());
            displayQuestion(model.nextQuestion());
        }




    }
}
