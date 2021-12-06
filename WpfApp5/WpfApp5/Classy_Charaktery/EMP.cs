using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp5.Classy_Charaktery
{
    public class EMP : ICharakter
    {
        public EMP()
        {
              Nazwa = "Empatyczny";
      Slownik = new string [] {
         " miły" , " mily" , " miła" , "mila" , "miło" , "milo" , "miłe" , "mile" ,
         " dzieci" , " dzieciom" ,
         " rodzina",
         " pies", " psy", " piesek",
         " kot", " koty", " kotki", " kotek", "kotów", "kotow",
         " ryba", " ryby", " rybki", " rybka",
         " koń ", " konie", " rybki", " rybka",
         " inne zwierzęta domowe", " inne zwierzęta domowe",
         " zranić", " zranic" , " ranić" , " ranic", " ranie", " ranię",
         " ty",
         " dla ciebie",
         " o was", " was", " dla was",
         " wy ",
         " cierpienie"," cierpić"," cierpic", " cierpie", " cierpię",
         " nie przyjemny"," nieprzyjemny",
         " dlaczego"," dla czego",
         " intencja"," intencje",
         " powód", " powod", " powody",
         " przyczyna", " przyczyny",
         " zwierzyć"," zwierzyc"," zmierzam",
         " otworzyc serce"," otworzyć serce", " otworzyć ", " otworzyc",
         " odsłonić"," odsłonic"," odslonić"," odslonic", " odsłaniam", " odslaniam",
         " zasłonić"," zasłonic"," zaslonić"," zaslonic", " zasłaniam", " zaslaniam",
         " ujawnić"," ujawnic", " ujawniam", " ujawniać", " ujawniac",
         " ponieważ"," poniewaz",
         " dlatego bo"," dlatego"," dla tego",
         " gdyz"," gdyż",
         " bo",
         " żeby"," zeby"," ażeby"," azeby",
         " sympatyczny"," sympatyczna",
         " osobista"," osobisty",
         " kondolencje"," kondolencja",
         " wspolczuje", " wspólczuje"," wspołczuje"," wspolczuję",
         " rozumiem",
         " przykro mi"," przykro"






        };
        Opis_Slaby = "Jesteś osobą, która często mówi o swoich intencjach oraz uczuciach względem innych zyskując tym samym zaufanie. Nie lubisz od razu przechodzić do sedna sprawy, wolisz pierwsze poznać osobę i dopiero potem przejść do sedna.\n";
        Opis_Sredni = "Jesteś osobą, która jest miła, czasem wrażliwa, mimo to w niektórych sytuacjach potrafisz zachować spokój i opanowanie. Zdarza ci się otwierać przed innymi oraz inni muszą zapracować na twoje zaufanie.\n";
        Opis_Duzy = "Jesteś osobą czułą dla innych, starającą się nie ranić innych, ponieważ przywiązujesz duża wagę do kontaktu z innymi. Zdarza ci się obdarzać ludzi szybkim zaufaniem, tym samym powodując, że rozmawiasz z nimi o swoich problemach, ale oczekujesz od nich tego samego.\n";
       
        }

        public string Nazwa { get; set; }
        public string[] Slownik { get; set; }
        public string Opis_Slaby { get; set; }
        public string Opis_Sredni { get; set; }
        public string Opis_Duzy { get; set; }
    }
}
