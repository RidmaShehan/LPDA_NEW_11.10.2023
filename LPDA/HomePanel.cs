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
    public partial class HomePanel : Form
    {
        public HomePanel()
        {
            InitializeComponent();
        }

        private void HomePanel_Load(object sender, EventArgs e)
        {
            DateTime dateTime = DateTime.Now;
            Greeting.Text = dateTime.ToShortTimeString();
        }

        private void Greeting_Click(object sender, EventArgs e)
        {

        }
    }
}
