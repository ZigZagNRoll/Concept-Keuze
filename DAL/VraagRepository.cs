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
        private List<Verhaallijn> verhaallijnen;
        private List<Vraag> persoonVragen;
        private List<Vraag> keuzeVragen;
        private List<Keuze> antwoorden;

        public VraagRepository()
        {
            Seed();
        }

        private void Seed()
        {
            verhaallijnen = new List<Verhaallijn>();
            persoonVragen = new List<Vraag>();
            keuzeVragen = new List<Vraag>();
            antwoorden = new List<Keuze>();

            Verhaallijn v1 = new Verhaallijn()
            {
                VerhaallijnNummer = 1,
                Vragenlijst = new List<Vraag>(),
                Persoonvragen = new List<Vraag>()
            };
            verhaallijnen.Add(v1);

            Vraag vr1 = new Vraag()
            {
                VraagNummer = 1,
                VraagTekst = "Bent u een man of vrouw?",
                Antwoorden = new List<Keuze>()
            };
            Keuze k1 = new Keuze()
            {
                KeuzeNummer = 1,
                KeuzeTekst = "Man"
            };

            Keuze k2 = new Keuze()
            {
                KeuzeNummer = 2,
                KeuzeTekst = "Vrouw"
            };
            vr1.Antwoorden.Add(k1);
            vr1.Antwoorden.Add(k2);
            v1.Vragenlijst.Add(vr1);
            antwoorden.Add(k1);
            antwoorden.Add(k2);
            persoonVragen.Add(vr1);
        }

        public Vraag GetKeuzeVraag(int vraagNummer)
        {
            return keuzeVragen.Find(v => v.VraagNummer == vraagNummer);
        }

        public IEnumerable<Vraag> GetKeuzeVragen()
        {
            return keuzeVragen;
        }

        public Vraag GetPersoonVraag(int vraagNummer)
        {
            return persoonVragen.Find(v => v.VraagNummer == vraagNummer);
        }

        public IEnumerable<Vraag> GetPersoonVragen()
        {
            return persoonVragen;
        }

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

        public IEnumerable<Keuze> LeesKeuzes()
        {
            return antwoorden;
        }
    }
}
