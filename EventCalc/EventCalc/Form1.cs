using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventCalc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            buttonControl1.ButtonClicked += ButtonControl1_ButtonClicked;
        }

        private void ButtonControl1_ButtonClicked(object sender, ButtonClickEventArg e)
        {
            lbl1.Text += e.tbxString;
            textBox1.Text += e.tbxString;
            
            //create operator
            if (e.tbxString == "+")
            {
                textBox1.Clear();
            }
            
        }
    }
}
