using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CK.BL;
using CK.BL.Domain;

namespace CK.UI_CA
{
    class Program
    {
        private static bool quit = false;
        private static readonly IVraagManager mgr = new VraagManager();

        static void Main(string[] args)
        {
            Console.WriteLine("Welkom tot het Keuze concept");
            Console.WriteLine("****************************");
            Console.WriteLine();

            while (!quit)
                ShowMenu();
        }

        public static void ShowMenu()
        {
            Console.WriteLine();
            Console.WriteLine("1: Toon alle vragen");
            Console.WriteLine("2: Toon alle keuzes");
            Console.WriteLine("3: Toon alle vragen van een verhaallijn");
            Console.WriteLine("4: Maak een nieuwe verhaallijn");
            Console.WriteLine("5: Toon de antwoorden van een vraag in een verhaallijn");
            Console.WriteLine("6: Speel een verhaallijn");
            Console.WriteLine("0: Quit");

            try
            {
                DetectMenuAction();
            }
            catch (Exception e)
            {
                Console.WriteLine();
                Console.WriteLine("Er heeft zich een onverwachte fout voorgedaan!");
                Console.WriteLine();
            }
        }

        private static void DetectMenuAction()
        {
            bool inValidAction = false;
            do
            {
                Console.Write("Keuze: ");
                string input = Console.ReadLine();
                int action;
                if (Int32.TryParse(input, out action))
                {
                    switch (action)
                    {
                        case 1:
                            ToonAlleVragen(); break;
                        case 2:
                            ToonAlleKeuzes(); break;
                        /*case 3:
                            ToonAlleVragenVerhaallijn(); break;
                        case 4:
                            MaakNieuweVerhaallijn(); break;
                        case 5:
                            ToonAntwoordenVraagVanVerhaallijn(); break;
                        case 6:
                            StartVerhaallijn(); break;*/
                        case 0:
                            quit = true;
                            return;
                        default:
                            Console.WriteLine("Geen geldige keuze!");
                            inValidAction = true;
                            break;
                    }
                }
            } while (inValidAction);
        }

        public static void ToonAlleVragen()
        {
            Console.WriteLine();
            foreach (Vraag vraag in mgr.GetPersoonVragen())
            {
                Console.WriteLine("{0}. {1}", vraag.VraagNummer, vraag.VraagTekst);
            }
            foreach (Vraag vraag in mgr.GetKeuzeVragen())
            {
                Console.WriteLine("{0}. {1}", vraag.VraagNummer, vraag.VraagTekst);
            }
        }

        public static void ToonAlleKeuzes()
        {
            Console.WriteLine();
            foreach (Keuze keus in mgr.ToonAntwoorden())
            {
                Console.WriteLine("{0}. {1}", keus.KeuzeNummer, keus.KeuzeTekst);
            }
        }
    }
}
