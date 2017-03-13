using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CK.BL.Domain
{
    public class Keuze
    {
        public int KeuzeNummer { get; set; }
        public string KeuzeTekst { get; set; }
        public ICollection<Voordeel> Voordelen { get; set; }
        public ICollection<Nadeel> Nadelen { get; set; }
        public ICollection<Gevolg> Gevolgen { get; set; }

    }
}
