using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp5.Classy_Charaktery
{
    public class ROW : ICharakter
    {
        public ROW()
        {
           Nazwa = "Równoważący";
        Slownik = new string[] {
        " równowaga" , " rownowaga" , " równo" , " rowno" ,
        " waga" , " przeciwwaga" , " przeciw waga" ,
        " przewaga" , " prze waga" ,
        " sprawiedliwość" , " sprawiedliwosc" , " sprawiedliwosć" , " sprawiedliwosć" , " sprawiedliwy",  " sprawiedliwa", " sprawiedliwe",
        " kompensata" ,  " kompensaty" ,
        " rekompensata" ,  " rekompensaty" ,
        " zrekompensować" , " zrekompensować" , " rekompensować" , " zrekompensować", " kompensować" , " zrekompensować",
        " odwdzięczyć" ,  " odwdzieczyc" , " odwdzięczyć" ,  " odwdzieczyc" , " odwdzieczam" , " odwdzieczam" ,
        " oddać" , " oddac" , " dać" , " dac" , " dawać" , " dawac" , " dam", " oddam",
        " spłacić" , " splacic" , " spłacic" , " splacić" , " płacić" , " placic" , " płacic" , " placić" ,
        " wrócić" , " wrocic" , " wrócic" , " wrocić" , " zwrócić" , " zwrocic" , " zwrócic" , " zwrocić" , " wracam", " zwracam",
        " oceniać" , " oceniac" , " cenić" , " cenic" , " ocenić" , " ocenic" , " oceniam",
        " mierzyć" , " mierzyc" , " mierze", " mierzę",
        " ważyć" , " wazyc" , " ważyc" , " wazyć" , " ważenie" , " wazenie" , " waże", " ważę",
        " szacować" , " szacowac" , " szacowanie" , " szacuje", " szacuję",
        " opisywać" , " opisywac" , " opisać" , " opisac" , " opisanie", " opis", " opisuje", " opisuję",
        " kalibrować" , " kalibrowac" , " kalibracja" , " kalibrowanie" , " kalibruje", " kalibruję",
        " porównać" , " porownac" , " porównac" , " porownać" , " porównywać" , " porownywnac" , " porównywac" , " porownywać" , " porównuje", " porownuje", " porównuję", " porownuję",
        " właściwie" , " własciwie" , " wlasciwie" , " własciwie" ,"właściwy" , " własciwy" , " wlasciwy" , " własciwy",
        " uczciwie" , " uczciwy" , " uczciwa" , " uczciwe" ,
        " reguła" , " regula ","regula" , " regułe" , " regule" , " reguły" , " reguly" ,
        " zasada" , " zasady" ,
        " prawda" ,
        " konsekwentny" , " konsekwentna" , " konsekwentne" , " konsekwencja" , " konsekwencje" ,

        };
    Opis_Slaby = "Jesteś osobą, która jest za równouprawnienem w jak najbardziej szerokiej skali. Nie akceptujesz i starasz się zapobiegać czynnikom, które mają wpływ na brak równowagi oraz jakiejkolwiek niesprawiedliwości.\n";
    Opis_Sredni = "Jesteś osobą trzymającą się zasad jakie są. Żyjesz jak chcesz, ale jeśli chodzi o sprawiedliwość, to pozostawiasz je innym.\n";
    Opis_Duzy = "Jesteś osobą sprawiedliwą dążącą do utrzymania porządku oraz przestrzegania zasad. Nie lubisz ludzi łamiących zasady i starasz się każdego sprawiedliwie osądzać." +
                 "Nie lubisz poniżania innych, jesteś za równouprawnieniem, każdego cenisz tak samo.\n";
            // na koncu opisów musi być \n
        }
        public string Nazwa { get; set; }
        public string[] Slownik { get; set; }
        public string Opis_Slaby { get; set; }
        public string Opis_Sredni { get; set; }
        public string Opis_Duzy { get; set; }
    }
}
