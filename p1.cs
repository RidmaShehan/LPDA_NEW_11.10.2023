using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace LPDA
{
    public partial class p1 : Form
    {
        public p1()
        {
            InitializeComponent();

        }

        DataTable table = new DataTable();

        int indexRow;
        int index;
        private object con;

        private void label1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source=NOOBY\\SQLEXPRESS; database=LPDA; integrated security=True";

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select*From Task";
            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            DA.Fill(ds);

            dataGridView1.DataSource = ds.Tables[0];



        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {

        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            //DataGridView gd = (DataGridView)sender;
            //DataRowView row_selected = Selectediteam as DataRowView;
            //if (row_selected != null)

            //{
            //    TaskID.Text = row_selected["TaskID"].ToString();
            //    Description.Text = row_selected["Description"].ToString();
            //    Dob.Text = row_selected["dueDate"].ToString();
            //    Completed.Text= row_selected["complated"].ToString() ;
            //}


        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dataGridView1.CurrentRow.Selected = true;
                TaskID.Text = dataGridView1.Rows[e.RowIndex].Cells["TaskID"].FormattedValue.ToString();
                Description.Text = dataGridView1.Rows[e.RowIndex].Cells["Description"].FormattedValue.ToString();
                Dob.Text = dataGridView1.Rows[e.RowIndex].Cells["duedate"].FormattedValue.ToString();
                Completed.Text = dataGridView1.Rows[e.RowIndex].Cells["Completed"].FormattedValue.ToString();

                //if (Completed.Text = "Yes")
                //{
                //    
                // use this code show new panel
                //}

            }
        }

        private void TASKID(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            TaskID.ResetText();
            Description.ResetText();
            Dob.ResetText();
            Completed.ResetText();
        }

        private void button2_Click(object sender, EventArgs e)
        {



            DataGridViewRow newDataRow = dataGridView1.Rows[indexRow];
            newDataRow.Cells[0].Value = TaskID.Text;
            newDataRow.Cells[1].Value = Description.Text;
            newDataRow.Cells[2].Value = Dob.Text;
            newDataRow.Cells[3].Value = Completed.Text;









        }

        private void DataGridView_Add_Update_Delete_Selected_Row_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        {

        }

        private void p1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Time.Text = DateTime.Now.ToLongTimeString();
            Date.Text = DateTime.Now.ToShortDateString();
        }

        //private void dup_Click(object sender, EventArgs e)
        //{
        //    SqlConnection con = new SqlConnection();
        //    con.ConnectionString = "data source=NOOBY\\SQLEXPRESS; database=LPDA; integrated security=True";

        //    int dob;
        //    dob = int.Parse(Dob.Text);

        //    SqlCommand cmd = new SqlCommand();
        //    cmd.Connection = con;
        //    cmd.CommandText = "UPDATE Task SET DueDate  =dob WHERE TaskID=int.parse(TaskID.Text())";
        //    SqlDataAdapter DA = new SqlDataAdapter(cmd);
        //    DataSet ds = new DataSet();
        //    DA.Fill(ds);

        //    dataGridView1.DataSource = ds.Tables[0];
        //}



    }

    

    
}
    


