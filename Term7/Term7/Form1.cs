using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Term7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cOURSEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            COURSE c = new COURSE();
            c.MdiParent = this;
            c.WindowState = FormWindowState.Maximized;
            c.Show();
        }

        private void bOOKToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BOOK c = new BOOK();
            c.MdiParent = this;
            c.WindowState = FormWindowState.Maximized;
            c.Show();
        }

        private void sTUDENTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            STUDENT c = new STUDENT();
            c.MdiParent = this;
            c.WindowState = FormWindowState.Maximized;
            c.Show();
        }

        private void bOOKISSUEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BOOKISSUE c = new BOOKISSUE();
            c.MdiParent = this;
            c.WindowState = FormWindowState.Maximized;
            c.Show();
        }

        private void cOURSEWISEBOOKSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Report1 c = new Report1();
            c.MdiParent = this;
            c.WindowState = FormWindowState.Maximized;
            c.Show();
        }

        private void dATEWISEBOOKSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Report2  c = new Report2();
            c.MdiParent = this;
            c.WindowState = FormWindowState.Maximized;
            c.Show();
        }

        private void sTUDENTWISEBOOKSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Report3 c = new Report3();
            c.MdiParent = this;
            c.WindowState = FormWindowState.Maximized;
            c.Show();
        }
    }
}
