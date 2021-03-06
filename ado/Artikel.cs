﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ado
{
    class Artikel
    {
        public int ArtikelOid { get; set; }
        public String ArtikelNr { get; set; }
        public int ArtikelGruppe { get; set; }
        public String Bezeichnung { get; set; }
        public Int16 Bestand { get; set; }
        public Int16 Meldebestand { get; set; }
        public int Verpackung { get; set; }
        public Decimal VkPreis { get; set; }
        public DateTime LetzeEntnahme { get; set; }

        public override string ToString()
        {
            return ArtikelOid + " - " +Bezeichnung;
        }

        public String Display
        {
            get { return this.ArtikelNr + ": " + this.VkPreis.ToString(); }
        }
    }
}
