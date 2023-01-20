using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace term_7
{
    public partial class STUDENT : Form
    {
        public STUDENT()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void STUDENT_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sTUDENTDataSet1.STUDENT' table. You can move, or remove it, as needed.
            this.sTUDENTTableAdapter.Fill(this.sTUDENTDataSet1.STUDENT);

        }
    }
}
