using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Vraag
    {
        public int VraagNummer { get; set; }
        public string VraagTekst { get; set; }
        public Thema Thema { get; set; }

        public ICollection<Antwoord> Antwoorden { get; set; }
    }
}
