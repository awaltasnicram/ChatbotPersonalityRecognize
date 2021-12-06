using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp5.Classy_Charaktery
{
    public class HAR : ICharakter
    {
        public HAR()
        {
      Nazwa = "Harmonijny";
       Slownik = new string[] {
        " tak " ,
        " dobrze" ,
        " zgadzam się" , " zgadzam sie" , " zgadzam" ,
        " niech tak będzie" , " niech tak bedzie" , " tak będzie" , " tak bedzie" ,
        " potwierdzam" ,
        " przyjdę" , " przyjde" ,
        " zrobię" , " zrobie" ,
        " mało" , " malo ", "malo." ,
        " troszeczkę" , " troszeczke" , " trochę" , " troche" , " troszkę" , " troszke" ,
        " delikatnie" ,
        " nie dużo" , " nie duzo" , " niedużo" , " nieduzo" ,
        " prawie" ,
        " lekko" ,
        " chyba" ,
        };
         Opis_Slaby = "Jesteś osobą, której kiedy zdarza się być w konflikcie, to starasz się z niego wybrnąć. Próbujesz zapobiegać konfliktom oraz kłótniom.\n";
        Opis_Sredni = "Jesteś osobą zazwyczaj spokojną, nie stwarzającą problemów, natomiast w przypadku problemu nie zawachasz się zadziałać w taki sposób, aby wyjść na tym na korzyśc. Umiesz dostosować się do sytuacji w przypadku, gdy nie kosztuje cię to wiele.\n";
        Opis_Duzy = "Jesteś osobą łagodzącą problemy poprzez dostosowanie się do sytuacji. Lubisz się usmiechać, co daje znak, że masz pozytywne nastawienie do danej sytuacji wobec innych. Bardzo trudno ci odmówić komuś innemu, nawet jeśli możesz zapłacić za to własnym kosztem. \n";
           
        }
        public string Nazwa { get; set; }
        public string[] Slownik { get; set; }
        public string Opis_Slaby { get; set; }
        public string Opis_Sredni { get; set; }
        public string Opis_Duzy { get; set; }
    }
}
