﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quiz
{
    public partial class Viev : Form
    {
        public Viev()
        {
            InitializeComponent();
        }
        //TODO poprawic to !!!!!
        public Questions getinterface()
        {
            return this.questions1;
        }
    }
}
