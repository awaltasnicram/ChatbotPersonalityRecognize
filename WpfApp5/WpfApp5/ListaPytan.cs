using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using WpfApp5.Classa_Zapytania;

namespace WpfApp5
{
    public partial class MainWindow : Window
    {
        public static List<Zapytania> ListaZapytan = new List<Zapytania> {
              new Zapytania {
                Temat="Muzyka",
                GlownePytanie="Lubisz słuchać muzyki ?",
                Odp_Na_Pyt_Uzytkownika="Tak.",

                Pyt_Do_Odp_Pozytywna1="Jaki jest Twój ulubiony wykonawca lub zespół?",
                Pyt_Do_Odp_Pozytywna1_Synonim="Masz jakiegoś ulubionego wykonawcę lub zespół?",
                Odp_Na_Pyt_Uzytkownika1="Depeche Mode.",

                Pyt_Do_Odp_Pozytywna2="Co to za gatunek muzyki jest, który lubisz ?",
                Pyt_Do_Odp_Pozytywna2_Synonim="Ten zespół, który lubisz, to jaki jest to gatunek muzyczny ?", // Rock, a depeche mode, to jaki gatunek ?
                  Odp_Na_Pyt_Uzytkownika2="Rock.",


                Pyt_Do_Odp_Negatywna="Dlaczego nie ?"
                            },

             new Zapytania {
                Temat="Rodzenstwo",
                GlownePytanie="Masz może jakieś rodzeństwo ?",
                Odp_Na_Pyt_Uzytkownika="Nie,",

                Pyt_Do_Odp_Pozytywna1="z rodzeństwem podobno jest fajnie. Cieszysz się z posiadania rodzenstwa ?",
                Pyt_Do_Odp_Pozytywna1_Synonim="cieszysz się z posiadania rodzenstwa ?",
                 Odp_Na_Pyt_Uzytkownika1="Tak.",

                Pyt_Do_Odp_Pozytywna2="To bardzo wazne, niektórzy jednak nie doceniaja swojego rodzenstwa. Rozumiem, a posiadasz może własną rodzinę ?",
                Pyt_Do_Odp_Pozytywna2_Synonim="Rozumiem, a posiadasz może własną rodzinę ?",
                  Odp_Na_Pyt_Uzytkownika2="Nie.",

                Pyt_Do_Odp_Negatywna="Dlaczego nie ?"
                            },


              new Zapytania {
                Temat="ImieIleLat",
                GlownePytanie="Jak masz na imie ?",
                Odp_Na_Pyt_Uzytkownika="Jestem Kamil,",

                Pyt_Do_Odp_Pozytywna1="ile masz lat ?",
                Pyt_Do_Odp_Pozytywna1_Synonim="w jakim wieku jesteś?",
                  Odp_Na_Pyt_Uzytkownika1="Mam 2 lata,",

                Pyt_Do_Odp_Pozytywna2="nie wiele wiem o tobie, opowiesz mi cośo osobie ?",
                Pyt_Do_Odp_Pozytywna2_Synonim="mało mi o sobie powiedziałeś, opowiesz mi coś o osobie ?",
                  Odp_Na_Pyt_Uzytkownika2="Nie mam nic do powiedzenia",

                Pyt_Do_Odp_Negatywna="Dlaczego ?"
                            },


               new Zapytania {
                Temat="Praca",
                GlownePytanie="Gdzie pracujesz ?",
                Odp_Na_Pyt_Uzytkownika="Nie pracuje.",

                Pyt_Do_Odp_Pozytywna1="Czym się tam zajmujesz ?",
                Pyt_Do_Odp_Pozytywna1_Synonim="Jakie zadania tam pełnisz ?",
                  Odp_Na_Pyt_Uzytkownika1="Żadne.",

                Pyt_Do_Odp_Pozytywna2="Jestes zadowolony ze swojej pracy ?",
                Pyt_Do_Odp_Pozytywna2_Synonim="I jak oceniasz swoją pracę, jest fajna czy nie ?",
                  Odp_Na_Pyt_Uzytkownika2="Nie mogę ocenić.",

                Pyt_Do_Odp_Negatywna="To dlaczego ?"
                            },

                new Zapytania {
                Temat="Filmy",
                GlownePytanie="Lubisz oglądasz filmy ?",
                Odp_Na_Pyt_Uzytkownika="Tak.",

                Pyt_Do_Odp_Pozytywna1="Jaki film lubisz ogladać ?",
                Pyt_Do_Odp_Pozytywna1_Synonim="Jaki film ci się podoba ?",
                 Odp_Na_Pyt_Uzytkownika1="Szybcy i wsciekli.", 

                Pyt_Do_Odp_Pozytywna2="Filmy akcji mnie fascynuja, a ciebie ?",
                Pyt_Do_Odp_Pozytywna2_Synonim="A jakieś inne filmy jescze lubisz ?",
                  Odp_Na_Pyt_Uzytkownika2="Tylko ten",

                Pyt_Do_Odp_Negatywna="Dlaczego ?"
                            },

                 new Zapytania {
                Temat="MiastoCzyWies",
                GlownePytanie="Wolisz miasto czy wieś ?",
                Odp_Na_Pyt_Uzytkownika="Preferuje wieś, ponieważ jest cisza.",

                Pyt_Do_Odp_Pozytywna1="Uważasz, że jest tam fajnie ?",
                Pyt_Do_Odp_Pozytywna1_Synonim="I jak twierdzisz, jest tam w porządku ?",
                 Odp_Na_Pyt_Uzytkownika1="Bardzo dobrze.",

                Pyt_Do_Odp_Pozytywna2="Preferujesz miec dom na wsi czy mieszkanie w mieście ?",
                Pyt_Do_Odp_Pozytywna2_Synonim="Wolisz miec mieszkanie w mieście czy dom na wsi ??",
                  Odp_Na_Pyt_Uzytkownika2="Na wsi.",

                Pyt_Do_Odp_Negatywna="Czemu tak twierdzisz ?"
                            },


                  new Zapytania {
                Temat="Psy",
                GlownePytanie="Masz może psa ?",
                Odp_Na_Pyt_Uzytkownika="Ja mam i bardzo się cieszę z tego powodu.",

                Pyt_Do_Odp_Pozytywna1="Fajna sprawa go mieć, prawda ?",
                Pyt_Do_Odp_Pozytywna1_Synonim="Cieszysz sie z tego, że go masz ?",
                  Odp_Na_Pyt_Uzytkownika1="Tak.",

                Pyt_Do_Odp_Pozytywna2="Jakie ma imię twój zwierzak ?",
                Pyt_Do_Odp_Pozytywna2_Synonim="Jak się nazywa twój zwierzak ?",
                  Odp_Na_Pyt_Uzytkownika2="Mój pies wabi się Tori.",

                Pyt_Do_Odp_Negatywna="Czemu tak uważasz ?"
                            },


                   new Zapytania {
                Temat="Koty",
                GlownePytanie="Masz może kota ?",
                Odp_Na_Pyt_Uzytkownika="Ja nie mam szczerze mówiąc.",

                Pyt_Do_Odp_Pozytywna1="Fajna sprawa go mieć, prawda ?",
                Pyt_Do_Odp_Pozytywna1_Synonim="Cieszysz sie z tego, że go masz ?",
                  Odp_Na_Pyt_Uzytkownika1="Nie mam.",

                Pyt_Do_Odp_Pozytywna2="Jakie ma imię twój zwierzak ?",
                Pyt_Do_Odp_Pozytywna2_Synonim="Jak się nazywa twój zwierzak ?",
                 Odp_Na_Pyt_Uzytkownika2="Nie ma imienia.",

                Pyt_Do_Odp_Negatywna="Dlaczego ?"
                            },

                    new Zapytania {
                Temat="FastFood",
                GlownePytanie="Lubisz jeśc fast food'y ?",
                Odp_Na_Pyt_Uzytkownika="Uwielbiam jeść kebaby.",

                Pyt_Do_Odp_Pozytywna1="Jaki fast food lubisz najbardziej ?",
                Pyt_Do_Odp_Pozytywna1_Synonim="Jaki rodzaj fast food'a lubisz najbardziej jeść ?",
                  Odp_Na_Pyt_Uzytkownika1="Kebab.",

                Pyt_Do_Odp_Pozytywna2="Sądzę, że fast food jest nie zdrowy, od czasu do czasu można zjeść, też tak myślisz ?",
                Pyt_Do_Odp_Pozytywna2_Synonim=" Uważam, że fast food jest nie zdrowy, ale czasem nie da się powstrzymać, też tak uważasz ?",
                  Odp_Na_Pyt_Uzytkownika2="Tak uważam.",

                Pyt_Do_Odp_Negatywna="Czemu ?"
                            },

                      new Zapytania {
                Temat="Wakacje",
                GlownePytanie="Jeździsz na wakacje za granicę ?",
                Odp_Na_Pyt_Uzytkownika="Nie mam czasu.",

                Pyt_Do_Odp_Pozytywna1="Gdzie jeździsz najczęściej ?",
                Pyt_Do_Odp_Pozytywna1_Synonim="A zazwyczaj to jaki kraj ?",
                  Odp_Na_Pyt_Uzytkownika1="Nie jeżdzę.",

                Pyt_Do_Odp_Pozytywna2="I jak ci się tam podoba ?",
                Pyt_Do_Odp_Pozytywna2_Synonim="Podoba ci się tam ?",
                  Odp_Na_Pyt_Uzytkownika2="Nie mam zdania, bo nie jeżdzę.",

                Pyt_Do_Odp_Negatywna="A to jaki jest tego powód ?"
                            },


                new Zapytania {
                Temat="Sport",
                GlownePytanie="Uprawiasz jakieś sporty ?",
                Odp_Na_Pyt_Uzytkownika="Nie uprawiam sportu",

                Pyt_Do_Odp_Pozytywna1="Od jak dawna uprawiasz ten sport ?",
                Pyt_Do_Odp_Pozytywna1_Synonim="Jak długo uprawiasz ten sport?",
                 Odp_Na_Pyt_Uzytkownika1="Nie uprawiam sportu.",

                Pyt_Do_Odp_Pozytywna2="Zapewne kondycja ci dopisuje, prawda ?",
                Pyt_Do_Odp_Pozytywna2_Synonim="Pewnie jesteś w świetnie formie, mam rację ?",
                  Odp_Na_Pyt_Uzytkownika2="Ja nie.",

                Pyt_Do_Odp_Negatywna="Dlaczego tak jest ?"
                            },

                new Zapytania {
                Temat="Jezyk",
                GlownePytanie="Umiesz jakieś języki poza Polskim ?",
                Odp_Na_Pyt_Uzytkownika="Tylko Polski umiem.",

                Pyt_Do_Odp_Pozytywna1="W jakim stopniu umiesz język obcy?",
                Pyt_Do_Odp_Pozytywna1_Synonim="Jaki jest poziom twojego języka obcego ?",
                  Odp_Na_Pyt_Uzytkownika1="Słaby.",

                Pyt_Do_Odp_Pozytywna2="Od kiedy uczysz się języków obcych ?",
                Pyt_Do_Odp_Pozytywna2_Synonim="Od jak dawna uczysz się języków obcych ?",
                  Odp_Na_Pyt_Uzytkownika2="Nie uczę się.",

                Pyt_Do_Odp_Negatywna="To czemu ?"
                            },

                new Zapytania {
                Temat="kawa",
                GlownePytanie="Lubisz pić kawę?",
                Odp_Na_Pyt_Uzytkownika="Nie",

                Pyt_Do_Odp_Pozytywna1="Często pijesz kawę?",
                Pyt_Do_Odp_Pozytywna1_Synonim="Ile razy dziennie pijesz kawę?",
                 Odp_Na_Pyt_Uzytkownika1="Nie piję.",

                Pyt_Do_Odp_Pozytywna2="I ona naprawdę tak pobudza ?",
                Pyt_Do_Odp_Pozytywna2_Synonim="Jesteś po niej pobudzony ?",
                  Odp_Na_Pyt_Uzytkownika2="Nie.",

                Pyt_Do_Odp_Negatywna="Czemu ?"
                            },

                new Zapytania {
                Temat="prawo jazdy",
                GlownePytanie="Masz prawo jazdy ?",
                Odp_Na_Pyt_Uzytkownika="Nie mam.",

                Pyt_Do_Odp_Pozytywna1="Jakie kategorie prawa jazdy posiadasz ?",
                Pyt_Do_Odp_Pozytywna1_Synonim="Od jak dawna jeździsz ?",
                 Odp_Na_Pyt_Uzytkownika1="Nie mam prawa jazdy.",

                Pyt_Do_Odp_Pozytywna2="Twoim zdaniem dobrze prowadzisz ?",
                Pyt_Do_Odp_Pozytywna2_Synonim="Dobrze radzisz sobie za kierownicą ?",
                 Odp_Na_Pyt_Uzytkownika2="Nie.",

                Pyt_Do_Odp_Negatywna="Czemu ?"
                            },

                new Zapytania {
                Temat="pogoda",
                GlownePytanie="Jaka u ciebie jest dziś pogoda ?",
                Odp_Na_Pyt_Uzytkownika="U mnie słonecznie.",

                Pyt_Do_Odp_Pozytywna1="I co robisz w taką pogodę ?",
                Pyt_Do_Odp_Pozytywna1_Synonim="I co aktualnie robisz ?",
                  Odp_Na_Pyt_Uzytkownika1="Piszę z tobą.",

                Pyt_Do_Odp_Pozytywna2="Masz jakieś plany w najbliższym czasie ?",
                Pyt_Do_Odp_Pozytywna2_Synonim="Jakieś plany w najbliższym czasie ?",
                 Odp_Na_Pyt_Uzytkownika2="Nie mam planów.",

                Pyt_Do_Odp_Negatywna="Dlaczego ?"
                            }




            };
    }
}
