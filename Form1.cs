using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;

namespace Window_Border_Haute_Couture
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }
        private void Form1_Load(object sender, EventArgs e)
        {        
        }

        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {            
            Form1.ActiveForm.FormBorderStyle = FormBorderStyle.None;
        }

        private void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {            
            Form1.ActiveForm.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void RadioButton3_CheckedChanged(object sender, EventArgs e)
        {
            Form1.ActiveForm.FormBorderStyle = FormBorderStyle.Fixed3D;
        }

        private void RadioButton4_CheckedChanged(object sender, EventArgs e)
        {
            Form1.ActiveForm.FormBorderStyle = FormBorderStyle.FixedDialog;
        }

        private void RadioButton5_CheckedChanged(object sender, EventArgs e)
        {
            Form1.ActiveForm.FormBorderStyle = FormBorderStyle.Sizable;
        }

        private void RadioButton6_CheckedChanged(object sender, EventArgs e)
        {
            Form1.ActiveForm.FormBorderStyle = FormBorderStyle.FixedToolWindow;
        }

        private void RadioButton7_CheckedChanged(object sender, EventArgs e)
        {
            Form1.ActiveForm.FormBorderStyle = FormBorderStyle.SizableToolWindow;
        }

        private void RadioButton8_CheckedChanged(object sender, EventArgs e)
        {
            Form1.ActiveForm.FormBorderStyle = FormBorderStyle.FixedToolWindow;
        }
    }
}
