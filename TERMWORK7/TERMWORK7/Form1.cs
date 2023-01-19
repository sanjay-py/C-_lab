using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TERMWORK7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void courseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Course c = new Course();
            c.MdiParent = this;
            c.WindowState = FormWindowState.Maximized;
            c.Show();
        }

        private void bookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Book c = new Book();
            c.MdiParent = this;
            c.WindowState = FormWindowState.Maximized;
            c.Show();
        }

        private void studentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Student c = new Student();
            c.MdiParent = this;
            c.WindowState = FormWindowState.Maximized;
            c.Show();
        }

        private void bookIssueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BookIssue c = new BookIssue();
            c.MdiParent = this;
            c.WindowState = FormWindowState.Maximized;
            c.Show();
        }

        private void courseWiseBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Report1 c = new Report1();
            c.MdiParent = this;
            c.WindowState = FormWindowState.Maximized;
            c.Show();
        }

        private void dateWiseBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Report2 c = new Report2();
            c.MdiParent = this;
            c.WindowState = FormWindowState.Maximized;
            c.Show();
        }

        private void studentWiseBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Report3 c = new Report3();
            c.MdiParent = this;
            c.WindowState = FormWindowState.Maximized;
            c.Show();
        }
    }
}
