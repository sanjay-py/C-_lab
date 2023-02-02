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
    public partial class COURSE : Form
    {
        public COURSE()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Enabled = true;
            textBox2.Enabled = true;
            textBox1.Focus();
        }
        private void BindGrid()
        {
            string strProvider = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\\AD\\STD.mdb";
            string strSql = "SELECT *FROM COURSE";
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
                    if (dr.GetFieldType(k).ToString() == "System.INT32")
                    {
                        rowData[k] = dr.GetInt32(k).ToString();
                    }
                    if (dr.GetFieldType(k).ToString() == "System.String")
                    {
                        rowData[k] = dr.GetString(k);
                    }
                }
                dgv.Rows.Add(rowData);
            }
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OleDbConnection odb = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\\AD\\STD.mdb");
            odb.Open();
            OleDbCommand odcom = new OleDbCommand("insert into COURSE values(" + textBox1.Text + ",'" + textBox2.Text + "')", odb);
            odcom.ExecuteNonQuery();
            odb.Close();
            dgv.Rows.Clear();
            BindGrid();
            textBox1.Enabled = false;
            textBox2.Enabled = false;
        }
    }
}
