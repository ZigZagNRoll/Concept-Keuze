using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CK.BL.Domain
{
    class Informatie
    {
        public bool Geslacht { get; set; }
        public int Kinderen { get; set; }
        public bool Werk { get; set; }
        public EnumWoonplaats Woonplaats { get; set; }
        public EnumLeeftijd Leeftijd { get; set; }

    }
}
