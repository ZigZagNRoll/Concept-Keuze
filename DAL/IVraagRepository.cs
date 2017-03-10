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
        void UpdateVraagEindCond(int vraagNummer);
        void VerwijderVraag(int vraagNummer);
        #endregion
    }
}
