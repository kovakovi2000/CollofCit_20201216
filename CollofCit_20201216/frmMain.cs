using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace CollofCit_20201216
{
    public partial class frmMain : Form
    {
        private static frmSzerzoLista frmSzerzoLista = new frmSzerzoLista();
        private static frmSzerzo frmSzerzo = new frmSzerzo();

        private static OleDbConnection conn;
        private Random RND = new Random();
        private static List<Szerzo> szerzo = new List<Szerzo>();
        private List<Forras> forras = new List<Forras>();
        private List<Idezet> idezet = new List<Idezet>();
        private List<Tema> tema = new List<Tema>();
        private List<Utalas> utalas = new List<Utalas>();
        class OledbGetQuotes
        {
            private static void GetSzerzo(ref List<Szerzo> szerzo, OleDbConnection conn)
            {
                var oledbcmd = new OleDbCommand($"SELECT szerzoID, nev FROM szerzo;", conn);
                var read = oledbcmd.ExecuteReader();
                while (read.Read())
                {
                    szerzo.Add(new Szerzo
                    (
                        int.Parse(read[0].ToString()),
                        read[1].ToString()
                    ));
                }
            }
            private static void GetForras(ref List<Forras> forras, OleDbConnection conn)
            {
                var oledbcmd = new OleDbCommand($"SELECT forrasID, cim, szerzoID FROM forras;", conn);
                var read = oledbcmd.ExecuteReader();
                while (read.Read())
                {
                    forras.Add(new Forras
                    (
                        int.Parse(read[0].ToString()),
                        read[1].ToString(),
                        int.Parse(read[2].ToString())
                    ));
                }
            }
            private static void GetIdezet(ref List<Idezet> idezet, OleDbConnection conn)
            {
                var oledbcmd = new OleDbCommand($"SELECT idezID, szoveg, forrasID FROM idezet;", conn);
                var read = oledbcmd.ExecuteReader();
                while (read.Read())
                {
                    idezet.Add(new Idezet
                    (
                        int.Parse(read[0].ToString()),
                        read[1].ToString(),
                        int.Parse(read[2].ToString())
                    ));
                }
            }
            private static void GetTema(ref List<Tema> tema, OleDbConnection conn)
            {
                var oledbcmd = new OleDbCommand($"SELECT temaID, megnevezes FROM tema;", conn);
                var read = oledbcmd.ExecuteReader();
                while (read.Read())
                {
                    tema.Add(new Tema
                    (
                        int.Parse(read[0].ToString()),
                        read[1].ToString()
                    ));
                }
            }
            private static void GetUtalas(ref List<Utalas> utalas, OleDbConnection conn)
            {
                var oledbcmd = new OleDbCommand($"SELECT idezID, temaID FROM utalas;", conn);
                var read = oledbcmd.ExecuteReader();
                while (read.Read())
                {
                    utalas.Add(new Utalas
                    (
                        int.Parse(read[0].ToString()),
                        int.Parse(read[1].ToString())
                    ));
                }
            }
            public static bool GetAll(ref List<Szerzo> szerzo, ref List<Forras> forras, ref List<Idezet> idezet, ref List<Tema> tema, ref List<Utalas> utalas, OleDbConnection conn)
            {
                try
                {
                    conn.Open();
                    GetSzerzo(ref szerzo, conn);
                    GetForras(ref forras, conn);
                    GetIdezet(ref idezet, conn);
                    GetTema(ref tema, conn);
                    GetUtalas(ref utalas, conn);
                    conn.Close();
                }
                catch (Exception)
                {
                    return false;
                }
                return true;
            }
        }
        public OleDbConnection Conn => conn;
        internal static List<Szerzo> Szerzo => szerzo;

        public static frmSzerzoLista FrmSzerzoLista { get => frmSzerzoLista; set => frmSzerzoLista = value; }
        public static frmSzerzo FrmSzerzo { get => frmSzerzo; set => frmSzerzo = value; }

        public frmMain()
        {
            conn = new OleDbConnection(
                "Provider=Microsoft.ACE.OLEDB.12.0;" +
                @"Data Source=|DataDirectory|Resources\idezetek.accdb");
            if (!OledbGetQuotes.GetAll(ref szerzo, ref forras, ref idezet, ref tema, ref utalas, conn))
            {
                MessageBox.Show("Hiba - Sikertelen adatbetöltés");
                Application.Exit();
            }
            frmSzerzoLista.FormClosed += (o, e) => frmSzerzoLista = new frmSzerzoLista();
            frmSzerzo.FormClosed += (o, e) => frmSzerzo = new frmSzerzo();
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            lbl_datenow.Text = DateTime.Now.ToString("yyyy. MMMM dd.");
            lbl_quotascount.Text = "Idézetek száma:\n" + idezet.Count.ToString();
            tb_quota.Text = idezet[RND.Next(0, idezet.Count - 1)].Szoveg;
            RefreshDGVs();
        }

        private void RefreshDGVs()
        {
            dgv_byauthor.Rows.Clear();
            foreach (var item in szerzo)
            {
                var row = (DataGridViewRow)dgv_byauthor.Rows[0].Clone();
                row.Cells[0].Value = item.Nev;
                int counter = 0;
                forras.ForEach(xforras =>
                {
                    if (xforras.SzerzoID == item.SzerzoID)
                        counter += idezet.Where(xidezet => xidezet.ForrasID == xforras.ForrasID).Count();
                });
                row.Cells[1].Value = counter.ToString();

                if (counter > 0)
                    dgv_byauthor.Rows.Add(row);
            }
            dgv_byauthor.Sort(dgv_byauthor.Columns[0], ListSortDirection.Ascending);

            dgv_bytopic.Rows.Clear();
            foreach (var item in tema)
            {
                var row = (DataGridViewRow)dgv_bytopic.Rows[0].Clone();
                row.Cells[0].Value = item.Megnevezes;
                int counter = 0;
                utalas.ForEach(xutalas =>
                {
                    if (xutalas.TemaID == item.TemaID)
                        counter += idezet.Where(xidezet => xidezet.IdezID == xutalas.IdezID).Count();
                });
                row.Cells[1].Value = counter.ToString();

                if (counter > 0)
                    dgv_bytopic.Rows.Add(row);
            }
            dgv_bytopic.Sort(dgv_bytopic.Columns[0], ListSortDirection.Ascending);
        }

        private void keresésToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSzerzoLista.Show();
        }

        private void szerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSzerzo.Show();
        }

        public static void ChangeData(int szerzoID, string nev)
        {
            if (szerzo.Where(x => x.SzerzoID == szerzoID).Count() > 0)
            {
                szerzo.ForEach(x =>
                {
                    if (x.SzerzoID == szerzoID)
                    {
                        x.Nev = nev;
                        x.SzerzoID = szerzoID;
                        conn.Open();
                        new OleDbCommand($"UPDATE szerzo SET nev = '{x.Nev}' WHERE szerzoID = {x.SzerzoID};", conn).ExecuteNonQuery();
                        conn.Close();
                    }
                });
            }
            else
            {
                szerzo.Add(new Szerzo(szerzoID, nev));
            }
        }

        public static void DeleteData(int szerzoID)
        {
            try
            {
                szerzo.Remove(szerzo.Where(x => x.SzerzoID == szerzoID).FirstOrDefault());
            }
            catch (Exception)
            {
                MessageBox.Show("Hibás törlési azonosító!");
                throw;
            }
        }
    }
}
