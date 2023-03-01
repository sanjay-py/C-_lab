namespace term_7
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fILEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cOURSEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sTUDENTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rEPORTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cOURSEWISEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yEARWISEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fILEToolStripMenuItem,
            this.rEPORTToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(782, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fILEToolStripMenuItem
            // 
            this.fILEToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cOURSEToolStripMenuItem,
            this.sTUDENTToolStripMenuItem});
            this.fILEToolStripMenuItem.Name = "fILEToolStripMenuItem";
            this.fILEToolStripMenuItem.Size = new System.Drawing.Size(55, 29);
            this.fILEToolStripMenuItem.Text = "FILE";
            // 
            // cOURSEToolStripMenuItem
            // 
            this.cOURSEToolStripMenuItem.Name = "cOURSEToolStripMenuItem";
            this.cOURSEToolStripMenuItem.Size = new System.Drawing.Size(159, 30);
            this.cOURSEToolStripMenuItem.Text = "COURSE";
            this.cOURSEToolStripMenuItem.Click += new System.EventHandler(this.cOURSEToolStripMenuItem_Click);
            // 
            // sTUDENTToolStripMenuItem
            // 
            this.sTUDENTToolStripMenuItem.Name = "sTUDENTToolStripMenuItem";
            this.sTUDENTToolStripMenuItem.Size = new System.Drawing.Size(159, 30);
            this.sTUDENTToolStripMenuItem.Text = "STUDENT";
            this.sTUDENTToolStripMenuItem.Click += new System.EventHandler(this.sTUDENTToolStripMenuItem_Click);
            // 
            // rEPORTToolStripMenuItem
            // 
            this.rEPORTToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cOURSEWISEToolStripMenuItem,
            this.yEARWISEToolStripMenuItem});
            this.rEPORTToolStripMenuItem.Name = "rEPORTToolStripMenuItem";
            this.rEPORTToolStripMenuItem.Size = new System.Drawing.Size(87, 29);
            this.rEPORTToolStripMenuItem.Text = "REPORT";
            // 
            // cOURSEWISEToolStripMenuItem
            // 
            this.cOURSEWISEToolStripMenuItem.Name = "cOURSEWISEToolStripMenuItem";
            this.cOURSEWISEToolStripMenuItem.Size = new System.Drawing.Size(197, 30);
            this.cOURSEWISEToolStripMenuItem.Text = "COURSE WISE";
            this.cOURSEWISEToolStripMenuItem.Click += new System.EventHandler(this.cOURSEWISEToolStripMenuItem_Click);
            // 
            // yEARWISEToolStripMenuItem
            // 
            this.yEARWISEToolStripMenuItem.Name = "yEARWISEToolStripMenuItem";
            this.yEARWISEToolStripMenuItem.Size = new System.Drawing.Size(197, 30);
            this.yEARWISEToolStripMenuItem.Text = "YEAR WISE";
            this.yEARWISEToolStripMenuItem.Click += new System.EventHandler(this.yEARWISEToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 467);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fILEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cOURSEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sTUDENTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rEPORTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cOURSEWISEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yEARWISEToolStripMenuItem;
    }
}

