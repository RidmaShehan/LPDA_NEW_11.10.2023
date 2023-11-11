using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LPDA
{
    public partial class dashboard_form : Form
    {
        about_panel aboutForm = new about_panel();

        bool SideBarExpand;
        bool HomeCollapsed;
        

        public dashboard_form()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!(sidebar.Width == sidebar.MinimumSize.Width)) {
                HomeTimer.Start();
                SidebarTimer.Start();
            }

            if (sidebar.Width == sidebar.MinimumSize.Width)
            {
                HomeTimer.Start();
                SidebarTimer.Start();
            }

            HomePanel hp = new HomePanel();
            hp.TopLevel = false;
            pnlComtent.Controls.Add(hp);
            hp.BringToFront();
            hp.Show();
        }

        private void dashboard_form_Load(object sender, EventArgs e)
        {
           
        }

        private void SidebarTimer_Tick(object sender, EventArgs e)
        {
            // if  sidebar is expand, minimze 
            if (SideBarExpand)
            {
                sidebar.Width -= 10;
                if (sidebar.Width <= sidebar.MinimumSize.Width)
                {
                    SideBarExpand = false;
                    SidebarTimer.Stop();
                }

            }
            else
            {
                //
                sidebar.Width += 10;
                if(sidebar.Width >= sidebar.MaximumSize.Width)
                {
                    SideBarExpand = true;
                    SidebarTimer.Stop();
                }
            }
        }

        private void munu_tag_icon_picture_Click(object sender, EventArgs e)
        {
            // ...menu butten is start "sidebarTimer" timer...
            SidebarTimer.Start();

        }

        private void sidebar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void HomeTimer_Tick(object sender, EventArgs e)
        {
            if (HomeCollapsed)
            {
                home_contener.Height += 10;
                if (home_contener.Height >= home_contener.MaximumSize.Height)
                {
                    HomeCollapsed = false;
                    HomeTimer.Stop();
                }
            }
            else
            {
                home_contener.Height -= 10;
                if (home_contener.Height <= home_contener.MinimumSize.Height)
                {
                    HomeCollapsed = true;
                    HomeTimer.Stop();
                }
            }
        }

        private void setings_panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            SidebarTimer.Start();
            HomeTimer.Start();
           
        }

        private void button7_Click(object sender, EventArgs e)
        {
            SidebarTimer.Start();
            HomeTimer.Start();
           
        }

        private void button9_Click(object sender, EventArgs e)
        {
            SidebarTimer.Start();
            HomeTimer.Start();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            SidebarTimer.Start();
            HomeTimer.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SidebarTimer.Start();
            
        }

        private void event_button_Click(object sender, EventArgs e)
        {
            SidebarTimer.Start();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new about_panel().ShowDialog();
            /*
             * USING " THE ShowDialog(); " KEYWORD 
             * we can lock the form on front... 
             * While this form is open user can't accsses otuer form..
             */
        }

        private void button6_Click(object sender, EventArgs e)
        {
            emailPanel ep = new emailPanel();
            ep.TopLevel = false;
            pnlComtent.Controls.Add(ep);
            ep.BringToFront();
            ep.Show();
        }

        
       

        private void SidebarTimerEx_Tick(object sender, EventArgs e)
        {
        
        }

        
        

        private void mailAddrTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void bodyTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void developer_Team_Panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
