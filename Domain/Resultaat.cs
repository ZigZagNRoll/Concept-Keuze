using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Resultaat
    {
        public int ResultaatNummer { get; set; }
        public string ResultaatTekst { get; set; }
        public decimal Kans { get; set; }
        public bool EindConditie { get; set; }

    }
}
