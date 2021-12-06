using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp5.Classa_osoba;
using WpfApp5.Classa_Zapytania;
using WpfApp5.Classy_Charaktery;


namespace WpfApp5.Statyczne_Klasy
{
    public static class Automatyzacja
    {
        public static int  OkreslNatezenieCharakteru(ICharakter charakter , List<string> odpowiedzi,List<string> znalezioneSlowa)
        {
            int Natezenie = 0;
            string wszystkieOdpowiedzi = Automatyzacja.PolaczOdpowiedz(odpowiedzi);
            znalezioneSlowa.Clear();
           
           

            foreach (var slowo in charakter.Slownik)
            {
                if (wszystkieOdpowiedzi.Contains(slowo))
                {
                    Natezenie++;
                    znalezioneSlowa.Add(slowo);
                }
            }

           
            return Natezenie;
           
        }
        

        // laczy wszystkie odpowiedzi  typu charaktera w jeden dlugi string
        public static string PolaczOdpowiedz(List<string> odpowiedzi)
        {
            string wszystkieOdpowiedzi = "";

            foreach (var item in odpowiedzi)
            {
                wszystkieOdpowiedzi += item + " ";

            }
            return wszystkieOdpowiedzi;
        }

            public static string OdpowiedzGotowaDoWypisaniaPrzezUzytkownika(string odpowiedz)
        {
            return "Ja: " + odpowiedz + "\n";
        }
        public static string OdpowiedzGotowaDoWypisaniaPrzezBota(string odpowiedz)
        {
            return "Bot: " + odpowiedz + "\n";
        }

        //sprawdza slowa ze slownika
        public static bool SprawdzSlownik(string zdanie, string[] tablica)
        {
            bool sprawdz = false;
            foreach (var item in tablica)
            {
                if (zdanie.ToLower().Contains(item))
                {
                    sprawdz = true;
                }
            }
            return sprawdz;
        }

        public static List<Zapytania> GenerujPytania(List<Zapytania> listaWszystkichPytan)
        {
            List<Zapytania> listaWygenerowanychPytan = new List<Zapytania>();
            var rand = new Random();
            int liczba;
            for (int i = 0; i < 10; i++)
            {
                liczba = rand.Next(listaWszystkichPytan.Count);
                listaWygenerowanychPytan.Add(listaWszystkichPytan[liczba]);
                listaWszystkichPytan.RemoveAt(liczba);
            }
            return listaWygenerowanychPytan;
        }
    }
}
