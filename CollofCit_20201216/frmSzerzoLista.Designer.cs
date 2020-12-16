namespace CollofCit_20201216
{
    partial class frmSzerzoLista
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSzerzoLista));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tb_search = new System.Windows.Forms.TextBox();
            this.dgv_authors = new System.Windows.Forms.DataGridView();
            this.szerzoID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nev = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_authors)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tb_search);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(223, 54);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Szűrés";
            // 
            // tb_search
            // 
            this.tb_search.Location = new System.Drawing.Point(16, 19);
            this.tb_search.Name = "tb_search";
            this.tb_search.Size = new System.Drawing.Size(188, 20);
            this.tb_search.TabIndex = 0;
            this.tb_search.TextChanged += new System.EventHandler(this.tb_search_TextChanged);
            // 
            // dgv_authors
            // 
            this.dgv_authors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_authors.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.szerzoID,
            this.nev});
            this.dgv_authors.Location = new System.Drawing.Point(12, 72);
            this.dgv_authors.Name = "dgv_authors";
            this.dgv_authors.RowHeadersVisible = false;
            this.dgv_authors.Size = new System.Drawing.Size(223, 175);
            this.dgv_authors.TabIndex = 1;
            this.dgv_authors.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_authors_CellContentClick);
            // 
            // szerzoID
            // 
            this.szerzoID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.szerzoID.HeaderText = "szerzoID";
            this.szerzoID.Name = "szerzoID";
            this.szerzoID.ReadOnly = true;
            this.szerzoID.Width = 60;
            // 
            // nev
            // 
            this.nev.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nev.HeaderText = "nev";
            this.nev.Name = "nev";
            this.nev.ReadOnly = true;
            // 
            // frmSzerzoLista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(246, 263);
            this.Controls.Add(this.dgv_authors);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSzerzoLista";
            this.Text = "Szerzők";
            this.Load += new System.EventHandler(this.frmSzerzoLista_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_authors)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tb_search;
        private System.Windows.Forms.DataGridView dgv_authors;
        private System.Windows.Forms.DataGridViewTextBoxColumn szerzoID;
        private System.Windows.Forms.DataGridViewTextBoxColumn nev;
    }
}