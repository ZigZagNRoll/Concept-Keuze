using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CK.BL.Domain;

namespace CK.DAL
{
    public interface IVraagRepository
    {
        #region Vraag
        IEnumerable<Vraag> LeesVragen();
        // CRUD Vraag
        Vraag MaakVraag(Vraag vraag);
        Vraag LeesVraag(int vraagNummer);
        void UpdateVraag(Vraag vraag);
        void VerwijderVraag(int vraagNummer);
        #endregion

        #region Gevolg
        Gevolg maakGevolg(Gevolg gevolg);
        Gevolg LeesGevolg(int gevolgNummer);
        void UpdateGevolg(Gevolg gevolg);
        void verwijderGevolg(int gevolgNummer);
        #endregion

        #region Keuze
        Keuze MaakKeuze(Keuze keuze);
        Keuze LeesKeuze(int keuzeNummer);
        IEnumerable<Keuze> LeesKeuzes();
        void UpdateKeuze(Keuze keuze);
        void verwijderKeuze(int keuzeNummer);
        #endregion

        #region Verhaallijn
        IEnumerable<Vraag> GetPersoonVragen();
        Vraag GetPersoonVraag(int vraagNummer);
        IEnumerable<Vraag> GetKeuzeVragen();
        Vraag GetKeuzeVraag(int vraagNummer);
        #endregion
    }
}
