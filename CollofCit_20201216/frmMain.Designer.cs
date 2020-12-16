namespace CollofCit_20201216
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_datenow = new System.Windows.Forms.Label();
            this.lbl_quotascount = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dgv_bytopic = new System.Windows.Forms.DataGridView();
            this.topic = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_byauthor = new System.Windows.Forms.DataGridView();
            this.author = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.szerkesztésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.szerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.témaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.forrásToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.idézetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.keresésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tb_quota = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_bytopic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_byauthor)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "A nap idézete:";
            // 
            // lbl_datenow
            // 
            this.lbl_datenow.AutoSize = true;
            this.lbl_datenow.Location = new System.Drawing.Point(560, 9);
            this.lbl_datenow.Name = "lbl_datenow";
            this.lbl_datenow.Size = new System.Drawing.Size(52, 13);
            this.lbl_datenow.TabIndex = 1;
            this.lbl_datenow.Text = "DateNow";
            // 
            // lbl_quotascount
            // 
            this.lbl_quotascount.AutoSize = true;
            this.lbl_quotascount.Location = new System.Drawing.Point(576, 46);
            this.lbl_quotascount.Name = "lbl_quotascount";
            this.lbl_quotascount.Size = new System.Drawing.Size(69, 13);
            this.lbl_quotascount.TabIndex = 2;
            this.lbl_quotascount.Text = "QuotasCount";
            this.lbl_quotascount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(157, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Az idézetek száma téma szerint:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(311, 111);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(170, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Az idézetek száma szerzők szerint:";
            // 
            // dgv_bytopic
            // 
            this.dgv_bytopic.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_bytopic.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.topic,
            this.count});
            this.dgv_bytopic.Location = new System.Drawing.Point(15, 127);
            this.dgv_bytopic.Name = "dgv_bytopic";
            this.dgv_bytopic.RowHeadersVisible = false;
            this.dgv_bytopic.Size = new System.Drawing.Size(240, 150);
            this.dgv_bytopic.TabIndex = 7;
            // 
            // topic
            // 
            this.topic.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.topic.HeaderText = "Téma";
            this.topic.Name = "topic";
            this.topic.ReadOnly = true;
            this.topic.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // count
            // 
            this.count.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.count.HeaderText = "Idézetek Száma";
            this.count.Name = "count";
            this.count.ReadOnly = true;
            this.count.Width = 50;
            // 
            // dgv_byauthor
            // 
            this.dgv_byauthor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_byauthor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.author,
            this.dataGridViewTextBoxColumn1});
            this.dgv_byauthor.Location = new System.Drawing.Point(314, 127);
            this.dgv_byauthor.Name = "dgv_byauthor";
            this.dgv_byauthor.RowHeadersVisible = false;
            this.dgv_byauthor.Size = new System.Drawing.Size(240, 150);
            this.dgv_byauthor.TabIndex = 8;
            // 
            // author
            // 
            this.author.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.author.HeaderText = "Szerző";
            this.author.Name = "author";
            this.author.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn1.HeaderText = "Idézetek száma";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 50;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.szerkesztésToolStripMenuItem,
            this.keresésToolStripMenuItem});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.menuStrip1.Location = new System.Drawing.Point(579, 111);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(126, 191);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // szerkesztésToolStripMenuItem
            // 
            this.szerkesztésToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.szerToolStripMenuItem,
            this.témaToolStripMenuItem,
            this.forrásToolStripMenuItem,
            this.idézetToolStripMenuItem});
            this.szerkesztésToolStripMenuItem.Image = global::CollofCit_20201216.Properties.Resources.edit;
            this.szerkesztésToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.szerkesztésToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.szerkesztésToolStripMenuItem.Name = "szerkesztésToolStripMenuItem";
            this.szerkesztésToolStripMenuItem.Size = new System.Drawing.Size(119, 83);
            this.szerkesztésToolStripMenuItem.Text = "Szerkesztés";
            this.szerkesztésToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // szerToolStripMenuItem
            // 
            this.szerToolStripMenuItem.Name = "szerToolStripMenuItem";
            this.szerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.szerToolStripMenuItem.Text = "Szerző";
            this.szerToolStripMenuItem.Click += new System.EventHandler(this.szerToolStripMenuItem_Click);
            // 
            // témaToolStripMenuItem
            // 
            this.témaToolStripMenuItem.Name = "témaToolStripMenuItem";
            this.témaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.témaToolStripMenuItem.Text = "Téma";
            // 
            // forrásToolStripMenuItem
            // 
            this.forrásToolStripMenuItem.Name = "forrásToolStripMenuItem";
            this.forrásToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.forrásToolStripMenuItem.Text = "Forrás";
            // 
            // idézetToolStripMenuItem
            // 
            this.idézetToolStripMenuItem.Name = "idézetToolStripMenuItem";
            this.idézetToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.idézetToolStripMenuItem.Text = "Idézet";
            // 
            // keresésToolStripMenuItem
            // 
            this.keresésToolStripMenuItem.Image = global::CollofCit_20201216.Properties.Resources.search;
            this.keresésToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.keresésToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.keresésToolStripMenuItem.Name = "keresésToolStripMenuItem";
            this.keresésToolStripMenuItem.Size = new System.Drawing.Size(119, 83);
            this.keresésToolStripMenuItem.Text = "Keresés";
            this.keresésToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // tb_quota
            // 
            this.tb_quota.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic);
            this.tb_quota.Location = new System.Drawing.Point(15, 25);
            this.tb_quota.Multiline = true;
            this.tb_quota.Name = "tb_quota";
            this.tb_quota.ReadOnly = true;
            this.tb_quota.Size = new System.Drawing.Size(539, 83);
            this.tb_quota.TabIndex = 10;
            this.tb_quota.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 290);
            this.Controls.Add(this.tb_quota);
            this.Controls.Add(this.dgv_byauthor);
            this.Controls.Add(this.dgv_bytopic);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbl_quotascount);
            this.Controls.Add(this.lbl_datenow);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = "Idézetgyűjtemény";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_bytopic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_byauthor)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_datenow;
        private System.Windows.Forms.Label lbl_quotascount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgv_bytopic;
        private System.Windows.Forms.DataGridView dgv_byauthor;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem szerkesztésToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem keresésToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem szerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem témaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem forrásToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem idézetToolStripMenuItem;
        private System.Windows.Forms.TextBox tb_quota;
        private System.Windows.Forms.DataGridViewTextBoxColumn topic;
        private System.Windows.Forms.DataGridViewTextBoxColumn count;
        private System.Windows.Forms.DataGridViewTextBoxColumn author;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
    }
}

