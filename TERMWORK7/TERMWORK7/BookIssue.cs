using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace TERMWORK7
{
    public partial class BookIssue : Form
    {
        public BookIssue()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            comboBox1.Enabled = true;
            comboBox2.Enabled = true;
            comboBox1.Focus();
        }

      

        private void BookIssue_Load(object sender, EventArgs e)
        {
             BindGrid();
            OleDbConnection odb = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=E:\\MCA50\\STD.mdb");
            odb.Open();
            string strCmd = "select USN from STUDENT";
            OleDbCommand cmd = new OleDbCommand(strCmd, odb);
            OleDbDataAdapter da = new OleDbDataAdapter(strCmd, odb);
            DataSet ds = new DataSet();
            da.Fill(ds);
            cmd.ExecuteNonQuery();
            odb.Close();

            comboBox1.DisplayMember = "USN";
            comboBox1.ValueMember = "USN";
            comboBox1.DataSource = ds.Tables[0];
            comboBox1.Enabled = true;
            odb.Close();

            OleDbConnection odbb = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=E:\\MCA50\\STD.mdb");
            odbb.Open();
            string strCmdd = "select BID from BOOK";
            OleDbCommand cmdd = new OleDbCommand(strCmdd, odbb);
            OleDbDataAdapter daa = new OleDbDataAdapter(strCmdd, odbb);
            DataSet dss = new DataSet();
            daa.Fill(dss);
            cmdd.ExecuteNonQuery();
            odbb.Close();

            comboBox2.DisplayMember = "BID";
            comboBox2.ValueMember = "BID";
            comboBox2.DataSource = ds.Tables[0];
            comboBox2.Enabled = true;
            odbb.Close();
        }

        private void BindGrid()
        {
            string strProvider = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=E:\\MCA50\\STD.mdb";
            string strSql = "SELECT * FROM BOOKISSUES";
            OleDbConnection con = new OleDbConnection(strProvider);
            OleDbCommand cmd = new OleDbCommand(strSql, con);
            con.Open();
            cmd.CommandType = CommandType.Text;
            OleDbDataReader dr = cmd.ExecuteReader();

            int columnCount = dr.FieldCount;
            for (int i = 0; i < columnCount; i++)
            {
                dgv.Columns.Add(dr.GetName(i).ToString(), dr.GetName(i).ToString());
            }
            string[] rowData = new string[columnCount];
            while (dr.Read())
            {
                for (int k = 0; k < columnCount; k++)
                {
                    if (dr.GetFieldType(k).ToString() == "System.Int32")
                    {
                        rowData[k] = dr.GetInt32(k).ToString();
                    }
                    if (dr.GetFieldType(k).ToString() == "System.String")
                    {
                        rowData[k] = dr.GetString(k);
                    }
                    if (dr.GetFieldType(k).ToString() == "System.DateTime")
                    {
                        rowData[k] = dr.GetDateTime(k).ToString();
                    }
                }
                dgv.Rows.Add(rowData);
            }
            con.Close();
        }
        private void button2_Click(object sender, EventArgs e)
        {

            OleDbConnection odb = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=E:\\MCA50\\STD.mdb");
            odb.Open();
            OleDbCommand odcom = new OleDbCommand("Insert into BOOKISSUES values('" + comboBox1.Text + "'," + comboBox2.Text + " ,' " +DOI.Value.Date+ "')", odb);
            odcom.ExecuteNonQuery();
            odb.Close();
            dgv.Rows.Clear();
            BindGrid();
            comboBox1.Enabled = false;
            comboBox2.Enabled = false;
        }
      }
}
