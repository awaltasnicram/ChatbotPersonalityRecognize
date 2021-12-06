using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp5.Classy_Charaktery
{
    public class MAK : ICharakter
    {
        public MAK()
        {
             Nazwa = "Maksymalista";
        Slownik  = new string[] {
        " duży" , " duzy" , " duża" , " duza " , " duże" , " duze" , " dużo" , " duzo" ,
        " większy" , " wiekszy" , " wielki" ,
        " super" ,
        " wspaniały" , " wspanialy" ,
        " ogromny" ,
        " maksymalny" ,
        " mocny" ,
        " lepszy" ,
        " wielki" ,
        " wysoki" ,
        " wyżej" , " wyzej"

        };
        Opis_Slaby = "Jesteś osobą, którą denerwuje, gdy słyszy o trudnościach jakie musi napotkać w drodze do swojego celu. Jesteś typem optymisty, który dąży do rzeczy ekstremalnych.\n";
        Opis_Sredni = "Jesteś osobą dla której bardzo ważne jest uzyskiwanie dobrych wyników, pod warunkiem, że jest taka możliwość, ale nie jest to dla ciebie najważniejsze." +
            "Lubisz, gdy ktoś wymaga od ciebie więcej, ale nie chcesz by inni cie widzieli jako osobę, która zawsze radzi sobie ze wszystkim.\n";
         Opis_Duzy = "Jesteś osobą dążacą do uzyskanie najlepszych wyników w każdej dziedzinie jakiej się podejmujesz. Lubisz stawiać sobie wysokie cele, tym samym przywiązując" +
            "szczególna uwagę do nich. Chcesz otaczać się wokół osób z optymistycznym nastawieniem, aby ci mogli pomóc ci przełamywać wszelkiego typu trudności.\n";
            // na koncu opisów musi być \n
        }
        public string Nazwa { get; set; }
        public string[] Slownik { get; set; }
        public string Opis_Slaby { get; set; }
        public string Opis_Sredni { get; set; }
        public string Opis_Duzy { get; set; }
}
}
