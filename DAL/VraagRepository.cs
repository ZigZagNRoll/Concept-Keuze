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
            antwoorden = new List<Keuze>();
            persoonVragen = new List<Vraag>();
            keuzeVragen = new List<Vraag>();

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
            v1.Persoonvragen.Add(vr1);
            antwoorden.Add(k1);
            antwoorden.Add(k2);
            persoonVragen.Add(vr1);

            Vraag vr2 = new Vraag()
            {
                VraagNummer = 2,
                VraagTekst = "U staat op het punt een huis te kopen, waar wilt u gaan wonen?",
                Antwoorden = new List<Keuze>()
            };

            Keuze k3 = new Keuze()
            {
                KeuzeNummer = 3,
                KeuzeTekst = "Platteland",
                Voordelen = new List<Voordeel>(),
                Nadelen = new List<Nadeel>(),
                Gevolgen = new List<Gevolg>()
            };

            Voordeel vrdl1 = new Voordeel()
            {
                VoordeelNummer = 1,
                VoordeelTekst = "Goedkoper"
            };

            Voordeel vrdl2 = new Voordeel()
            {
                VoordeelNummer = 2,
                VoordeelTekst = "Minder druk"
            };

            Nadeel nadl1 = new Nadeel()
            {
                NadeelNummer = 1,
                NadeelTekst = "Minder bereikbaar"
            };

            Nadeel nadl2 = new Nadeel()
            {
                NadeelNummer = 2,
                NadeelTekst = "Minder werkgelegenheid"
            };

            Gevolg gvlg1 = new Gevolg()
            {
                GevolgNummer = 1,
                GevolgTekst = "U verongelukt tijdens de verbouwingen.",
                eindtekst = "In het ziekenhuis overlijd u aan uw verwondingen",
                EindConditie = true,
                Kans = 0.3,
                VolgendeVraagNummer = 0
            };

            Gevolg gvlg2 = new Gevolg()
            {
                GevolgNummer = 2,
                GevolgTekst = "U koopt een mooie villa voor een spot prijsje",
                eindtekst = "U leeft nog lang en gelukkig",
                EindConditie = true,
                Kans = 0.6,
                VolgendeVraagNummer = 0
            };

            k3.Voordelen.Add(vrdl1);
            k3.Voordelen.Add(vrdl2);
            k3.Nadelen.Add(nadl1);
            k3.Nadelen.Add(nadl2);
            k3.Gevolgen.Add(gvlg1);
            k3.Gevolgen.Add(gvlg2);
            vr2.Antwoorden.Add(k3);


            Keuze k4 = new Keuze()
            {
                KeuzeNummer = 4,
                KeuzeTekst = "Stad",
                Voordelen = new List<Voordeel>(),
                Nadelen = new List<Nadeel>(),
                Gevolgen = new List<Gevolg>()
            };

            Voordeel vrdl3 = new Voordeel()
            {
                VoordeelNummer = 3,
                VoordeelTekst = "Bereikbaarheid"
            };

            Voordeel vrdl4 = new Voordeel()
            {
                VoordeelNummer = 4,
                VoordeelTekst = "Werk mogelijkheid"
            };

            Nadeel nadl3 = new Nadeel()
            {
                NadeelNummer = 3,
                NadeelTekst = "Druk"
            };

            Nadeel nadl4 = new Nadeel()
            {
                NadeelNummer = 4,
                NadeelTekst = "Minder veilig"
            };

            Gevolg gvlg3 = new Gevolg()
            {
                GevolgNummer = 3,
                GevolgTekst = "U vind een klein appartementje dat juist groot genoeg is",
                eindtekst = "",
                EindConditie = false,
                Kans = 0.6,
                VolgendeVraagNummer = 2
            };

            Gevolg gvlg4 = new Gevolg()
            {
                GevolgNummer = 4,
                GevolgTekst = "U vind niet direct een woning en bent genoodzaakt om op hotel te gaan",
                eindtekst = "",
                EindConditie = false,
                Kans = 0.4,
                VolgendeVraagNummer = 2
            };
            k4.Voordelen.Add(vrdl3);
            k4.Voordelen.Add(vrdl4);
            k4.Nadelen.Add(nadl3);
            k4.Nadelen.Add(nadl4);
            k4.Gevolgen.Add(gvlg3);
            k4.Gevolgen.Add(gvlg4);
            vr2.Antwoorden.Add(k4);
            v1.Vragenlijst.Add(vr2);
            keuzeVragen.Add(vr2);
            antwoorden.Add(k3);
            antwoorden.Add(k4);

            Vraag vr3 = new Vraag()
            {
                VraagNummer = 3,
                VraagTekst = "U gaat op zoek naar een job?",
                Antwoorden = new List<Keuze>()
            };

            Keuze k5 = new Keuze()
            {
                KeuzeNummer = 5,
                KeuzeTekst = "Hoog geplaatst",
                Voordelen = new List<Voordeel>(),
                Nadelen = new List<Nadeel>(),
                Gevolgen = new List<Gevolg>()
            };

            Voordeel vrdl5 = new Voordeel()
            {
                VoordeelNummer = 5,
                VoordeelTekst = "Beter inkomen"
            };

            Voordeel vrdl6 = new Voordeel()
            {
                VoordeelNummer = 6,
                VoordeelTekst = "Meer voordelen"
            };

            Nadeel nadl5 = new Nadeel()
            {
                NadeelNummer = 5,
                NadeelTekst = "Drukker"
            };

            Nadeel nadl6 = new Nadeel()
            {
                NadeelNummer = 6,
                NadeelTekst = "Kans om werk te vinden is kleiner"
            };

            Gevolg gvlg5 = new Gevolg()
            {
                GevolgNummer = 5,
                GevolgTekst = "U vind een job als team manager, U verdiend een aardig salaris maar ben zelden thuis",
                eindtekst = "",
                EindConditie = false,
                Kans = 0.2,
                VolgendeVraagNummer = 3
            };

            Gevolg gvlg6 = new Gevolg()
            {
                GevolgNummer = 6,
                GevolgTekst = "U blijft op zoek naar een hoog geplaatste job maar vind geen werk plek",
                eindtekst = "De dop is niet genoeg om de maand mee rond te komen en u verdinkt in de schulden",
                EindConditie = true,
                Kans = 0.4,
                VolgendeVraagNummer = 3
            };

            k5.Voordelen.Add(vrdl5);
            k5.Voordelen.Add(vrdl6);
            k5.Nadelen.Add(nadl5);
            k5.Nadelen.Add(nadl6);
            k5.Gevolgen.Add(gvlg5);
            k5.Gevolgen.Add(gvlg6);
            vr3.Antwoorden.Add(k5);


            Keuze k6 = new Keuze()
            {
                KeuzeNummer = 6,
                KeuzeTekst = "Lage loon job",
                Voordelen = new List<Voordeel>(),
                Nadelen = new List<Nadeel>(),
                Gevolgen = new List<Gevolg>()
            };

            Voordeel vrdl7 = new Voordeel()
            {
                VoordeelNummer = 7,
                VoordeelTekst = "Gemakkelijk te vinden"
            };

            Voordeel vrdl8 = new Voordeel()
            {
                VoordeelNummer = 8,
                VoordeelTekst = "Vaste werk uren"
            };

            Nadeel nadl7 = new Nadeel()
            {
                NadeelNummer = 7,
                NadeelTekst = "Minder inkomen"
            };

            Nadeel nadl8 = new Nadeel()
            {
                NadeelNummer = 8,
                NadeelTekst = "Weinig kans om te groeien"
            };

            Gevolg gvlg7 = new Gevolg()
            {
                GevolgNummer = 7,
                GevolgTekst = "U vind snel een job en werkt hard, u wordt gepromoveerd tot manager van een fastfood filiaal",
                eindtekst = "",
                EindConditie = false,
                Kans = 0.4,
                VolgendeVraagNummer = 2
            };

            Gevolg gvlg8 = new Gevolg()
            {
                GevolgNummer = 8,
                GevolgTekst = "U vind snel een job en doet middelmatig werk, U verdient genoeg om de maand rond te komen",
                eindtekst = "",
                EindConditie = false,
                Kans = 0.4,
                VolgendeVraagNummer = 2
            };
            k6.Voordelen.Add(vrdl7);
            k6.Voordelen.Add(vrdl8);
            k6.Nadelen.Add(nadl7);
            k6.Nadelen.Add(nadl8);
            k6.Gevolgen.Add(gvlg7);
            k6.Gevolgen.Add(gvlg8);
            vr3.Antwoorden.Add(k6);
            v1.Vragenlijst.Add(vr3);
            keuzeVragen.Add(vr3);
            antwoorden.Add(k5);
            antwoorden.Add(k6);
        }

        public Vraag GetKeuzeVraag(int vraagNummer)
        {
            return keuzeVragen.Find(v => v.VraagNummer == vraagNummer);
        }

        public IEnumerable<Vraag> GetKeuzeVragen()
        {
            List<Vraag> lijst = new List<Vraag>();
            foreach(Verhaallijn lijn in verhaallijnen)
            {
                foreach(Vraag vraag in lijn.Vragenlijst)
                {
                    lijst.Add(vraag);
                }
            }
            return lijst;   
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

        public Keuze MaakKeuze(Keuze keuze, int vraagId)
        {
            Vraag vraag = this.GetPersoonVraag(vraagId);
            if (vraag.Antwoorden == null)
                vraag.Antwoorden = new List<Keuze>();
            vraag.Antwoorden.Add(keuze);
            return keuze;
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
            List<Keuze> keuzes = new List<Keuze>();
            foreach(Verhaallijn verhll in verhaallijnen)
            {
                foreach(Vraag pers in verhll.Persoonvragen)
                {
                    foreach(Keuze keus in pers.Antwoorden)
                    {
                        keuzes.Add(keus);
                    }
                }
                foreach(Vraag vraag in verhll.Vragenlijst)
                {
                    foreach(Keuze keus in vraag.Antwoorden)
                    {
                        keuzes.Add(keus);
                    }
                }
            }
            return keuzes;
        }

        public IEnumerable<Vraag> GetVerhlPersoonVragen(int verhlId)
        {
            IEnumerable<Vraag> verhaal = null;
            foreach (Verhaallijn story in verhaallijnen)
            {
                if (story.VerhaallijnNummer == verhlId)
                {
                    verhaal = story.Persoonvragen;
                }
            }
            return verhaal;
        }

        public Vraag GetVerhlPersoonVraag(int verhlId, int vraagNummer)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Vraag> GetverhlKeuzeVragen(int verhId)
        {
            IEnumerable<Vraag> verhaal = null;
            foreach(Verhaallijn story in verhaallijnen)
            {
                if (story.VerhaallijnNummer == verhId)
                {
                    verhaal = story.Vragenlijst;
                }
            }
            return verhaal;
        }

        public Vraag GetverhlKeuzeVraag(int verhlId, int vraagNummer)
        {
            throw new NotImplementedException();
        }

        public Vraag MaakPersoonVraag(Vraag persoonVraag, int storyId)
        {
            foreach(Verhaallijn story in verhaallijnen)
            {
                if(story.VerhaallijnNummer == storyId)
                {
                    story.Persoonvragen.Add(persoonVraag);
                }
            }
            return persoonVraag;
        }

        public Vraag MaakKeuzeVraag(Vraag keuzeVraag, int storyId)
        {
            foreach(Verhaallijn verhaal in verhaallijnen)
            {
                if(verhaal.VerhaallijnNummer == storyId)
                {
                    verhaal.Vragenlijst.Add(keuzeVraag);
                }
            }
            return keuzeVraag;
        }

        public Verhaallijn GetVerhaalLijn(int id)
        {
            return verhaallijnen.Find(v => v.VerhaallijnNummer == id);
        }

        public Vraag MaakPersoonVraag(string persoonVraag)
        {
            Vraag vraag = new Vraag()
            {
                VraagNummer = persoonVragen.Count() + 1,
                VraagTekst = persoonVraag
            };
            persoonVragen.Add(vraag);
            return vraag;
        }
    }
}
