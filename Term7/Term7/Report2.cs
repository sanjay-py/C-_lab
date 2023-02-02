using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Term7
{
    public partial class Report2 : Form
    {
        public Report2()
        {
            InitializeComponent();
        }
        private void BindGrid()
        {
            OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\\AD\\STD.mdb");
            DateTime dat = Convert.ToDateTime(comboBox1.Text);
            OleDbCommand cmd = new OleDbCommand("SELECT BOOK.BID,BOOK.TITLE,BOOK.AUTHOR,BOOKISSUE.IDATE FROM BOOK INNER JOIN BOOKISSUE ON BOOK.BID=BOOKISSUE.BID WHERE(((BOOKISSUE.IDATE)LIKE  #" + dat + "#))", con);
            cmd.CommandType = CommandType.Text;
            OleDbDataAdapter sda = new OleDbDataAdapter(cmd);
            DataTable dt = new DataTable();
            {
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }
        private void Report2_Load(object sender, EventArgs e)
        {
            OleDbConnection odb = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\\AD\\STD.mdb");
            odb.Open();
            string strCmd = "select IDATE from BOOKISSUE";
            OleDbCommand cmd = new OleDbCommand(strCmd, odb);
            OleDbDataAdapter da = new OleDbDataAdapter(strCmd, odb);
            DataSet ds = new DataSet();
            da.Fill(ds);
            cmd.ExecuteNonQuery();
            odb.Close();

            comboBox1.DisplayMember = "IDATE";
            comboBox1.ValueMember = "IDATE";
            comboBox1.DataSource = ds.Tables[0];
            comboBox1.Enabled = true;
            odb.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BindGrid();
        }
    }
}
