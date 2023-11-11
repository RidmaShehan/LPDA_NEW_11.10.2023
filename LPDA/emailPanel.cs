using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace LPDA
{
    public partial class emailPanel : Form
    {
        LRegDate LRegDate = new LRegDate();
        HelpCenterGuidLines HelpCenterGuidLines = new HelpCenterGuidLines();
        public emailPanel()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String mailAddr = mailAddrTextBox.Text;
            string body = bodyTextBox.Text;

            sendEmail(mailAddr, body);
            bodyTextBox.Text = string.Empty;
        }

        public void sendEmail(string recipientAddress, string mailBody)
        {


            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient smtp = new SmtpClient("smtp.gmail.com");

                // Your Gmail credentials
                string senderEmail = "lpdadeveloperteam@gmail.com";
                string senderPassword = "rdtk cyhs urie kdta"; // Replace with your actual password

                mail.From = new MailAddress(senderEmail);
                mail.To.Add(senderEmail);
                mail.Subject = "Lawyers Q&A";
                mail.Body = (mailBody + "\n\n\n" + "From\t:" + recipientAddress + "Name Of Lawer :\t");

                smtp.Port = 587;
                smtp.Credentials = new System.Net.NetworkCredential(senderEmail, senderPassword);
                smtp.EnableSsl = true;
                smtp.Send(mail);

                MessageBox.Show("Email sent successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            HelpCenterGuidLines.ShowDialog();
        }

        private void mailAddrTextBox_TextChanged(object sender, EventArgs e)
        {
            // This method was chacked by E-mail is correct or incorrect 
            if (LRegDate.EmailIsCorrect(mailAddrTextBox.Text))
            {
                if (mailAddrTextBox.Text != string.Empty)
                {
                    sendButten.Enabled = true;
                    sendButten.Focus();
                }
                else
                {
                    sendButten.Enabled = false;
                }
            }
            else 
            {
                mailAddrTextBox.Clear();    
            }
        }
    }
}
