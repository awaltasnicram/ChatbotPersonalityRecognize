using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp5.Classy_Charaktery
{
   public  class DOM:ICharakter
    {
        public DOM()
        {
      Nazwa = "Dominujący";
       Slownik = new string[] {
             " ja ",
            " mój " , " moj " ," moje ",
            " my ",
            " nam ",
            " myśle ", " mysle ", " myślę ",
            " uważam" ," uwazam",
            " moim zdaniem",
            " według mnie"," wedlug mnie",
            " według mojej opinii", " wedlug mojej opinii",  " wedlug mojej opini", " według mojej opini",
            " masz rację",  " masz racje", " rację masz", " racje masz",
            " zgadam się z tobą", " zgadam sie z tobą", " zgadam się z toba", " zgadam sie z toba", " nie zgadam się z tobą", " nie zgadam sie z tobą", " nie zgadam się z toba", " nie zgadam sie z toba", " zgadam się", " zgadam sie",
            " chcę", " chce", " nie chcę", " nie chce",
            " potrzebuję", " potrzebuje", " nie potrzebuję", " nie potrzebuje",
            " zdecydowałem", " zdecydowałam", " zdecydowalem"," zdecydowalam", " decyduję",  " decyduje ",
            " wybrałem", " wybrałam", " wybralem"," wybralam",
            " kontrolować", " kontrolowac", " kontroluję", " kontroluje",
            " sterować"," sterowac", " steruje", " steruję",
            " kierować"," kierowac", " kieruje", " kieruję",
            " programować"," programowac", " programuje",  " programuję",
            " rekomendować"," rekomendowac", " rekomenduje", " rekomenduję",
            " polecać"," polecac"," polecam",
            " nowy ", " nowym",
            " nietknięty", " nietkniety"

        };
        Opis_Slaby = "Jesteś osobą, która chce byc widziana jako osoba będąca dominantem w grupie oraz niezależnym nieskrępowanym. Reagujesz na konflikt z osobą, która nie podporządkowuje się do jego zastosowań.\n";
        Opis_Sredni = "Jesteś osoba, która lubi wyrażać swoją opinie oraz lubi decydować, pomimo tego, że nie to najbardziej dla ciebie ważne.\n";
        Opis_Duzy = "Jesteś osoba, która lubi wyrażać jasno swoją opinię. Uwielbiasz zarządzać innymi, wywierać na nich wpływ, podejmować decyzję w ich imieniu." +
            " Doceniasz, gdy inni szanują ciebie i twoje zdanie oraz gdy nie krytukują twojego zdania. Czujesz się dobrze, gdy jesteś bezpośredni jak i również, " +
            "kiedy dominujesz i nikt inny nie kontroluje ciebie.\n";
          
    }

        public string Nazwa { get; set; }
        public string[] Slownik { get; set; }
        public string Opis_Slaby { get; set; }
        public string Opis_Sredni { get; set; }
        public string Opis_Duzy { get; set; }
    }
}
