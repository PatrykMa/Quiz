using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quiz
{
    interface Iquestions
    {

        bool loadDialog{get; set;}
        string info { set; }

        string getQuestiontext(int number);
        void setQuestiontext(string tresc,int number);
        void setAnswerCorrect(int number, bool checke);
        void setAnswerTextEditable(int numb, bool isEditable);

        bool isAnswerCorect(int number);
        string Qtitle { get; set; }
        string QName { get; set; }


        string ActionText { get;set;}
        string ActionTextSecond { get; set; }
        string path { get; set; }

        event Action<object> Action;
        event Action<object> ActionSecond;
        event Action<object> Back;
        event Action<object> Forward;




        

        event Action<object> Q1CheckClick;
        event Action<object> Q2CheckClick;
        event Action<object> Q3CheckClick;
        event Action<object> Q4CheckClick;
    }
}
