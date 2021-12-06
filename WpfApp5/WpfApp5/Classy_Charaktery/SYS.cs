using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp5.Classy_Charaktery
{
    public class SYS : ICharakter
    {
        public SYS()
        {
            Nazwa = "Systematyczny";
    Slownik = new string[] {
       " początku" , " poczatku" , " początek" ," poczatek" ,
        " pierwsze" , " po pierwsze" , " pierwszy" ,
        " drugie" , " po drugie" , " drugi" , " drugii" ,
        " trzecie" , " po trzecie" , " trzeci" , " trzecii" ,
        " na końcu" , " na koncu" ,  " końcu" , " koncu" , " koniec",
        " teraz" ,
        " najpierw" ,
        " później" , " pozniej" , " poźniej" , " pózniej" , " późny",  " poźny", " pózny", " pozny",
        " wcześniej" , " wczesniej" , " wczesny",
        " miejsce" ,
        " czas" ,
        " porządek" , " porzadek" , " porządku" , " porzadku" ,
        " nieporządek" , " nieporzadek" ,  " nie porządek" , " nie porzadek" ,  " nie w porządku" , " nie w porzadku" ,  " nie wporządku" , " nie wporzadku" , " niewporządku" , " niewporzadku" ,
        " bałagan" , " balagan" ,
        " zaplanować" , " zaplanowac" , " planowac" , " planować" , " planowanie",
        " ustalić" , " ustalic" , " ustalanie" ," ustalenie" ,
        " posortować" ,  " posortowac" , " sortować" , " posortowac" , " sortowanie" ,
        " uporządkować" , " uporzadkowac" , " uporządkowac" , " uporzadkować" ,
        " ułożyć" , " ulozyc" ,  " ułożyc" ,  " ułozyć" , " ulożyć" ,
        " grupować" ,  " grupowanie" , " grupa",
        " klasyfikować" , " klasyfikowac" , " klasyfikacja" , " klasyfikacje" , " klasyfikowanie" ,
        " poziom" ,
        " krok" ,
        " chronologicznie" , " chronologiczny", " chronologiczna", " chronologiczne",
        " po kolei",
        " w kolejności" , " w kolejnosci" ,  " kolejność" , " kolejnosc" , " kolejnosć" , " kolejnośc" ,
        " na czas" , 

        " godzinie" , " godzinia" , " o godzinie" ,
        " o której" , " o ktorej" ,  " która" , " który", " które",
        " umówić" , " umowic" , " umowić" , " umówic" , " umowa" , " umówienie" ,  " umowienie" , " umowy" , " umowe" ,
        " rozpocznę" , " rozpoczne" , " rozpocząć" ,  " rozpoczac" , " rozpoczać" , " rozpocząc" , " rozpocznie" ,
        " zakończę" , " zakoncze" , " zakonczę" , " zakończe" , " zakończyć" , " zakonczyc" , " zakończyc" , " zakonczyć" ,
        " w jakim miejscu" , " miejscu" ," miejsce" ,

        };
        Opis_Slaby = "Jesteś osobą, która nie lubi, gdy ktoś się spóźnia, ponieważ sam jesteś punktualny. Drażni cię marnowanie czasu, ponieważ zawsze swój czas masz zaplanowany. Jesteś typem osoby, która ceni sobie porządek wokól siebie.\n";
         Opis_Sredni = "Jesteś osobą systematyczną starającą się utrzymać porządek w życiu, ale zdarzają ci się chwile słabości.\n";
         Opis_Duzy = "Jesteś bardzo systematyczną oraz punktualną osobą starającą się wszystko zaplanować. Nie lubisz osób, które mieszają ci w twoich zamierzonych planach, ponieważ" +
            "może powodować to wymuszenie na tobie do wykonania decyzji pochopnych, nieprzemyślanych, dlatego też każdą rzecz starasz się robić dokładnie.\n";
            // na koncu opisów musi być \n
        }
        public string Nazwa { get; set; }
        public string[] Slownik { get; set; }
        public string Opis_Slaby { get; set; }
        public string Opis_Sredni { get; set; }
        public string Opis_Duzy { get; set; }
    }
}
