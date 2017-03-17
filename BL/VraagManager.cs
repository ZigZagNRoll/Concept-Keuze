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

        public IEnumerable<Keuze> GetKeuzesVerhaallijnVraag(int verhaalId, int VraagId)
        {
            IEnumerable<Vraag> persvragen = repo.GetVerhlPersoonVragen(verhaalId);
            IEnumerable<Vraag> keuzevragen = repo.GetverhlKeuzeVragen(verhaalId);
            var vragen = persvragen.Concat(keuzevragen);
            IEnumerable<Keuze> keuzes = null;

            foreach(Vraag vraag in vragen)
            {
                if(vraag.VraagNummer == VraagId)
                {
                    keuzes = vraag.Antwoorden;
                }
            }
            return keuzes;
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

        public IEnumerable<Vraag> GetVragenVerhaallijn(int verhaalId)
        {
            IEnumerable<Vraag> persvragen = repo.GetVerhlPersoonVragen(verhaalId);
            IEnumerable<Vraag> keuzevragen = repo.GetverhlKeuzeVragen(verhaalId);
            var vragen = persvragen.Concat(keuzevragen);

            return vragen;

        }

        public Gevolg maakGevolg(int gevolgNummer, string gevolgTekst, decimal kans, bool eindConditie)
        {
            throw new NotImplementedException();
        }

        public Keuze MaakKeuze(int keuzeNummer, string keuzeTekst)
        {
            throw new NotImplementedException();
        }

        public void MaakPersoonVragen(int storyId)
        {
            foreach(Vraag vraag in repo.GetPersoonVragen())
            {
                repo.MaakKeuzeVraag(vraag, storyId);
            }
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
            return repo.LeesKeuzes();
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
