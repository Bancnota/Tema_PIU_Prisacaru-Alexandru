using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Tema
{
    class Carte
    {
        private string nume;
        private string autor;
        private int nrpagini;
        private int pret;
        public string carti;
        public int nrCarti;

        public enum gen
        {
            Roman = 1,
            Nuvela = 2,
            Pastel = 3,
            Basm = 4
        }
        private gen genul = gen.Roman;
        public gen _gen
        {
            get { return genul; }
            set { genul = value; }
        }
        public string NUME
        {
            get
            { return nume; }
            set
            { nume = value; }
        }
        public string AUTOR
        {
            get
            { return autor; }
            set
            { autor = value; }
        }
        public int NRPAGINI
        {
            get
            { return nrpagini; }
            set
            { nrpagini = value; }
        }
        public int PRET
        {
            get
            { return pret; }
            set
            { pret = value; }
        }
        public Carte()
        {
            nume = string.Empty;
            autor = string.Empty;
            //  carti = string.Empty;
            nrpagini = 0;
            pret = 0;
            // nrCarti = 0;
        }
        public Carte(string Nume, string Autor, int NrPagini, int Pret)
        {
            nume = Nume;
            autor = Autor;
            //carti = _carti;
            nrpagini = NrPagini;
            pret = Pret;
            // nrCarti = _nrCarti;

        }
        public Carte(string _nume)
        {
            string[] Buff = _nume.Split(',');
            nume = Buff[0];
            autor = Buff[1];
            nrpagini = Convert.ToInt32(Buff[2]);
            pret = Convert.ToInt32(Buff[3]);
        }
        public void NumarareCarti()
        {
            for (int i = 0; i < nrCarti; i++)
            {
                Console.WriteLine(carti[i]);
            }
        }
       /* public void modificarepret(Carte _pret)
        {
            for (int i = 0; i < nrCarti; i++)
                carti[i].Pret = _pret;
        }*/
        public void comparare(Carte db)
        {
            if(pret>db.pret)
            {
                Console.WriteLine("Cartea {0} scrisa de {1} costa mai mult decat cartea {2} scrisa de {3}", nume, autor, db.nume, db.autor);
                Console.ReadKey();
            }
            if (pret < db.pret)
            {
                Console.WriteLine("Cartea {0} scrisa de {1} costa mai mult decat cartea {2} scrisa de {3}", db.nume, db.autor, nume, autor);
                Console.ReadKey();
            }
            if(pret == db.pret)
            {
                Console.WriteLine("Au acelasi pret");
                Console.ReadKey();
            }
        }
        public string Afisare()
        {
            return string.Format( "Cartea cu numele <<{0}>>,a fost scrisa de autorul <<{1}>>,are {2} de pagini si costa {3} lei",nume,autor,nrpagini,pret);
           //Console.ReadKey();
        }
    }
}
