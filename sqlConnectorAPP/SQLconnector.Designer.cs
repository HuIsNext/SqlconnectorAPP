namespace sqlConnectorAPP
{
    partial class SQLconnector
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
            this.加入連線設定ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.加入連線設定ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.cbbDBName = new System.Windows.Forms.ComboBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.dgvSqlCommand = new System.Windows.Forms.DataGridView();
            this.txtSqlcommand = new System.Windows.Forms.RichTextBox();
            this.btnSqlCommand = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSqlCommand)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.加入連線設定ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1204, 30);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 加入連線設定ToolStripMenuItem
            // 
            this.加入連線設定ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.加入連線設定ToolStripMenuItem1});
            this.加入連線設定ToolStripMenuItem.Name = "加入連線設定ToolStripMenuItem";
            this.加入連線設定ToolStripMenuItem.Size = new System.Drawing.Size(53, 26);
            this.加入連線設定ToolStripMenuItem.Text = "設定";
            // 
            // 加入連線設定ToolStripMenuItem1
            // 
            this.加入連線設定ToolStripMenuItem1.Name = "加入連線設定ToolStripMenuItem1";
            this.加入連線設定ToolStripMenuItem1.Size = new System.Drawing.Size(182, 26);
            this.加入連線設定ToolStripMenuItem1.Text = "加入連線設定";
            this.加入連線設定ToolStripMenuItem1.Click += new System.EventHandler(this.加入連線設定ToolStripMenuItem1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "連線設定";
            // 
            // cbbDBName
            // 
            this.cbbDBName.FormattingEnabled = true;
            this.cbbDBName.Location = new System.Drawing.Point(91, 41);
            this.cbbDBName.Name = "cbbDBName";
            this.cbbDBName.Size = new System.Drawing.Size(121, 23);
            this.cbbDBName.TabIndex = 2;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(18, 77);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(195, 559);
            this.listBox1.TabIndex = 3;
            // 
            // dgvSqlCommand
            // 
            this.dgvSqlCommand.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSqlCommand.Location = new System.Drawing.Point(230, 30);
            this.dgvSqlCommand.Name = "dgvSqlCommand";
            this.dgvSqlCommand.RowHeadersWidth = 51;
            this.dgvSqlCommand.RowTemplate.Height = 27;
            this.dgvSqlCommand.Size = new System.Drawing.Size(962, 411);
            this.dgvSqlCommand.TabIndex = 4;
            // 
            // txtSqlcommand
            // 
            this.txtSqlcommand.Location = new System.Drawing.Point(230, 501);
            this.txtSqlcommand.Name = "txtSqlcommand";
            this.txtSqlcommand.Size = new System.Drawing.Size(811, 125);
            this.txtSqlcommand.TabIndex = 5;
            this.txtSqlcommand.Text = "";
            // 
            // btnSqlCommand
            // 
            this.btnSqlCommand.Location = new System.Drawing.Point(1047, 501);
            this.btnSqlCommand.Name = "btnSqlCommand";
            this.btnSqlCommand.Size = new System.Drawing.Size(144, 125);
            this.btnSqlCommand.TabIndex = 6;
            this.btnSqlCommand.Text = "SQLcommand GO!";
            this.btnSqlCommand.UseVisualStyleBackColor = true;
            this.btnSqlCommand.Click += new System.EventHandler(this.btnSqlCommand_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(230, 463);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "SQL指令 :";
            // 
            // SQLconnector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1204, 669);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSqlCommand);
            this.Controls.Add(this.txtSqlcommand);
            this.Controls.Add(this.dgvSqlCommand);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.cbbDBName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "SQLconnector";
            this.Text = "SQLconnector";
            this.Load += new System.EventHandler(this.SQLconnectorLoad);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSqlCommand)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 加入連線設定ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 加入連線設定ToolStripMenuItem1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbbDBName;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.DataGridView dgvSqlCommand;
        private System.Windows.Forms.RichTextBox txtSqlcommand;
        private System.Windows.Forms.Button btnSqlCommand;
        private System.Windows.Forms.Label label2;
    }
}

