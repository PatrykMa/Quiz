using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using quiz.odd;
using System.IO;

namespace quiz
{


    class SaveModel
    {
        Quizz quiz;
        int actualQuestionNumber = 0;
        public bool loadDialog = false;
        public string actionText;
        public string secondActionText;
        public SaveModel()
        {
            quiz = new Quizz("");
            actionText = "save";
            secondActionText = "new";
        }

        

        public Question nextQuestion()
        {

            actualQuestionNumber++;
            if (quiz.size() <= actualQuestionNumber)
                return this.cleanQuestions();
            return quiz[actualQuestionNumber];
        }

        bool isQuestionEmpty(Question quest)
        {
            // toDO wyciac spacje
            if (quest.questionContent == "")
                return true;
            for(int i=0;i<quest.size();i++)
            {
                if (quest[i].text != "")
                    return false;
            }
            return true;
        }

        public Question previousQuestion()
        {
            actualQuestionNumber--;
            if(actualQuestionNumber<0)
                actualQuestionNumber= quiz.size()-1;
            return quiz[actualQuestionNumber];
        }

        public  void saveQiuz(string path)
        {
            try
            {            
                if (File.Exists(path))
                {
                    // Note that no lock is put on the
                    // file and the possibility exists
                    // that another process could do
                    // something with it between
                    // the calls to Exists and Delete.
                    File.Delete(path);
                }

                // Create the file.
                using (FileStream fs = File.Create(path))
                {
                    Byte[] info = new UTF8Encoding(true).GetBytes(quiz.parseToJSon());
                    // Add some information to the file.
                    fs.Write(info, 0, info.Length);
                }

                // Open the stream and read it back.
                using (StreamReader sr = File.OpenText(path))
                {
                    string s = "";
                    while ((s = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(s);
                    }
                }
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

        }

        public string Title{
            get { return quiz.title; }
            set { quiz.title = value; }
        }
        

        public void addQuestion(Question quest)
        {
            if (isQuestionEmpty(quest))
                throw new Exception("bład pytania");

            if (actualQuestionNumber >= quiz.size())
                quiz.add(cleanQuestions());

            quiz[actualQuestionNumber] = quest;
        }

        public  string Json()
        {
            int a=1;
            
            return quiz.parseToJSon();
        }

        public Question cleanQuestions()
        {
           Question temp= new Question("");
           for (int i = 0; i < 4;i++ )
               temp.addAnswer("", false);
           return temp;
           
        }

        public void clearQuizz()
        {
            quiz = new Quizz("");

        }
        




    }
}
