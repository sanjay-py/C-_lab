namespace term_7
{
    partial class REPORT1
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.sTUDENTDataSet2 = new term_7.STUDENTDataSet2();
            this.sTUDENTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sTUDENTTableAdapter = new term_7.STUDENTDataSet2TableAdapters.STUDENTTableAdapter();
            this.uSNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aDDRESSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yEARADDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTUDENTDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTUDENTBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(277, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Course Number:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(524, 126);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(211, 26);
            this.textBox1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(424, 202);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 42);
            this.button1.TabIndex = 2;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.uSNDataGridViewTextBoxColumn,
            this.sNAMEDataGridViewTextBoxColumn,
            this.aDDRESSDataGridViewTextBoxColumn,
            this.cIDDataGridViewTextBoxColumn,
            this.yEARADDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.sTUDENTBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(206, 295);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(668, 150);
            this.dataGridView1.TabIndex = 3;
            // 
            // sTUDENTDataSet2
            // 
            this.sTUDENTDataSet2.DataSetName = "STUDENTDataSet2";
            this.sTUDENTDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sTUDENTBindingSource
            // 
            this.sTUDENTBindingSource.DataMember = "STUDENT";
            this.sTUDENTBindingSource.DataSource = this.sTUDENTDataSet2;
            // 
            // sTUDENTTableAdapter
            // 
            this.sTUDENTTableAdapter.ClearBeforeFill = true;
            // 
            // uSNDataGridViewTextBoxColumn
            // 
            this.uSNDataGridViewTextBoxColumn.DataPropertyName = "USN";
            this.uSNDataGridViewTextBoxColumn.HeaderText = "USN";
            this.uSNDataGridViewTextBoxColumn.Name = "uSNDataGridViewTextBoxColumn";
            // 
            // sNAMEDataGridViewTextBoxColumn
            // 
            this.sNAMEDataGridViewTextBoxColumn.DataPropertyName = "SNAME";
            this.sNAMEDataGridViewTextBoxColumn.HeaderText = "SNAME";
            this.sNAMEDataGridViewTextBoxColumn.Name = "sNAMEDataGridViewTextBoxColumn";
            // 
            // aDDRESSDataGridViewTextBoxColumn
            // 
            this.aDDRESSDataGridViewTextBoxColumn.DataPropertyName = "ADDRESS";
            this.aDDRESSDataGridViewTextBoxColumn.HeaderText = "ADDRESS";
            this.aDDRESSDataGridViewTextBoxColumn.Name = "aDDRESSDataGridViewTextBoxColumn";
            // 
            // cIDDataGridViewTextBoxColumn
            // 
            this.cIDDataGridViewTextBoxColumn.DataPropertyName = "CID";
            this.cIDDataGridViewTextBoxColumn.HeaderText = "CID";
            this.cIDDataGridViewTextBoxColumn.Name = "cIDDataGridViewTextBoxColumn";
            // 
            // yEARADDataGridViewTextBoxColumn
            // 
            this.yEARADDataGridViewTextBoxColumn.DataPropertyName = "YEARAD";
            this.yEARADDataGridViewTextBoxColumn.HeaderText = "YEARAD";
            this.yEARADDataGridViewTextBoxColumn.Name = "yEARADDataGridViewTextBoxColumn";
            // 
            // REPORT1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1091, 570);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "REPORT1";
            this.Text = "REPORT1";
            this.Load += new System.EventHandler(this.REPORT1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTUDENTDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTUDENTBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private STUDENTDataSet2 sTUDENTDataSet2;
        private System.Windows.Forms.BindingSource sTUDENTBindingSource;
        private STUDENTDataSet2TableAdapters.STUDENTTableAdapter sTUDENTTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn uSNDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aDDRESSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yEARADDataGridViewTextBoxColumn;
    }
}