using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quiz.odd
{
    class Quizz
    {     
        public string title;
        public List<Question> quests;

        public int size()
        {
            return quests.Count;
        }

        public Quizz(string title)
        {
            quests = new List<Question>();
            this.title = title;
        }
        public Quizz()
        {
            quests = new List<Question>();           
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
        public string parseToJSon()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }
        public void deserialize(string Json)
        {
            Quizz temp = new Quizz("");
            temp = Newtonsoft.Json.JsonConvert.DeserializeObject<Quizz>(Json);
            this.quests = temp.quests;
            this.title = temp.title;
        }
    }



}
