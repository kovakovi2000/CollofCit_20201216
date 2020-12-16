using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CollofCit_20201216
{
    class Szerzo
    {
        private int szerzoID;
        private string nev;

        public Szerzo(int szerzoID, string nev)
        {
            this.szerzoID = szerzoID;
            this.nev = nev;
        }

        public int SzerzoID { get => szerzoID; set => szerzoID = value; }
        public string Nev { get => nev; set => nev = value; }
    }
    class Forras
    {
        private int forrasID;
        private string cim;
        private int szerzoID;

        public Forras(int forrasID, string cim, int szerzoID)
        {
            this.forrasID = forrasID;
            this.cim = cim;
            this.szerzoID = szerzoID;
        }

        public int ForrasID => forrasID;
        public string Cim => cim;
        public int SzerzoID => szerzoID;
    }
    class Idezet
    {
        private int idezID;
        private string szoveg;
        private int forrasID;

        public Idezet(int idezID, string szoveg, int forrasID)
        {
            this.idezID = idezID;
            this.szoveg = szoveg;
            this.forrasID = forrasID;
        }

        public int IdezID => idezID;
        public string Szoveg => szoveg;
        public int ForrasID => forrasID;
    }
    class Tema
    {
        private int temaID;
        private string megnevezes;

        public Tema(int temaID, string megnevezes)
        {
            this.temaID = temaID;
            this.megnevezes = megnevezes;
        }

        public int TemaID => temaID;
        public string Megnevezes => megnevezes;
    }
    class Utalas
    {
        private int idezID;
        private int temaID;

        public Utalas(int idezID, int temaID)
        {
            this.idezID = idezID;
            this.temaID = temaID;
        }

        public int IdezID => idezID;
        public int TemaID => temaID;
    }
}
