using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CK.BL.Domain
{
    public class Vraag
    {
        public int VraagNummer { get; set; }
        public string VraagTekst { get; set; }
        public ICollection<Keuze> Antwoorden { get; set; }
    }
}
