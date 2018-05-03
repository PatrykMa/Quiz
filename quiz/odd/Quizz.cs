using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quiz.odd
{
    class Quizz
    {
        //int questionNUmber;
        string title;// nazwa quizu
        List<Question> quests;// lista pytan 

        public Quizz(string title)
        {
            this.title = title;
        }
        public Quizz(string title, List<Question> quest):this(title)
        {
            this.quests = quest;
        }

        public Question this[int i]
        {
            get { return quests[i]; }
            set{quests[i]=value;}
        }
        public void add(Question quest)
        {
            quests.Add(quest);
        }
        string parseToJSon()
        {
            return System.Object.Newtonsoft.JsonConvert.SerializeObject(this);
        }
    }



}
