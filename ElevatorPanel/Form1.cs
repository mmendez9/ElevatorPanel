using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElevatorPanel
{
    public partial class Form1 : Form
    {
        Button[] btms;
        public Form1()
        {
            InitializeComponent();

            btms = new Button[] {btn1, btn2, btn3, btn4, btn5,
                btn6, btn7, btn8, btn9, btn10 };
        }
    }
}
