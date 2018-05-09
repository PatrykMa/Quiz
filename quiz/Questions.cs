using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quiz
{
    public partial class Questions : UserControl, Iquestions
    {

        // are not use
        string _path;
        public event Action<object> Q1CheckClick;
        public event Action<object> Q2CheckClick;
        public event Action<object> Q3CheckClick;
        public event Action<object> Q4CheckClick;

        bool _dialogmode=false;
        public bool loadDialog{
            get{
                return _dialogmode;
            }
            set{
                _dialogmode=value;
            }
        }

        public void setQuestiontext(string tresc,int number)
        {
            if(number == 1)
            {
                this.textBoxAnswer1.Text = tresc;
            }
            if (number == 2)
            {
                this.textBoxAnswer2.Text = tresc;
            }
            if (number == 3)
            {
                this.textBoxAnswer3.Text = tresc;
            }
            if (number == 4)
            {
                this.textBoxAnswer4.Text = tresc;
            }

        }

        public string getQuestiontext(int number)
        {
            if(number == 1)
            {
                return this.textBoxAnswer1.Text;
            }
            if (number == 2)
            {
                return this.textBoxAnswer2.Text;
            }
            if (number == 3)
            {
                return this.textBoxAnswer3.Text;
            }
            if (number == 4)
            {
                return this.textBoxAnswer4.Text;
            }
            //ToDo Wyjatek
            return "";

        }
        public bool isAnswerCorect(int number)
        {
            if (number == 1)
                return this.checkBoxAnswer1.Checked;
            if (number == 2)
                return this.checkBoxAnswer2.Checked;
            if (number == 3)
                return this.checkBoxAnswer3.Checked;
            if (number == 4)
                return this.checkBoxAnswer4.Checked;
            return false;
        }
        public void setAnswerTextEditable(int number, bool isEditable)
        {
            if (number == 1)
            {
                this.textBoxAnswer1.Enabled = isEditable;
            }
            if (number == 2)
            {
                this.textBoxAnswer2.Enabled = isEditable;
            }
            if (number == 3)
            {
                this.textBoxAnswer3.Enabled = isEditable;
            }
            if (number == 4)
            {
                this.textBoxAnswer4.Enabled = isEditable;
            }

        }


        public void setAnswerCorrect(int number,bool checke)
        {
            if (number == 1)
                this.checkBoxAnswer1.Checked=checke;
            if (number == 2)
                 this.checkBoxAnswer2.Checked=checke;
            if (number == 3)
                 this.checkBoxAnswer3.Checked=checke;
            if (number == 4)
                 this.checkBoxAnswer4.Checked=checke;
            
        }

        public string info
        {
            set{
                this.QName = value;
            }
        }
        public Questions()
        {
            InitializeComponent();
            saveFileDialog1.FileOk += (sender, e) => saveFileDialog1.Dispose();
            saveFileDialog1.FileOk += (sender, e) => e.Cancel=true;
            saveFileDialog1.FileOk += (sender, e) => saveFileDialog1.Dispose();
            saveFileDialog1.FileOk += (sender, e) => e.Cancel=false;



        }

        public string Q1text
        {
            get{ return textBoxAnswer1.Text;}
            set { textBoxAnswer1.Text = value; }
        }
        public string Q2text
        {
            get {return textBoxAnswer2.Text;}
            set{ textBoxAnswer2.Text = value;}
        }
        public string Q3text
        {
            get { return textBoxAnswer3.Text; }
            set { textBoxAnswer3.Text = value; }
        }
        public string Q4text
        {
            get { return textBoxAnswer4.Text; }
            set { textBoxAnswer4.Text = value;}
        }
        public string QName
        {
            get {return textBoxQname.Text;}
            set { textBoxQname.Text = value;}
        }
        public string Qtitle
        {
            get{ return textBoxQuestion.Text;}
            set { textBoxQuestion.Text = value; }
        }
        public string path
        {
            get { return _path; }
            set { _path = value; }
        }

        public event Action<object> Action;
        private void buttonSaveOpen_Click(object sender, EventArgs e)
        {
            if (!this.loadDialog)
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    _path = saveFileDialog1.FileName;
                    this.textBoxAnswer1.Text = path;
                }
            }
            else
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    _path = openFileDialog1.FileName;
                    this.textBoxAnswer1.Text = path;

                }

            }

            if (Action != null)
            {
                Action(sender);
            }
        }

               

        public event Action<object> Back;
        private void ButtonBack_Click(object sender, EventArgs e)
           { 
            if (Back != null)
            {
                Back(sender);
            }
           }

        public event Action<object> Forward;
        private void ButtonForward_Click(object sender, EventArgs e)
        {
            if (Forward != null)
            {
                Forward(sender);
            }
        }
        public bool Q1Check {
            get{return checkBoxAnswer1.Checked;}
            set { checkBoxAnswer1.Checked = value; }
        }
        public bool Q2Check
        {
            get { return checkBoxAnswer2.Checked; }
            set { checkBoxAnswer2.Checked = value; }
        }
        public bool Q3Check
        {
            get { return checkBoxAnswer2.Checked; }
            set { checkBoxAnswer2.Checked = value; }
        }
        public bool Q4Check
        {
            get { return checkBoxAnswer4.Checked; }
            set { checkBoxAnswer4.Checked = value; }
        }
        public string ActionText { 
            get{return this.buttonSaveOpen.Text;}
            set { this.buttonSaveOpen.Text = value; }
            }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        public string ActionTextSecond
        {
            get{
               return  this.buttonAction2.Text;
            }
            set {
                this.buttonAction2.Text = value;
            }
        }

        public event Action<object> ActionSecond;
        private void buttonAction2_Click(object sender, EventArgs e)
        {
            if(ActionSecond!=null)
            {
                ActionSecond(sender);
            }

        }

    }
}
