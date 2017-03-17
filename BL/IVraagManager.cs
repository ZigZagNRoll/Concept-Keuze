using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CK.BL.Domain;

namespace CK.BL
{
    public interface IVraagManager
    {
        #region Vraag
        IEnumerable<Vraag> ToonVragen();
        Vraag ToonVraag(int vraagNummer);
        Vraag MaakVraag(int vraagNummer, string vraagTekst);
        void wijzigVraag(Vraag vraag);
        void verwijderVraag(int vraagNummer);
        void GeefKeuze(Keuze keuze);
        void MaakPersoonVragen(int storyId);
        #endregion

        #region Keuze
        IEnumerable<Keuze> ToonAntwoorden();
        Keuze ToonAntwoord(int keuzeNummer);
        Keuze MaakKeuze(int keuzeNummer, string keuzeTekst);
        void GeefVoordeel(Voordeel voordeel);
        void GeefNadeel(Nadeel nadeel);
        void GeefGevolg(Gevolg gevolg);
        #endregion

        #region Gevolg
        IEnumerable<Gevolg> ToonGevolgen();
        Gevolg ToonGevolg(int gevolgNummer);
        Gevolg maakGevolg(int gevolgNummer, string gevolgTekst, decimal kans, bool eindConditie);
        void zetEindConditie(int gevolgNummer);
        #endregion

        #region Verhaallijn
        IEnumerable<Vraag> GetPersoonVragen();
        Vraag GetPersoonVraag(int vraagNummer);
        IEnumerable<Vraag> GetKeuzeVragen();
        Vraag GetKeuzevraag(int vraagNummer);
        IEnumerable<Vraag> GetVragenVerhaallijn(int verhaalId);
        IEnumerable<Keuze> GetKeuzesVerhaallijnVraag(int verhaalId, int VraagId);
        #endregion
    }
}
