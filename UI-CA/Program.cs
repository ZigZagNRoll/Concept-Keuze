using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI_CA
{
    class Program
    {
        private static bool quit = false;

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
                        /*case 1:
                            ToonAlleVragen(); break;
                        case 2:
                            ToonAlleKeuzes(); break;
                        case 3:
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
    }
}
