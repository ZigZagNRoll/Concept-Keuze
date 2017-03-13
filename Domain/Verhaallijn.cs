using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CK.BL.Domain
{
    public class Verhaallijn
    {
        public int VerhaallijnNummer { get; set; }
        public ICollection<Vraag> Vragenlijst { get; set; }
        public ICollection<Vraag> Persoonvragen { get; set; }
    }
}
