using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using KeyValuePair.Mainifest;

namespace KeyValuePair.Test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            IDisplayText displayText = IocInstanceFactory<IDisplayText>.GetDisplayInstance();
            displayText.DisplayText();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            IDisplayBox displayBox = IocInstanceFactory<IDisplayBox>.GetDisplayInstance();
            displayBox.DisplayBox();
        }
    }
}
