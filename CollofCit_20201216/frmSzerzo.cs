using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CollofCit_20201216
{
    public partial class frmSzerzo : Form
    {
        public string Tb_szerzoid { get => tb_szerzoid.Text; set => tb_szerzoid.Text = value; }
        public string Tb_nev { get => tb_nev.Text; set => tb_nev.Text = value; }

        public frmSzerzo()
        {
            InitializeComponent();
        }

        private void keresésToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMain.FrmSzerzoLista.Show();
        }

        private void frmSzerzo_Load(object sender, EventArgs e)
        {
            
        }

        private void mentésToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tb_nev.Text))
            {
                MessageBox.Show("A név mező üresen lett hagyva");
                return;
            }
            frmMain.ChangeData(int.Parse(tb_szerzoid.Text), tb_nev.Text);
        }

        private void tb_szerzoid_TextChanged(object sender, EventArgs e)
        {
            törlésToolStripMenuItem.Enabled = !string.IsNullOrEmpty(tb_szerzoid.Text);
        }
    }
}
