using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp5.Classy_Charaktery
{
    public class ZAD : ICharakter
    {
       public ZAD()
        {
            Nazwa = "Zadaniowy";
        Slownik = new string[] {
          " zadanie"," zadania"," zadaniu",
        " sprawy", " sprawa", " sprawę", " sprawie",
        " praktycznie", " praktyczna", " praktyczne", " praktyczny",
        " konkretnie", " konkretna", " konkretne", " konkretny",
        " dokładnie", " dokładne", " dokładna", " dokładny",
        " sedno", " sedna", " sednu",
        " istota", " istoty", " istote", " istocie", " istotom", " istotą",
        " meritum",
        " jądro", " jądra", " jądru", " jadro", " jadra", " jadru",
        " kwintesencja", " kwintesencji", " kwintesencje",
        " rdzeń", " rdzen",
        " konkluzja", " konkluzje", " konkluzji", " konkluzjo",
        " szybko", " szybka", " szybki", " szybkie",
        " przyspieszyć", " przyspieszyc", " przyspieszynie", " spieszyć", " spieszyc",
        " pospieszyc",  " pospieszyć",
        " efektywnie", " efektownie", " efektywny", " efektywna", " efektywne",
        " skończyć",  " skonczyc",  " skonczyć",   " skończyc",
        " kończyć",  " konczyc ",  " konczyć",   " kończyc", "konczyc.",
        " zakończyć",  " zakonczyc",  " zakonczyć",   " zakończyc",
        " dokończyć",  " dokonczyc",  " dokonczyć",   " dokończyc",
        " zamknąć", " zamknac", " zamknnięcie", " zamkniecie", " zamknięte", " zamkniete", " zamknięta", " zamknieta", " zamknięty", " zamkniety",
        " załatwić", " zalatwic", " załatwic", " zalatwić", " załatwiać", " zalatwiac", " załatwiac", " zalatwiać", " załatwienie"," zalatwienie", " załatwianie", " zalatwianie",
        " głowy", " glowy", " głowa", " głowa", " głowę", " głowe", " glowy", " glowy", " glowa",  " glowę", " glowe",
        " przerywac", " przerywać", " przerwanie", " przerwać", " przerwac",
        " na myśli",  " na mysli",
        " o co ci chodzi", " o co chodzi",
        " do sedna", " sedna", " sednu", " sednie",
        " meritum", " przejdźmy do meritum", " przejdzmy do meritum", " do meritum",
        " nie przerywaj mi", " nie przerywaj", " nie przerywać mi", " nie przerywać", " nie przerywac mi", " nie przerywac",
        " chcę skończyć", " chce skończyc", " chcę skonczyc", " chce skończyć", " chce skończyc", " chcę skonczyć",   
        " chcę to mieć już z głowy", " chce to miec juz z glowy", " z glowy", " z głowy", " z glową", " z głowa",
        };
       Opis_Slaby = "Jesteś osoba, która uważa, że jeśli to nie koniecznie, to nie otwierasz się przed innymi oraz nie nawiązujesz bliższych kontaktów. Preferujesz rozmowę tylko o swoich zainteresowaniach. Nastawiony jesteś na realizowanie poszczególnych zadań.\n";
        Opis_Sredni = "Jesteś konkretną osobą, stawiającą sobie okreslone cele i chcesz do nich dążyć, ale zdarza ci się niektóry sprawy odpuścić powodująć tym, że nie każdy twój " +
            "cel zostaje osiągnięty. W konwersacji z innymi przechodzisz zawsze do sedna tematu.\n";
     Opis_Duzy = "Jesteś bardzo konkretną osobą, która zawsze ma jasno określony cel i chcesz zawsze do nich dążyć przy okazji nie tracąć czasu na inne nie potrzebne rzeczy." +
            "W rozmowach z innymi przechodzisz zawsze do sedna tematu oraz tego samego oczekujesz w zamian. Każda rzecz starasz sie skończyć nie mająć za sobą innych zostawionych celów.\n";
            // na koncu opisów musi być \n
        }
        public string Nazwa { get; set; }
        public string[] Slownik { get; set; }
        public string Opis_Slaby { get; set; }
        public string Opis_Sredni { get; set; }
        public string Opis_Duzy { get; set; }
    }
}
