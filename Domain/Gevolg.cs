using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CK.BL.Domain
{
    public class Gevolg
    {
        public int GevolgNummer { get; set; }
        public string GevolgTekst { get; set; }
        public decimal Kans { get; set; }
        public bool EindConditie { get; set; }

    }
}
