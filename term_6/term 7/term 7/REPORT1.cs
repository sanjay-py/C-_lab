using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace term_7
{
    public partial class REPORT1 : Form
    {
        public REPORT1()
        {
            InitializeComponent();
        }

        private void REPORT1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sTUDENTDataSet2.STUDENT' table. You can move, or remove it, as needed.
            this.sTUDENTTableAdapter.Fill(this.sTUDENTDataSet2.STUDENT);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Please enter valid course id");
            }
            else
            {
                BindGrid();
            }
        }

        private void BindGrid()
        {
            string constring = @"Data Source=.\SQLEXPRESS;AttachDbFilename=F:\programs\c#\term 7\term 7\STUDENT.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True";
            SqlConnection con = new SqlConnection(constring);
            SqlCommand cmd = new SqlCommand("SELECT * FROM STUDENT WHERE CID LIKE'" + textBox1.Text + "'", con);
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            {
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }
    }
}
