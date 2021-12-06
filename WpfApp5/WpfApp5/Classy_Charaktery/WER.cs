using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp5.Classy_Charaktery
{
    public class WER : ICharakter
    {
      public WER()
        {
           Nazwa = "Weryfikujący";
      Slownik = new string[]{
        " nie " , " nie jest " , " nie może" , " nie moze " ,
        " błąd" , " blad" , " bład" , " bląd" ,
        " pomyłka" , " pomylka" , " wpadka" ,
        " wada" , " wade" , " wadę" , " wady" ,
        " niedokładność" , " niedokladnosc" , " niedokładnośc" , " niedokładnosć" , " niedokladność" , " niedokładny" , " niedokładna" , " niedokładne" , " niedokladny" , " niedokladna" , " niedokladne" ,
        " niedokładny", " niedokładna",  " niedokładne", " niedokladny", " niedokladna",  " niedokladne",
        " krzywe" , " krzywa" , " krzywy" ,
        " nierówne" , " nierówna" , " nierówny" , " nie równe" , " nie równa" , " nie równy" , " nierowne" , " nierowna" , " nierowny" , " nie rowne" , " nie rowna" , " nie rowny" ,
        " zepsute" , " zepsuta" , " zepsuty" ,
        " niedbałe" , " niedbała" , " niedbały" , " nie dbałe" , " nie dbała" , " nie dbały" ,  " niedbale" , " niedbala" , " niedbaly" , " nie dbale" , " nie dbala" , " nie dbaly" ,
        " różnica" , " różnice" , " różnicy" , " roznica" , " roznice" , " roznicy" , " rożnica" , " rożnice" , " rożnicy" , " róznica" , "róznice" , " róznicy" ,
        " nieprecyzyjny" , " nieprecyzyjna" , " nieprecyzyjne" , " nie precyzyjny" , " nie precyzyjna" , " nie precyzyjne" ,
        " jakość" , " jakosc" ,
        " opuszczono" , " opuszczona" , " opuszczony" , " opuszczone" ,
        " popatrz" , " patrz" ,
        " spójrz" , " spojrz" ,
        " przyjrzyj" ,
        " porównaj" , " porownaj" , " porównać" , " porownac" , " porownać" , " porównac" ,
        " zweryfikuj" , " weryfikuj" , " zweryfikuje" , " weryfikuje" ," zweryfikować" , " zweryfikowac" , " weryfikować" , " weryfikowac" ,
        " sprawdź" , " sprawdz" , " sprawdzić" , " sprawdzic" ,
        " zwróć uwagę" , " zwroc uwage" , " zwroc uwagę" , " zwroć uwagę" , " zwróć uwage" , " uwage" , " uwage" , " uwagę" , " uwagi" ,
        " naprawić" , " naprawic" , " naprawiać" , " naprawiac" , " naprawię" , " naprawia" , " naprawić" ,  " naprawic" , " naprawę" ,
        " poprawić" , " poprawic" , " poprawiać" , " poprawiac" , " poprawienie" , " poprawa" , " poprawe" , " poprawę" ,
        " posprzątać" , " posprzatac" , " posprzatać" , " posprzątac" , " sprzątać" , " sprzatac" , " sprzatać" , " sprzątac" ,
        " sprostować" , " sprostowac" , " prostować" , " prostowac" , " prostowanie" ,
        " wyprostować" , " wyprostowac" , " wyprostowanie" ,

        };
       Opis_Slaby = "Jesteś typem osoby spostrzegawczej, odczuwającej informowania innych o swoim zdaniu. Drażni cię gdy twoje uwagi są lekceważone.\n";
       Opis_Sredni = "Jesteś osobą spostrzegawczą, którą nie łatwo oszukać, ale też nie przywiązujesz się do tego. Zdarza się, że podejmujesz sprawdzone metody.\n";
        Opis_Duzy = "Jesteś bardzo spostrzegawczą osobą, która nie daje się oszukać, ponieważ weryfikujesz wszystko z czym masz do czynienia. Chcesz mówić prawdę oraz od innych masz " +
            "taki sam wymóg. Zwracasz uwage innym, jeżeli używają kłamstw jak i pomyłek. Lubisz, gdy rzeczy, których się podejmujesz są sprawdzone.\n";
            // na koncu opisów musi być \n
        }
        public string Nazwa { get; set; }
        public string[] Slownik { get; set; }
        public string Opis_Slaby { get; set; }
        public string Opis_Sredni { get; set; }
        public string Opis_Duzy { get; set; }
    }
}
