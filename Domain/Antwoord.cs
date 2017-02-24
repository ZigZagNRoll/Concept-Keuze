using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CK.BL.Domain
{
    public class Antwoord
    {
        public int AntwoordNummer { get; set; }
        public string AntwoordTekst { get; set; }
        public ICollection<Voordeel> Voordelen { get; set; }
        public ICollection<Nadeel> Nadelen { get; set; }
        public ICollection<Resultaat> Resultaten { get; set; }

    }
}
