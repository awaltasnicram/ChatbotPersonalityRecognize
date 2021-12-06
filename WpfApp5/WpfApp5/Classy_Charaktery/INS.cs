using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp5.Classy_Charaktery
{
    public class INS : ICharakter
    {
        public INS()
        {
           Nazwa = "Inspirujący";
    Slownik =  new string[] {
        " pomysł " , " pomysl " ,
        " idea" ,
        " niespodzianka" ,
        " zagadka" ,
        " sekret" ,
        " tajemnica" ,
        " niespodziewany" , " nie spodziewany" ,
        " nieznany" ,
        " rewolucyjny" ,
        " inspirujący" , " inspirujacy" ,
        " zainspirować" , " zainspirowac" , " inspirować" , " inspirowac" , " inspiruje" , " inspiruję" ,
        " godny uwagi" ,
        " niesamowity" , " nie samowity" ,
        " fantastyczny" ,
        " ciekawy" ,
        " interesujący" , " interesujacy" ,
        " czarujący" , " czarujacy" ,
        " magiczny" ,
        " dziwny" ,
        " zagadkowy" ,
        " tajemniczy" ,
        " marzyć" , " marzyc" ," marze ", " marzę",
        " wymyślić" , " wymyślic" , " wymyslic" , " wymyslić" , " wymyślam", " wymyslam", " wymyśle", " wymyślę",
        " jakby tak" ,
        " co to masz" ,
        " co to takiego" ,
        " pokaż mi to" , " pokaz mi to" ,
        " skąd to wziąłeś" , " skad to wziales", " skąd", " skad",
        " skąd to masz" , " skad to masz", " skąd masz", " skad masz",
        " to jest ciekawe" , " jest ciekawe" ,  " to ciekawe" , " ciekawe" ,
        " gdzie to kupiłeś" , " gdzie to kupiles" , " kupiłeś" ," kupiles" , " kupiłes" ," kupileś" , " kupiłem", " kupilem",

        };
      Opis_Slaby = "Jesteś osobą, która postępuje spontanicznie, zamiast ustalić sobie jakiś cel. Chciałbyś być niezależny od danego rodzaju postępowania oraz chcesz być otoczony przez osoby podobne do ciebie.\n";
        Opis_Sredni = "Jesteś osobą na ogół spokojną, ale spontaniczne pomysły, które mogą rozwiązać problem nie są ci obce. Lubisz nowe ciekawe doznania, ale" +
            "mimo to patrzysz też na innych, aby nie spodziewać sie niespodziewanych rzeczy.\n";
       Opis_Duzy = "Jesteś osobą kreatywną oraz pomysłową szukającą inspiracji w nowych pomysłach. Bardzo lubisz niespodziewane wydarzenia, spontaniczność oraz ciekawe rzeczy." +
            "Chcesz, aby osoby, które otaczają się w twoim środowisku również były takie jak ty.\n";
            // na koncu opisów musi być \n
        }
        public string Nazwa { get; set; }
        public string[] Slownik { get; set; }
        public string Opis_Slaby { get; set; }
        public string Opis_Sredni { get; set; }
        public string Opis_Duzy { get; set; }
    }
}
