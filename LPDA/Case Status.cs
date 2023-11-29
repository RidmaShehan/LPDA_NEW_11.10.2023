using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LPDA
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "All Files (*.*)|*.*"; // Customize the file filter if needed

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string selectedFilePath = openFileDialog.FileName;

                    // Perform further actions with the selected file, such as saving it or displaying its information
                    // ...
                }
            }

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBox1.Checked)
            {
                // Perform actions when "active" status is selected
                // ...
            }


        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {

                // Perform actions when "active" status is selected
                // ..
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {

                // Perform actions when "active" status is selected
                // ..
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Check if any of the DateTimePickers have an uninitialized date
            DateTimePicker[] datePickers = { dateTimePicker1, dateTimePicker2, dateTimePicker3, dateTimePicker4 };

            foreach (DateTimePicker datePicker in datePickers)
            {
                if (datePicker.Value == DateTimePicker.MinimumDateTime)
                {
                    MessageBox.Show("Please select valid dates for all Key Dates.", "Key Dates Missing", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // Exit the event handler
                }
            }
            if (string.IsNullOrEmpty(label5.Text))
            {
                MessageBox.Show("Please upload documents.", "Documents and evidence Missing", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Exit the event handler
            }



            if (string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Please add comments.", "Comments Missing", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Exit the event handler
            }

            // Check if at least one checkbox for case status is checked
            if (!(checkBox1.Checked || checkBox2.Checked || checkBox3.Checked))
            {
                MessageBox.Show("Please select at least one case status.", "Case Status Missing", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Exit the event handler
            }

            // If all checks passed, show "Add Case Details Successful" message
            MessageBox.Show("Add Case Details Successful", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Create an instance of Form2
            Form2 form2 = new Form2();

            // Show Form2
            form2.Show();

            // Close Form1 (optional)
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}














