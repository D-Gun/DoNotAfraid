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
    public partial class ButtonControl : UserControl
    {
        public ButtonControl()
        {
            InitializeComponent();
        }
        public event EventHandler<ButtonClickEventArg> ButtonClicked;

        //Event Method for btn0~btnClear, Event susbscribed in InitializeComponent Method(ref. ButtonControl.Designer.cs)
        //ex) this.btn7.Click += new System.EventHandler(this.buttonClick);
        private void buttonClick(object sender, EventArgs e)
        {
            ButtonClickEventArg clickedButton = new ButtonClickEventArg();

            //create operator

            clickedButton.tbxString = ((Button)sender).Text;
                            
            ButtonClicked?.Invoke(this, clickedButton);
        }

    }
}
