using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp5.Classy_Charaktery
{
    public class ODK : ICharakter
    {
        public ODK()
        {
              Nazwa = "Odkrywczy";
   Slownik = new string[] {
         " dlaczego" ,
        " odkryć" , " odkryc" , " odkrywać" , " odkrywac" , " odkrywam",
        " wyjaśnić" , " wyjasnic" , " wyjasnić" , " wyjaśnic", " wyjaśniać" , " wyjasniac" , " wyjasniać" , " wyjaśniac",  "wyjasniam", " wyjaśniam",  " wyjasnia",  " wyjaśnia",
        " sprawdzić" , " sprawdzic" , " sprawdzać" , " sprawdzac" , " sprawdze" , " sprawdzę" , " sprawdza", " sprawdzam ",
        " porównać" , " porownac" , " porównac" , " porownać" , " porównuje " , "porównuję " , "porownuję " , "porównam ",
        " rozpoznać" , "rozpoznac" , " rozpoznaje " , " rozpoznaję " ,
        " sklasyfikować" , " sklasyfikowac" , " klasyfikować" , " klasyfikowac" , " sklasyfikuje" , " sklasyfikuję" ,  " klasyfikuje" , " klasyfikuję" ,
        " zrozumieć" , " zrozumiec" , " rozumieć" , " rozumiec" ," rozumie" , " rozumię" ,
        " relacje" , " relację" , " relacja" ,
        " związki" , " zwiazki" , " związku" , " zwiazku" , " związek" , " zwiazek" ,
        "powiązania" , "powiazania" , "powiązanie" , "powiązanie" , "powiązany" , "powiazany" ,
        " zależności" , " zaleznosci" , " zależnosci" , " zalezności" , " zalezność" , " zaleznosc" , " zależnosc" , " zależnośc" ," zależnosć" ,
        " zależny" ," zależna" ," zależne" , " zalezny" ," zalezna" ," zalezne" ,
        " powody" ,  " powód" , " powod" ,
        " skutki" , " skutek" ,
        " nowy" , " nowa" , " nowe" ,
        " nieznany" , " nieznana" , " nieznane" ,
        " ciekawy" , " ciekawa" , " ciekawe" ,
        " interesujący" , " interesująca" , " interesujące" , " interesujacy" , " interesujaca" , " interesujace" , " interes",
        " relacje" , " relacja" ,
        " badać" , " badac" , " badania" , " badanie" ,
        " zapytać" ,  " zapytac" , " pytać" , " pytac" , " pytam",
        " wyjaśnić" , " wyjasnic" , " wyjaśnic" , " wyjasnić" , " objaśnić" , " objasnic" , " objaśnic" , " objasnić" ,
        " zrozumieć" , " zrozumiec" , " rozumieć" , " rozumiec" , " rozumie" , " rozumię" , " rozumiem",
        " powiedz mi jak" , " powiedz mi" ,

        };
            Opis_Slaby = "Jesteś osobą, która pragnie pozyskiwać odpowiedź na każde dręczące cię pytanie, dająć ci tym samym satysfakcję. Zadajesz dużo pytań w poszukiwaniu odpowiedzi. Jesteś typem dociekliwej oraz często zadającej pytania osoby w celu poszukiwania odpowiedzi na dręczące cię pytania.\n";
            Opis_Sredni = "Jesteś osobą, która czasem lubi doświadczać nowych rzeczy, ale również bez takiej opcji czujesz się normalnie. " +
            "Preferujesz spokojny tryb życia, ale lubisz poznawać nowe osoby, z którymi możesz przeprowadzić ciekawą rozmowę tym samym powiekszając swoje zainteresowania.\n";
            Opis_Duzy = "Jesteś osobą, która stara się odnaleść odpowiedź na kazdę dręczące cię pytanie, w taki sposób, aby w jak najlepiej zrozumieć to co cię otacza wokół." +
            "Lubisz nawiązywać nowe znajomości, co daje ci szanse na poznanie nowych osobowości i tym samym masz wiekszy obszar do dyskusji. Chcesz ciągle zajmować się jakimis rzeczami oraz " +
            "poznawać nowe osoby z innego otoczenia tak, aby nie czuć się znudzonym.\n";
            // na koncu opisów musi być \n

        }
        public string Nazwa { get; set; }
        public string[] Slownik { get; set; }
        public string Opis_Slaby { get; set; }
        public string Opis_Sredni { get; set; }
        public string Opis_Duzy { get; set; }
    }
}
