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
        public int frontNum { get; set; }
        public int backNum { get; set; }
        public char op { get; set; }
        public int calcResult { get; set; }
        public string pureNum { get; set; }
        private void ButtonControl1_ButtonClicked(object sender, ButtonClickEventArg e)
        {
            lbl1.Text += e.tbxString;
            tbxNumber.Text += e.tbxString;
            
            //create operator
            //plus
            if (e.tbxString == "+")
            {
                getFrontNumber(tbxNumber);
                op = '+';
                tbxNumber.Clear();
            }

            //clear
            else if (e.tbxString == "C")
            {
                lbl1.Text = null;
                tbxNumber.Text = null;
                frontNum = 0;
                backNum = 0;
                calcResult = 0;
                pureNum = null;
            }

            //equal(calculating)
            else if (e.tbxString == "=")
            {
                getBackNumber(tbxNumber);
                if (op == '+')
                    calcResult = frontNum + backNum;
                else if (op == '-')
                    calcResult = frontNum - backNum;

                tbxNumber.Text = calcResult.ToString();


            }
            
        }

        private void getBackNumber(TextBox tbxNumber)
        {
            for (int i = 0; i < tbxNumber.TextLength - 1; i++)
            {
                pureNum += tbxNumber.Text[i];
            }
            backNum = int.Parse(pureNum);
        }

        private void getFrontNumber(TextBox tbxNumber)
        {
            for (int i = 0; i < tbxNumber.TextLength-1; i++)
            {
                pureNum += tbxNumber.Text[i]; 
            }
            frontNum = int.Parse(pureNum);
        }
    }
}
