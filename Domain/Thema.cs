using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Thema
    {
        public int ThemaNummer { get; set; }
        public string ThemaNaam { get; set; }
        public ICollection<Vraag> Vragen { get; set; }

    }
}
