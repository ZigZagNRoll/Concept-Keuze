using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CK.BL.Domain
{
    public class Resultaat
    {
        public int ResultaatNummer { get; set; }
        public bool Geslacht { get; set; }
        public int Kinderen { get; set; }
        public bool Werk { get; set; }
        public Woonplaats Woonplaats { get; set; }


    }

    public enum Woonplaats
    {
        Stad,
        Plateland,
        Voorstad,
    }
}
