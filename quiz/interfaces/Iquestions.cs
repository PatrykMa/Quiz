using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quiz
{
    interface Iquestions
    {
        string Q1text { get; set; }
        string Q2text { get; set; }
        string Q3text { get; set; }
        string Q4text { get; set; }
        string Qtitle { get; set; }
        string QName { get; set; }
        event Action<object> ButtonActionClick;
        event Action<object> ButtonBackClick;
        event Action<object> ButtonForwardClick;

        bool Q1Check { get; set; }
        bool Q2Check { get; set; }
        bool Q3Check { get; set; }
        bool Q4Check { get; set; }

        event Action<object> Q1CheckClick;
        event Action<object> Q2CheckClick;
        event Action<object> Q3CheckClick;
        event Action<object> Q4CheckClick;
    }
}
