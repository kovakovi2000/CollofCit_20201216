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
    public partial class frmSzerzoLista : Form
    {
        public frmSzerzoLista()
        {
            InitializeComponent();
        }

        public DataGridView Dgv_authors { get => dgv_authors; set => dgv_authors = value; }

        private void tb_search_TextChanged(object sender, EventArgs e)
        {
            dgv_authors.Rows.Clear();
            foreach (var item in frmMain.Szerzo.Where(x => x.Nev.StartsWith(tb_search.Text)))
            {
                var row = (DataGridViewRow)dgv_authors.Rows[0].Clone();
                row.Cells[0].Value = item.SzerzoID;
                row.Cells[1].Value = item.Nev;
                dgv_authors.Rows.Add(row);
            }
        }

        private void frmSzerzoLista_Load(object sender, EventArgs e)
        {
            foreach (var item in frmMain.Szerzo)
            {
                var row = (DataGridViewRow)dgv_authors.Rows[0].Clone();
                row.Cells[0].Value = item.SzerzoID;
                row.Cells[1].Value = item.Nev;
                dgv_authors.Rows.Add(row);
            }
        }

        private void dgv_authors_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            frmMain.FrmSzerzo.Tb_szerzoid = dgv_authors.Rows[dgv_authors.CurrentCell.RowIndex].Cells[0].Value.ToString();
            frmMain.FrmSzerzo.Tb_nev = dgv_authors.Rows[dgv_authors.CurrentCell.RowIndex].Cells[1].Value.ToString();
            frmMain.FrmSzerzoLista.Close();
        }
    }
}
