using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CK.BL.Domain
{
    class Verhaallijn
    {
        public int VerhaallijnNummer { get; set; }
        public IEnumerable<Vraag> Vragenlijst { get; set; }
        public IEnumerable<Vraag> Persoonvragen { get; set; }
    }
}
