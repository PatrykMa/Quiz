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
        public event Action<object> Q1CheckClick;
        public event Action<object> Q2CheckClick;
        public event Action<object> Q3CheckClick;
        public event Action<object> Q4CheckClick;


        public Questions()
        {
            InitializeComponent();
            

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

        public event Action<object> ButtonActionClick;
        private void buttonSaveOpen_Click(object sender, EventArgs e)
        {
            if (ButtonActionClick != null)
            {
                ButtonActionClick(sender);
            }
        }

        public event Action<object> ButtonBackClick;
        private void ButtonBack_Click(object sender, EventArgs e)
           { 
            if (ButtonBackClick != null)
            {
                ButtonBackClick(sender);
            }
           }

        public event Action<object> ButtonForwardClick;
        private void ButtonForward_Click(object sender, EventArgs e)
        {
            if (ButtonForwardClick != null)
            {
                ButtonForwardClick(sender);
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

    }
}
