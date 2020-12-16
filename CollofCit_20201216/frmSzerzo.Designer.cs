namespace CollofCit_20201216
{
    partial class frmSzerzo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSzerzo));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_szerzoid = new System.Windows.Forms.TextBox();
            this.tb_nev = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.keresésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mentésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.törlésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.üresŰrlapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Enabled = false;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Azonosító:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Név:";
            // 
            // tb_szerzoid
            // 
            this.tb_szerzoid.Enabled = false;
            this.tb_szerzoid.Location = new System.Drawing.Point(76, 12);
            this.tb_szerzoid.Name = "tb_szerzoid";
            this.tb_szerzoid.Size = new System.Drawing.Size(100, 20);
            this.tb_szerzoid.TabIndex = 2;
            this.tb_szerzoid.TextChanged += new System.EventHandler(this.tb_szerzoid_TextChanged);
            // 
            // tb_nev
            // 
            this.tb_nev.Location = new System.Drawing.Point(48, 38);
            this.tb_nev.Name = "tb_nev";
            this.tb_nev.Size = new System.Drawing.Size(214, 20);
            this.tb_nev.TabIndex = 3;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.keresésToolStripMenuItem,
            this.mentésToolStripMenuItem,
            this.törlésToolStripMenuItem,
            this.üresŰrlapToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(15, 88);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(367, 59);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // keresésToolStripMenuItem
            // 
            this.keresésToolStripMenuItem.Image = global::CollofCit_20201216.Properties.Resources.keres;
            this.keresésToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.keresésToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.keresésToolStripMenuItem.Name = "keresésToolStripMenuItem";
            this.keresésToolStripMenuItem.Size = new System.Drawing.Size(58, 55);
            this.keresésToolStripMenuItem.Text = "Keresés";
            this.keresésToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.keresésToolStripMenuItem.Click += new System.EventHandler(this.keresésToolStripMenuItem_Click);
            // 
            // mentésToolStripMenuItem
            // 
            this.mentésToolStripMenuItem.Image = global::CollofCit_20201216.Properties.Resources.save;
            this.mentésToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.mentésToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mentésToolStripMenuItem.Name = "mentésToolStripMenuItem";
            this.mentésToolStripMenuItem.Size = new System.Drawing.Size(58, 55);
            this.mentésToolStripMenuItem.Text = "Mentés";
            this.mentésToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.mentésToolStripMenuItem.Click += new System.EventHandler(this.mentésToolStripMenuItem_Click);
            // 
            // törlésToolStripMenuItem
            // 
            this.törlésToolStripMenuItem.Enabled = false;
            this.törlésToolStripMenuItem.Image = global::CollofCit_20201216.Properties.Resources.delete;
            this.törlésToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.törlésToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.törlésToolStripMenuItem.Name = "törlésToolStripMenuItem";
            this.törlésToolStripMenuItem.Size = new System.Drawing.Size(51, 55);
            this.törlésToolStripMenuItem.Text = "Törlés";
            this.törlésToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // üresŰrlapToolStripMenuItem
            // 
            this.üresŰrlapToolStripMenuItem.Image = global::CollofCit_20201216.Properties.Resources.ures_urlap;
            this.üresŰrlapToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.üresŰrlapToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.üresŰrlapToolStripMenuItem.Name = "üresŰrlapToolStripMenuItem";
            this.üresŰrlapToolStripMenuItem.Size = new System.Drawing.Size(72, 55);
            this.üresŰrlapToolStripMenuItem.Text = "Üres űrlap";
            this.üresŰrlapToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.üresŰrlapToolStripMenuItem.Click += new System.EventHandler(this.üresŰrlapToolStripMenuItem_Click);
            // 
            // frmSzerzo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(275, 163);
            this.Controls.Add(this.tb_nev);
            this.Controls.Add(this.tb_szerzoid);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSzerzo";
            this.Text = "Szerző";
            this.Load += new System.EventHandler(this.frmSzerzo_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_szerzoid;
        private System.Windows.Forms.TextBox tb_nev;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem keresésToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mentésToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem törlésToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem üresŰrlapToolStripMenuItem;
    }
}