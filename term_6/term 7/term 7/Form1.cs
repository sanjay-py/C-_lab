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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cOURSEWISEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            REPORT1 newChild = new REPORT1();
            newChild.MdiParent = this;
            newChild.WindowState = FormWindowState.Maximized;
            newChild.Show();
        }

        private void cOURSEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            COURSE newChild = new COURSE();
            newChild.MdiParent = this;
            newChild.WindowState = FormWindowState.Maximized;
            newChild.Show();
        }

        private void sTUDENTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            STUDENT newChild = new STUDENT();
            newChild.MdiParent = this;
            newChild.WindowState = FormWindowState.Maximized;
            newChild.Show();
        }

        private void yEARWISEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            REPORT2 newChild = new REPORT2();
            newChild.MdiParent = this;
            newChild.WindowState = FormWindowState.Maximized;
            newChild.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
