using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
            string query = "SELECT * FROM lawer_data_table WHERE lawer_user_name = '" + LRegDate.getCurrentUser().ToString() + "';";
            string query_lawer_user_name = string.Empty;
            string query_lawer_phone_number = string.Empty;
            string query_lawer_Surname = string.Empty;
            string query_lawer_first_name = string.Empty;
            string query_lawer_second_name = string.Empty;
            string query_lawer_id_number = string.Empty;

            using (SqlDataReader reader = SQL.ExecuteReader(query))
            {
                if (reader.Read())
                {
                    query_lawer_user_name = reader["lawer_user_name"].ToString();
                    query_lawer_phone_number = reader["lawer_phone_number"].ToString();
                    query_lawer_Surname = reader["lawer_Surname"].ToString();
                    query_lawer_first_name = reader["lawer_first_name"].ToString();
                    query_lawer_second_name = reader["lawer_second_name"].ToString();
                    query_lawer_id_number = reader["lawer_id_number"].ToString();
                }
            }

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
                mail.Body = (mailBody + "\n\n\n" + "From\t:" + recipientAddress + "\nName Of Lawer\t:\t"+ query_lawer_Surname + " " + query_lawer_first_name + " " + query_lawer_second_name 
                                        + "\nUser ID\t:\t" + query_lawer_id_number + "\nUser Phone Number\t:\t" + query_lawer_phone_number + "\nUser Name\t:\t" + query_lawer_user_name);
                // System send user's Special data for more identification and easy to help.
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
            string query = "SELECT lawer_email FROM lawer_data_table WHERE lawer_user_name = '" + LRegDate.getCurrentUser().ToString() + "';";
            string queryEmail = string.Empty;

            using (SqlDataReader reader = SQL.ExecuteReader(query))
            {
                if (reader.Read())
                {
                    queryEmail = reader["lawer_email"].ToString();
                }
            }
            if (mailAddrTextBox.Text != string.Empty)
            {
                // check data base saved mail ...
                
                if (LRegDate.EmailIsCorrect(mailAddrTextBox.Text) && (queryEmail == mailAddrTextBox.Text)) {
                    sendButten.Enabled = true;
                    sendButten.Focus();
                }
                else
                {
                    mailAddrTextBox.Clear();
                }

            }
            else
            {
                sendButten.Enabled = false;
            }
            
            
        }
    }
}
