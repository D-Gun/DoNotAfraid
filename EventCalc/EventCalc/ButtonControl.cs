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

        private void buttonClick(object sender, EventArgs e)
        {
            ButtonClickEventArg clickedButton = new ButtonClickEventArg();
            
            //create operator

            clickedButton.tbxString = ((Button)sender).Text;


            ButtonClicked?.Invoke(this, clickedButton);
        }

    }
}
