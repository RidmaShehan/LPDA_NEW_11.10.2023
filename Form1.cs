using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LPDA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_Click(object sender, EventArgs e)
        {     
                panel2.Visible = true;
                panel1.Visible = false;
               
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
            panel1.Visible = true;
            radioButton1.Checked = false;


        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)

        {
            if (radioButton2.Checked)
            {
                MessageBox.Show("TASK COMPLETE");
                panel4.Visible = false;
                panel5.Visible = true;
            }
            
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel4.Visible = true;
            panel5.Visible=false;
            radioButton2.Checked = false;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
     
        {
            if (radioButton3.Checked)
            {
                panel6.Visible = false;
                panel7.Visible = true;
                MessageBox.Show("TASK COMPLETE");
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel7.Visible=false;
            panel6.Visible=true;
            radioButton3.Checked = false;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                MessageBox.Show("TASK COMPLETE");
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked)
            {
                panel8.Visible = false;
                panel9.Visible = true;
                MessageBox.Show("Task COMPLETE");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            panel8.Visible = true;
            panel9.Visible=false;
            radioButton4.Checked = false;
        }
    } 
}   
