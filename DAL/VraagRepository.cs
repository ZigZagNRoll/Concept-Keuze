using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CK.BL.Domain;

namespace CK.DAL
{
    public class VraagRepository : IVraagRepository
    {
        public Gevolg LeesGevolg(int gevolgNummer)
        {
            throw new NotImplementedException();
        }

        public Keuze LeesKeuze(int keuzeNummer)
        {
            throw new NotImplementedException();
        }

        public Vraag LeesVraag(int vraagNummer)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Vraag> LeesVragen()
        {
            throw new NotImplementedException();
        }

        public Gevolg maakGevolg(Gevolg gevolg)
        {
            throw new NotImplementedException();
        }

        public Keuze MaakKeuze(Keuze keuze)
        {
            throw new NotImplementedException();
        }

        public Vraag MaakVraag(Vraag vraag)
        {
            throw new NotImplementedException();
        }

        public void UpdateGevolg(Gevolg gevolg)
        {
            throw new NotImplementedException();
        }

        public void UpdateKeuze(Keuze keuze)
        {
            throw new NotImplementedException();
        }

        public void UpdateVraag(Vraag vraag)
        {
            throw new NotImplementedException();
        }

        public void verwijderGevolg(int gevolgNummer)
        {
            throw new NotImplementedException();
        }

        public void verwijderKeuze(int keuzeNummer)
        {
            throw new NotImplementedException();
        }

        public void VerwijderVraag(int vraagNummer)
        {
            throw new NotImplementedException();
        }
    }
}
