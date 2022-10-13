namespace sqlConnectorAPP
{
    partial class AddConnection
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDBname = new System.Windows.Forms.TextBox();
            this.txtConnStr = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.DBname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ConnStr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DBtype = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Insert_btn = new System.Windows.Forms.Button();
            this.delete_btn = new System.Windows.Forms.Button();
            this.btnTestConn = new System.Windows.Forms.Button();
            this.cbbDBtype = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "DB Name :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "ConnectionString :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "DB類型 :";
            // 
            // txtDBname
            // 
            this.txtDBname.Location = new System.Drawing.Point(166, 44);
            this.txtDBname.Name = "txtDBname";
            this.txtDBname.Size = new System.Drawing.Size(225, 25);
            this.txtDBname.TabIndex = 3;
            // 
            // txtConnStr
            // 
            this.txtConnStr.Location = new System.Drawing.Point(166, 86);
            this.txtConnStr.Name = "txtConnStr";
            this.txtConnStr.Size = new System.Drawing.Size(225, 25);
            this.txtConnStr.TabIndex = 4;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DBname,
            this.ConnStr,
            this.DBtype});
            this.dataGridView1.Location = new System.Drawing.Point(417, 44);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(551, 348);
            this.dataGridView1.TabIndex = 6;
            // 
            // DBname
            // 
            this.DBname.HeaderText = "DBname";
            this.DBname.MinimumWidth = 6;
            this.DBname.Name = "DBname";
            this.DBname.Width = 125;
            // 
            // ConnStr
            // 
            this.ConnStr.HeaderText = "ConnStr";
            this.ConnStr.MinimumWidth = 6;
            this.ConnStr.Name = "ConnStr";
            this.ConnStr.Width = 125;
            // 
            // DBtype
            // 
            this.DBtype.HeaderText = "DBtype";
            this.DBtype.MinimumWidth = 6;
            this.DBtype.Name = "DBtype";
            this.DBtype.Width = 125;
            // 
            // Insert_btn
            // 
            this.Insert_btn.Location = new System.Drawing.Point(166, 188);
            this.Insert_btn.Name = "Insert_btn";
            this.Insert_btn.Size = new System.Drawing.Size(214, 23);
            this.Insert_btn.TabIndex = 7;
            this.Insert_btn.Text = "Insert";
            this.Insert_btn.UseVisualStyleBackColor = true;
            this.Insert_btn.Click += new System.EventHandler(this.Insert_btn_Click);
            // 
            // delete_btn
            // 
            this.delete_btn.Location = new System.Drawing.Point(166, 238);
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.Size = new System.Drawing.Size(214, 23);
            this.delete_btn.TabIndex = 8;
            this.delete_btn.Text = "Delete";
            this.delete_btn.UseVisualStyleBackColor = true;
            this.delete_btn.Click += new System.EventHandler(this.delete_btn_Click);
            // 
            // btnTestConn
            // 
            this.btnTestConn.Location = new System.Drawing.Point(754, 417);
            this.btnTestConn.Name = "btnTestConn";
            this.btnTestConn.Size = new System.Drawing.Size(214, 23);
            this.btnTestConn.TabIndex = 9;
            this.btnTestConn.Text = "測試連線";
            this.btnTestConn.UseVisualStyleBackColor = true;
            this.btnTestConn.Click += new System.EventHandler(this.btnTestConn_Click);
            // 
            // cbbDBtype
            // 
            this.cbbDBtype.FormattingEnabled = true;
            this.cbbDBtype.Location = new System.Drawing.Point(166, 129);
            this.cbbDBtype.Name = "cbbDBtype";
            this.cbbDBtype.Size = new System.Drawing.Size(225, 23);
            this.cbbDBtype.TabIndex = 10;
            // 
            // AddConnection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 471);
            this.Controls.Add(this.cbbDBtype);
            this.Controls.Add(this.btnTestConn);
            this.Controls.Add(this.delete_btn);
            this.Controls.Add(this.Insert_btn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtConnStr);
            this.Controls.Add(this.txtDBname);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddConnection";
            this.Text = "AddConnection";
            this.Load += new System.EventHandler(this.AddConnection_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDBname;
        private System.Windows.Forms.TextBox txtConnStr;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn DBname;
        private System.Windows.Forms.DataGridViewTextBoxColumn ConnStr;
        private System.Windows.Forms.DataGridViewTextBoxColumn DBtype;
        private System.Windows.Forms.Button Insert_btn;
        private System.Windows.Forms.Button delete_btn;
        private System.Windows.Forms.Button btnTestConn;
        private System.Windows.Forms.ComboBox cbbDBtype;
    }
}