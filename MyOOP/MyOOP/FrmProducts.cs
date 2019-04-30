using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MyOOP
{
    public partial class FrmProducts : MyOOP.FrmLogo
    {
        public FrmProducts()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.label1.Text = "123";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Title = "lllll";
        }
    }
}
