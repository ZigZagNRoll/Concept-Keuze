using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CK.BL.Domain;
using CK.DAL;

namespace CK.BL
{
    public class VraagManager : IVraagManager
    {
        private readonly IVraagRepository repo;

        public VraagManager()
        {
            repo = new VraagRepository();
        }

        public void GeefGevolg(Gevolg gevolg)
        {
            throw new NotImplementedException();
        }

        public void GeefKeuze(Keuze keuze)
        {
            throw new NotImplementedException();
        }

        public void GeefNadeel(Nadeel nadeel)
        {
            throw new NotImplementedException();
        }

        public void GeefVoordeel(Voordeel voordeel)
        {
            throw new NotImplementedException();
        }

        public Vraag GetKeuzevraag(int vraagNummer)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Vraag> GetKeuzeVragen()
        {
            return repo.GetKeuzeVragen();
        }

        public Vraag GetPersoonVraag(int vraagNummer)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Vraag> GetPersoonVragen()
        {
            return repo.GetPersoonVragen();
        }

        public Gevolg maakGevolg(int gevolgNummer, string gevolgTekst, decimal kans, bool eindConditie)
        {
            throw new NotImplementedException();
        }

        public Keuze MaakKeuze(int keuzeNummer, string keuzeTekst)
        {
            throw new NotImplementedException();
        }

        public Vraag MaakVraag(int vraagNummer, string vraagTekst)
        {
            throw new NotImplementedException();
        }

        public Keuze ToonAntwoord(int keuzeNummer)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Keuze> ToonAntwoorden()
        {
            throw new NotImplementedException();
        }

        public Gevolg ToonGevolg(int gevolgNummer)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Gevolg> ToonGevolgen()
        {
            throw new NotImplementedException();
        }

        public Vraag ToonVraag(int vraagNummer)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Vraag> ToonVragen()
        {
            throw new NotImplementedException();
        }

        public void verwijderVraag(int vraagNummer)
        {
            throw new NotImplementedException();
        }

        public void wijzigVraag(Vraag vraag)
        {
            throw new NotImplementedException();
        }

        public void zetEindConditie(int gevolgNummer)
        {
            throw new NotImplementedException();
        }
    }
}
