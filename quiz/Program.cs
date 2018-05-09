using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using quiz.presenters;

namespace quiz
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Viev viu=new Viev();
            //TODO poprawic to xd przeca to tak nie moze byc
            
            quiz.Models.LoadModel loadmodel = new Models.LoadModel();
            LoadPresenter intervievP = new LoadPresenter(viu.getinterface(),loadmodel);

           // SaveModel savemodel = new SaveModel();
            //SavePresenter intervievP = new SavePresenter(viu.getinterface(), savemodel);

            Application.Run(viu);
        }
    }
}
