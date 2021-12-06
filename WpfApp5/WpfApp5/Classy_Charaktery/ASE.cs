using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp5.Classy_Charaktery
{
    public class ASE:ICharakter
    {

        public ASE()
        {
         Nazwa = "Asekuracyjny";
        Slownik = new string[] {
        " ale",
        " problem",
        " uważaj", " uwazaj",
        " niebezpieczeństwo", " niebezpieczenstwo",
        " zagrożenie", " zagrozenie",
        " ryzyko", " ryzykuje", " ryzykuję",
        " zaufany", " niezaufany", " nie zaufany", " zaufa",
        " bezpieczny", " nie bezpieczny", " niebezpieczny",
        " zabezpieczony", " nie zabezpieczony", " niezabezpieczony",
        " ubezpieczony",  " nieubezpieczony",  " nie ubezpieczony",
        " asekurować", " asekurowac", " asekuruje", " asekuruję",
        " gwarantować", " gwarantowac", " gwarancja", " gwarancji", " gwarancję", " gwarancje", " gwarantuje",  " gwarantuję",
        " gwarancja",
        " pewny", " pewna", " pewne", " zapewny", " zapewna", " zapewne",
        " pewność", " pewnosc", " pewny", " pewna", " pewne",
        " sprawdzony", " sprawdza", " sprawdzone", " sprawdzony",
        " sprawdzić", " sprawdzic", " sprawdzam",
        " przewidywać", " przewidywac", " przewiduje", " przewiduję",
        " rozważny", " rozwazny", " rozważam", " rozwazam", " rozważna", " rozwazna", " rozważne", " rozwazne",
        " roztropny", " roztropna", " roztropne",
        " ostrzegać", " ostrzegac", " ostrzegam", " ostrzega",
        " przestrzegać", " przestrzegac"," przestrzegam"
            };
      Opis_Slaby = "Jesteś osobą, która w razie problemów chętnie sięga po pomoc. Cechujesz się dążeniem do celu, zakładając najgorszy scenariusz.\n";
            Opis_Sredni = "Jesteś osobą, która ceni bezpieczeństwo, ale czasem zdarza ci się poczuć niepewność. Pomimo, że optymizm nie jest ci obcy, " +
            "to nie zawsze masz optymistyczne nastawienie.\n";
            Opis_Duzy = "Jesteś osobą, która uważa, że bezpieczeństwo jest bardzo ważne, stąd też jesteś bardzo ostrożną osobą. Gdy podejmujesz jakieś działania, to starasz się," +
            "aby żaden szczegół nie został pominiety.\n";
        }

        public string Nazwa { get; set; }
        public string[] Slownik { get; set; }
        public string Opis_Slaby { get; set; }
        public string Opis_Sredni { get; set; }
        public string Opis_Duzy { get; set; }
    }
}
