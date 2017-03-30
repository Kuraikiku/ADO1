using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class Kurs
    {
        string bezeichnung = null;
        int count = 0;
        DateTime datum;
        int id = 0;
        List<Teilnehmer> listTeilnehmer = null;

        public string Bezeichnung
        {
            get
            {
                return bezeichnung;
            }

            set
            {
                bezeichnung = value;
            }
        }

        public int Count
        {
            get
            {
                return count;
            }

            set
            {
                count = value;
            }
        }

        public DateTime Datum
        {
            get
            {
                return datum;
            }

            set
            {
                datum = value;
            }
        }

        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public bool Add(Teilnehmer teilnehmer)
        {

            return true;
        }
        public override string ToString()
        {
            return Bezeichnung;
        }
    }
}
