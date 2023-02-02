﻿using System;
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
    public partial class Report3 : Form
    {
        public Report3()
        {
            InitializeComponent();
        }
        private void BindGrid()
        {
            OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\\AD\\STD.mdb");
            OleDbCommand cmd = new OleDbCommand("SELECT BOOK.BID,BOOK.TITLE,BOOKISSUE.USN,BOOKISSUE.IDATE FROM BOOK INNER JOIN BOOKISSUE ON BOOK.BID=BOOKISSUE.BID WHERE(((BOOKISSUE.USN)='" + comboBox1.Text + "'))", con);
            cmd.CommandType = CommandType.Text;
            OleDbDataAdapter sda = new OleDbDataAdapter(cmd);
            DataTable dt = new DataTable();
            {
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

        private void Report3_Load(object sender, EventArgs e)
        {
              OleDbConnection odb = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\\AD\\STD.mdb");
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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BindGrid();
        }
    }
}
