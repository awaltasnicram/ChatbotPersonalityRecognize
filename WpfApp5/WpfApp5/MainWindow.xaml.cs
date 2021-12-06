using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WpfApp5.Classa_osoba;
using WpfApp5.Classa_Zapytania;
using WpfApp5.Classy_Charaktery;
using WpfApp5.Statyczne_Klasy;


namespace WpfApp5
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        bool poczatek =true; //zmiena sprawdzajaca czy to poczatek rozmowy
        bool odpNegatywna = false;
       
  
        int plot = 0;//zmienna sprawdza w ktorej momencie rozmowy w trakcie tematu jesteśmy
        string odpowiedz;
        public static List<Zapytania>  pytaniaNaSesji= new List<Zapytania>();
     
   

        public MainWindow()
        {
            InitializeComponent();
            Osoba.UstawOsoba();
            pytaniaNaSesji= Automatyzacja.GenerujPytania(ListaZapytan);
           



        }

        private void _btChatWyslij_Click(object sender, RoutedEventArgs e)
        {
            //przywitanie |poczatek rozmowy
            if (poczatek == true)
            {


                odpowiedz = _tbCzatWpisz.Text;
                Osoba.Odpowiedzi.Add(odpowiedz.ToString());
                _tbCzat.Text += Automatyzacja.OdpowiedzGotowaDoWypisaniaPrzezUzytkownika(odpowiedz);

                _tbCzatWpisz.Text = "";

                if (odpowiedz.Contains("Hej") | odpowiedz.Contains("hej"))
                {
                    _tbCzat.Text += "Bot: Hej. Wszystko u ciebie w porządku?\n";

                }
                else if (odpowiedz.Contains("Wita") | odpowiedz.Contains("wita"))
                {
                    _tbCzat.Text += "Bot: Witaj. Jak sie dziś czujesz?\n";
                }
                else if (odpowiedz.Contains("Siema") | odpowiedz.Contains("siema"))
                {
                    _tbCzat.Text += "Bot: Hej. Wszystko u ciebie w porządku?\n";
                }
                else if (odpowiedz.Contains("Elo") | odpowiedz.Contains("elo"))
                {
                    _tbCzat.Text += "Bot: Cześć. Wszystko u ciebie w porządku?\n";
                }
                else if (odpowiedz.Contains("dzień") | odpowiedz.Contains("dzien")| odpowiedz.Contains("Dzień") | odpowiedz.Contains("Dzien"))
                {
                    _tbCzat.Text += "Bot: Dzień dobry.Jak sie dziś czujesz?\n";

                }
                else if (odpowiedz.Contains("Cze") | odpowiedz.Contains("cze"))
                {
                    _tbCzat.Text += "Bot: Cześć. Wszystko u ciebie w porządku?\n";
                }
                else
                {
                    _tbCzat.Text += "Bot: Witaj. Jak sie dziś czujesz?\n";

                }
                // _tbCzat.Text += Automatyzacja.OdpowiedzGotowaDoWypisaniaPrzezBota(pytaniaNaSesji[0].GlownePytanie);
                poczatek = false;
                plot = 0;//zmiana z 1 na 0
            }
            else {//po przywitaniu | dalsza czesc rozmowy

            
                //odbieranie odpowiedzi użytkownika
                odpowiedz = _tbCzatWpisz.Text;
                Osoba.Odpowiedzi.Add(odpowiedz.ToString());
                _tbCzat.Text += Automatyzacja.OdpowiedzGotowaDoWypisaniaPrzezUzytkownika(odpowiedz);

                _tbCzatWpisz.Text = "";

                odpowiedz = odpowiedz + " "; //!!!!!!!!!!!!!!!!!!!!!!! tu zeby szukało tak z 2 ze spacja i nie ze spacja
                odpowiedz = " "+odpowiedz; //!!!!!!!!!!!!!!!!!!!!!!! tu zeby szukało tak z 2 ze spacja i nie ze spacja


                //jeśli koniec programu
                if (pytaniaNaSesji.Count == 0)
                {
                    _btChatWyslij.IsEnabled = false;
                    _tbCzat.Text += "Bot: Przepraszam, ale muszę kończyć, bardzo się spieszę. Miło było cie poznać. Do zobaczenia.";
                }
                else
                {
                    if (Automatyzacja.SprawdzSlownik(odpowiedz, UzytkownikKonczySlowami) == true)
                    {
                        _tbCzat.Text += "Bot: Rozumiem. Do zobaczenia.";
                        _btChatWyslij.IsEnabled = false;
                    }
                    else if (plot == 0)//jeśli temat sie zaczoł zadanie głowne pytanie
                    {
                        if (odpowiedz.Contains("?"))
                        {
                            _tbCzat.Text += "Bot:U mnie wszystko w porządku.\n";
                        }
                        _tbCzat.Text += Automatyzacja.OdpowiedzGotowaDoWypisaniaPrzezBota(pytaniaNaSesji[0].GlownePytanie); //zadanie pytania
                        plot++;// przejscie do kolejne czesci tematu

                    }
                    else if (plot == 1)// kontynuacja tematu
                    {


                        if(odpowiedz.Contains("?") == true & Automatyzacja.SprawdzSlownik(odpowiedz, OdpNG) == true)
                        {
                            _tbCzat.Text += Automatyzacja.OdpowiedzGotowaDoWypisaniaPrzezBota(pytaniaNaSesji[0].Odp_Na_Pyt_Uzytkownika); //odpowiedz bota
                            pytaniaNaSesji.RemoveAt(0);//usuwanie tematu
                            plot = 0;
                            if (pytaniaNaSesji.Count >= 1)
                            {
                                _tbCzat.Text += Automatyzacja.OdpowiedzGotowaDoWypisaniaPrzezBota(pytaniaNaSesji[0].GlownePytanie);
                                plot++;
                            }
                            else
                            {
                                _tbCzat.Text += "Bot: Do zobaczenia.";
                                _btChatWyslij.IsEnabled = false;

                            }
                         
                        }
                        else if (odpowiedz.Contains("?"))
                        {
                            _tbCzat.Text += Automatyzacja.OdpowiedzGotowaDoWypisaniaPrzezBota(pytaniaNaSesji[0].Odp_Na_Pyt_Uzytkownika);//odpowiedz
                            _tbCzat.Text += Automatyzacja.OdpowiedzGotowaDoWypisaniaPrzezBota(pytaniaNaSesji[0].Pyt_Do_Odp_Pozytywna1);//kolejne pytanie
                            plot++;//przejscie do nastepnej czesci tematu 

                        }
                        else if (Automatyzacja.SprawdzSlownik(odpowiedz, OdpNG) == true)
                        {
                            _tbCzat.Text += Automatyzacja.OdpowiedzGotowaDoWypisaniaPrzezBota(pytaniaNaSesji[0].Pyt_Do_Odp_Negatywna);//pytanie do negatywnej
                   
                            plot++;                    
                            odpNegatywna = true;

                        }
                        else if (Automatyzacja.SprawdzSlownik(odpowiedz, OdpTW_1) == true)
                        {
                            _tbCzat.Text += Automatyzacja.OdpowiedzGotowaDoWypisaniaPrzezBota(pytaniaNaSesji[0].Pyt_Do_Odp_Pozytywna1);//pytanie
                            plot++;//przejscie do nastepnej czesci tematu 

                        }
                        else if (Automatyzacja.SprawdzSlownik(odpowiedz, OdpTW_2) == true)
                        {
                            _tbCzat.Text += Automatyzacja.OdpowiedzGotowaDoWypisaniaPrzezBota(pytaniaNaSesji[0].Pyt_Do_Odp_Pozytywna1_Synonim);
                            plot++;
                        }
                        else
                        {
                            _tbCzat.Text += "Bot:powtórz bo nie rozumiem.\n";
                        }


                    }
                    else if (plot == 2) //ostatnie pytanie 2
                    {
                        if(odpNegatywna ==true) // przejscie defaultowo po odpowiedzi do nowej tematyki
                        {
                            if (odpowiedz.Contains("?"))
                            {
                                _tbCzat.Text += Automatyzacja.OdpowiedzGotowaDoWypisaniaPrzezBota(pytaniaNaSesji[0].Odp_Na_Pyt_Uzytkownika);
                                pytaniaNaSesji.RemoveAt(0);                
                                plot = 0;
                                odpNegatywna = false;
                                if (pytaniaNaSesji.Count >= 1)
                                {
                                    _tbCzat.Text += Automatyzacja.OdpowiedzGotowaDoWypisaniaPrzezBota(pytaniaNaSesji[0].GlownePytanie);
                                    plot++;
                                }
                                else
                                {
                                    _tbCzat.Text += "Bot: Miło było cię poznać, ale muszę już lecieć. Trzymaj się.";
                                    _btChatWyslij.IsEnabled = false;

                                }
                            }
                            else
                            {
                                pytaniaNaSesji.RemoveAt(0);//usuwa temat
                                plot = 0;//zaczyna nowy temat
                                odpNegatywna = false;
                                if (pytaniaNaSesji.Count >= 1)
                                {
                                    _tbCzat.Text += Automatyzacja.OdpowiedzGotowaDoWypisaniaPrzezBota(pytaniaNaSesji[0].GlownePytanie);
                                    plot++;
                                }
                                else
                                {
                                    _tbCzat.Text += "Bot: Fajnie było cię poznać, ale niestety muszę uciekać. Do zobaczenia nastepnym razem.";
                                    _btChatWyslij.IsEnabled = false;

                                }
                            }
                        }
                        else if (odpowiedz.Contains("?") == true & Automatyzacja.SprawdzSlownik(odpowiedz, OdpNG) == true)
                        {
                            _tbCzat.Text += Automatyzacja.OdpowiedzGotowaDoWypisaniaPrzezBota(pytaniaNaSesji[0].Odp_Na_Pyt_Uzytkownika1);
                            _tbCzat.Text += Automatyzacja.OdpowiedzGotowaDoWypisaniaPrzezBota(pytaniaNaSesji[0].Pyt_Do_Odp_Negatywna);
                            plot++;
                       
                           
                        }
                        else if (odpowiedz.Contains("?"))
                        {
                            _tbCzat.Text += Automatyzacja.OdpowiedzGotowaDoWypisaniaPrzezBota(pytaniaNaSesji[0].Odp_Na_Pyt_Uzytkownika1);
                            _tbCzat.Text += Automatyzacja.OdpowiedzGotowaDoWypisaniaPrzezBota(pytaniaNaSesji[0].Pyt_Do_Odp_Pozytywna2);
                            plot++;
                        

                        }
                        else if (Automatyzacja.SprawdzSlownik(odpowiedz, OdpNG) == true)
                        {
                            _tbCzat.Text += Automatyzacja.OdpowiedzGotowaDoWypisaniaPrzezBota(pytaniaNaSesji[0].Pyt_Do_Odp_Negatywna);
                          
                            plot++;
                            odpNegatywna = true;

                        }
                        else if (Automatyzacja.SprawdzSlownik(odpowiedz, OdpTW_1) == true)
                        {
                            _tbCzat.Text += Automatyzacja.OdpowiedzGotowaDoWypisaniaPrzezBota(pytaniaNaSesji[0].Pyt_Do_Odp_Pozytywna2);
                            
                            plot++;

                        }
                        else if (Automatyzacja.SprawdzSlownik(odpowiedz, OdpTW_2) == true)
                        {
                            _tbCzat.Text += Automatyzacja.OdpowiedzGotowaDoWypisaniaPrzezBota(pytaniaNaSesji[0].Pyt_Do_Odp_Pozytywna2_Synonim);
                            plot++;

                        }
                       
                        else
                        {
                            _tbCzat.Text += "Bot: powtórz bo nie rozumiem.\n";
                        }
                    }
                    else if (plot == 3)
                    {


                        if (odpNegatywna == true) // tp całe to zmiana
                        {
                            if (odpowiedz.Contains("?"))
                            {
                                _tbCzat.Text += Automatyzacja.OdpowiedzGotowaDoWypisaniaPrzezBota(pytaniaNaSesji[0].Odp_Na_Pyt_Uzytkownika1);
                                pytaniaNaSesji.RemoveAt(0);                 
                                plot = 0;
                                odpNegatywna = false;
                                if (pytaniaNaSesji.Count >= 1)
                                {
                                    _tbCzat.Text += Automatyzacja.OdpowiedzGotowaDoWypisaniaPrzezBota(pytaniaNaSesji[0].GlownePytanie);
                                    plot++;
                                }
                                else
                                {
                                    _tbCzat.Text += "Bot: Do zobaczenia.";
                                    _btChatWyslij.IsEnabled = false;

                                }
                            }
                            else
                            {
                                pytaniaNaSesji.RemoveAt(0);//usuwa temat
                                plot = 0;//zaczyna nowy tema
                                odpNegatywna = false;
                                if (pytaniaNaSesji.Count >= 1)
                                {
                                    _tbCzat.Text += Automatyzacja.OdpowiedzGotowaDoWypisaniaPrzezBota(pytaniaNaSesji[0].GlownePytanie);
                                    plot++;
                                }
                                else
                                {
                                    _tbCzat.Text += "Bot: Do zobaczenia.";
                                    _btChatWyslij.IsEnabled = false;

                                }
                            }
                        }
                        else if (odpowiedz.Contains("?"))
                        {
                            _tbCzat.Text += Automatyzacja.OdpowiedzGotowaDoWypisaniaPrzezBota(pytaniaNaSesji[0].Odp_Na_Pyt_Uzytkownika2);

                            plot = 0;
                            pytaniaNaSesji.RemoveAt(0);

                            if (pytaniaNaSesji.Count >= 1)
                            {
                                _tbCzat.Text += Automatyzacja.OdpowiedzGotowaDoWypisaniaPrzezBota(pytaniaNaSesji[0].GlownePytanie);
                                plot++;
                            }
                            else
                            {
                                _tbCzat.Text += "Bot: Do zobaczenia.";
                                _btChatWyslij.IsEnabled = false;

                            }
                        }
                        else
                        {
                            plot = 0;
                            pytaniaNaSesji.RemoveAt(0);
                            if (pytaniaNaSesji.Count >= 1)
                            {
                                _tbCzat.Text += Automatyzacja.OdpowiedzGotowaDoWypisaniaPrzezBota(pytaniaNaSesji[0].GlownePytanie);
                                plot++;
                            }
                            else
                            {
                                _tbCzat.Text += "Bot: Do zobaczenia.";
                                _btChatWyslij.IsEnabled = false;

                            }
                        }

                    }
                }

            }


        }

        private void _tbCzatWpisz_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                _btChatWyslij_Click( sender,  e);
            }
        }

        private void _btAnaliza_Click(object sender, RoutedEventArgs e)
        {
            List<string> znalezioneSlowa = new List<string>();
            ASE ase = new ASE();
            DOM dom = new DOM();
            EMP emp = new EMP();
            HAR har = new HAR();
            INS ins = new INS();
            MAK mak = new MAK();
            ODK odk = new ODK();
            ROW row = new ROW();
            SYS sys = new SYS();
            WER wer = new WER();
            ZAD zad = new ZAD();

            Osoba.ASE = Automatyzacja.OkreslNatezenieCharakteru(ase,Osoba.Odpowiedzi,znalezioneSlowa);
            if (Osoba.ASE >= 1)
            {
                _tbAnaliza.Text += "Charakter: Asekuracyjny\nNatężenie: ";//dodaj pelna nazwe
                if (Osoba.ASE == 1)
                {
                    _tbAnaliza.Text += "Słabe\n";
                    _tbAnaliza.Text += ase.Opis_Slaby;
                }
                else if (Osoba.ASE == 2 | Osoba.ASE == 3)
                {
                    _tbAnaliza.Text += "Średnie\n";
                    _tbAnaliza.Text += ase.Opis_Sredni;
                }
                else if (Osoba.ASE >= 4)
                {
                    _tbAnaliza.Text += "Duże\n";
                    _tbAnaliza.Text += ase.Opis_Duzy;
                }
                _tbAnaliza.Text += "Użyte słowa: ";
                foreach (var item in znalezioneSlowa)
                {
                    _tbAnaliza.Text += item + " | ";
                }
                _tbAnaliza.Text +="\n";
            }

            Osoba.DOM = Automatyzacja.OkreslNatezenieCharakteru(dom, Osoba.Odpowiedzi,znalezioneSlowa);
            if (Osoba.DOM >= 1)
            {
                _tbAnaliza.Text += "Charakter: Dominujący\nNatężenie: ";
                if (Osoba.DOM == 1)
                {
                    _tbAnaliza.Text += "Słabe\n";
                    _tbAnaliza.Text += dom.Opis_Slaby;
                }
                else if (Osoba.DOM == 2 | Osoba.DOM == 3)
                {
                    _tbAnaliza.Text += "Średnie\n";
                    _tbAnaliza.Text += dom.Opis_Sredni;
                }
                else if (Osoba.DOM >= 4)
                {
                    _tbAnaliza.Text += "Duże\n";
                    _tbAnaliza.Text += dom.Opis_Duzy;
                }
                _tbAnaliza.Text += "Użyte słowa: ";
                foreach (var item in znalezioneSlowa)
                {
                    _tbAnaliza.Text += item + " | ";
                }
                _tbAnaliza.Text += "\n";
            }

            Osoba.EMP = Automatyzacja.OkreslNatezenieCharakteru(emp, Osoba.Odpowiedzi, znalezioneSlowa);
            if (Osoba.EMP >= 1)
            {
                _tbAnaliza.Text += "Charakter: Empatyczny\nNatężenie: ";//daj pelna nazwe 
                if (Osoba.EMP == 1)
                {
                    _tbAnaliza.Text += "Słabe\n";
                    _tbAnaliza.Text += emp.Opis_Slaby;
                }
                else if (Osoba.EMP == 2 | Osoba.EMP == 3)
                {
                    _tbAnaliza.Text += "Średnie\n";
                    _tbAnaliza.Text += emp.Opis_Sredni;
                }
                else if (Osoba.EMP >= 4)
                {
                    _tbAnaliza.Text += "Duże\n";
                    _tbAnaliza.Text += emp.Opis_Duzy;
                }
                _tbAnaliza.Text += "Użyte słowa: ";
                foreach (var item in znalezioneSlowa)
                {
                    _tbAnaliza.Text += item + " | ";
                }
                _tbAnaliza.Text += "\n";
            }

            Osoba.HAR = Automatyzacja.OkreslNatezenieCharakteru(har, Osoba.Odpowiedzi, znalezioneSlowa);
            if (Osoba.HAR >= 1)
            {
                _tbAnaliza.Text += "Charakter: Harmonijny\nNatężenie: ";//daj pelna nazwe 
                if (Osoba.HAR == 1)
                {
                    _tbAnaliza.Text += "Słabe\n";
                    _tbAnaliza.Text += har.Opis_Slaby;
                }
                else if (Osoba.HAR == 2 | Osoba.HAR == 3)
                {
                    _tbAnaliza.Text += "Średnie\n";
                    _tbAnaliza.Text += har.Opis_Sredni;
                }
                else if (Osoba.HAR >= 4)
                {
                    _tbAnaliza.Text += "Duże\n";
                    _tbAnaliza.Text += har.Opis_Duzy;
                }
                _tbAnaliza.Text += "Użyte słowa: ";
                foreach (var item in znalezioneSlowa)
                {
                    _tbAnaliza.Text += item + " | ";
                }
                _tbAnaliza.Text += "\n";
            }

            Osoba.INS = Automatyzacja.OkreslNatezenieCharakteru(ins, Osoba.Odpowiedzi, znalezioneSlowa);
            if (Osoba.INS >= 1)
            {
                _tbAnaliza.Text += "Charakter: Inspirujący\nNatężenie: ";//daj pelna nazwe 
                if (Osoba.INS == 1)
                {
                    _tbAnaliza.Text += "Słabe\n";
                    _tbAnaliza.Text += ins.Opis_Slaby;
                }
                else if (Osoba.INS == 2 | Osoba.INS == 3)
                {
                    _tbAnaliza.Text += "Średnie\n";
                    _tbAnaliza.Text += ins.Opis_Sredni;
                }
                else if (Osoba.INS >= 4)
                {
                    _tbAnaliza.Text += "Duże\n";
                    _tbAnaliza.Text += ins.Opis_Duzy;
                }
                _tbAnaliza.Text += "Użyte słowa: ";
                foreach (var item in znalezioneSlowa)
                {
                    _tbAnaliza.Text += item + " | ";
                }
                _tbAnaliza.Text += "\n";
            }

            Osoba.MAK = Automatyzacja.OkreslNatezenieCharakteru(mak, Osoba.Odpowiedzi, znalezioneSlowa);
            if (Osoba.MAK >= 1)
            {
                _tbAnaliza.Text += "Charakter: Maksymalista\nNatężenie: ";//daj pelna nazwe 
                if (Osoba.MAK == 1)
                {
                    _tbAnaliza.Text += "Słabe\n";
                    _tbAnaliza.Text += mak.Opis_Slaby;
                }
                else if (Osoba.MAK == 2 | Osoba.MAK == 3)
                {
                    _tbAnaliza.Text += "Średnie\n";
                    _tbAnaliza.Text += mak.Opis_Sredni;
                }
                else if (Osoba.MAK >= 4)
                {
                    _tbAnaliza.Text += "Duże\n";
                    _tbAnaliza.Text += mak.Opis_Duzy;
                }
                _tbAnaliza.Text += "Użyte słowa: ";
                foreach (var item in znalezioneSlowa)
                {
                    _tbAnaliza.Text += item + " | ";
                }
                _tbAnaliza.Text += "\n";
            }

            Osoba.ODK = Automatyzacja.OkreslNatezenieCharakteru(odk, Osoba.Odpowiedzi, znalezioneSlowa);
            if (Osoba.ODK >= 1)
            {
                _tbAnaliza.Text += "Charakter: Odkrywczy\nNatężenie: ";//daj pelna nazwe 
                if (Osoba.ODK == 1)
                {
                    _tbAnaliza.Text += "Słabe\n";
                    _tbAnaliza.Text += odk.Opis_Slaby;
                }
                else if (Osoba.ODK == 2 | Osoba.ODK == 3)
                {
                    _tbAnaliza.Text += "Średnie\n";
                    _tbAnaliza.Text += odk.Opis_Sredni;
                }
                else if (Osoba.ODK >= 4)
                {
                    _tbAnaliza.Text += "Duże\n";
                    _tbAnaliza.Text += odk.Opis_Duzy;
                }
                _tbAnaliza.Text += "Użyte słowa: ";
                foreach (var item in znalezioneSlowa)
                {
                    _tbAnaliza.Text += item + " | ";
                }
                _tbAnaliza.Text += "\n";
            }

            Osoba.ROW = Automatyzacja.OkreslNatezenieCharakteru(row, Osoba.Odpowiedzi, znalezioneSlowa);
            if (Osoba.ROW >= 1)
            {
                _tbAnaliza.Text += "Charakter: Równoważący\nNatężenie: ";//daj pelna nazwe 
                if (Osoba.ROW == 1)
                {
                    _tbAnaliza.Text += "Słabe\n";
                    _tbAnaliza.Text += row.Opis_Slaby;
                }
                else if (Osoba.ROW == 2 | Osoba.ROW == 3)
                {
                    _tbAnaliza.Text += "Średnie\n";
                    _tbAnaliza.Text += row.Opis_Sredni;
                }
                else if (Osoba.ROW >= 4)
                {
                    _tbAnaliza.Text += "Duże\n";
                    _tbAnaliza.Text += row.Opis_Duzy;
                }
                _tbAnaliza.Text += "Użyte słowa: ";
                foreach (var item in znalezioneSlowa)
                {
                    _tbAnaliza.Text += item + " | ";
                }
                _tbAnaliza.Text += "\n";
            }

            Osoba.SYS = Automatyzacja.OkreslNatezenieCharakteru(sys, Osoba.Odpowiedzi, znalezioneSlowa);
            if (Osoba.SYS >= 1)
            {
                _tbAnaliza.Text += "Charakter: Systematyczny\nNatężenie: ";//daj pelna nazwe 
                if (Osoba.SYS == 1)
                {
                    _tbAnaliza.Text += "Słabe\n";
                    _tbAnaliza.Text += sys.Opis_Slaby;
                }
                else if (Osoba.SYS == 2 | Osoba.SYS == 3)
                {
                    _tbAnaliza.Text += "Średnie\n";
                    _tbAnaliza.Text += sys.Opis_Sredni;
                }
                else if (Osoba.SYS >= 4)
                {
                    _tbAnaliza.Text += "Duże\n";
                    _tbAnaliza.Text += sys.Opis_Duzy;
                }
                _tbAnaliza.Text += "Użyte słowa: ";
                foreach (var item in znalezioneSlowa)
                {
                    _tbAnaliza.Text += item + " | ";
                }
                _tbAnaliza.Text += "\n";
            }

            Osoba.WER = Automatyzacja.OkreslNatezenieCharakteru(wer, Osoba.Odpowiedzi, znalezioneSlowa);
            if (Osoba.WER >= 1)
            {
                _tbAnaliza.Text += "Charakter: Weryfikujący\nNatężenie: ";//daj pelna nazwe 
                if (Osoba.WER == 1)
                {
                    _tbAnaliza.Text += "Słabe\n";
                    _tbAnaliza.Text += wer.Opis_Slaby;
                }
                else if (Osoba.WER == 2 | Osoba.WER == 3)
                {
                    _tbAnaliza.Text += "Średnie\n";
                    _tbAnaliza.Text += wer.Opis_Sredni;
                }
                else if (Osoba.WER >= 4)
                {
                    _tbAnaliza.Text += "Duże\n";
                    _tbAnaliza.Text += wer.Opis_Duzy;
                }
                _tbAnaliza.Text += "Użyte słowa: ";
                foreach (var item in znalezioneSlowa)
                {
                    _tbAnaliza.Text += item + " | ";
                }
                _tbAnaliza.Text += "\n";
            }

            Osoba.ZAD = Automatyzacja.OkreslNatezenieCharakteru(zad, Osoba.Odpowiedzi, znalezioneSlowa);
            if (Osoba.ZAD >= 1)
            {
                _tbAnaliza.Text += "Charakter: Zadaniowy\nNatężenie: ";//daj pelna nazwe 
                if (Osoba.ZAD == 1)
                {
                    _tbAnaliza.Text += "Słabe\n";
                    _tbAnaliza.Text += zad.Opis_Slaby;
                }
                else if (Osoba.ZAD == 2 | Osoba.ZAD == 3)
                {
                    _tbAnaliza.Text += "Średnie\n";
                    _tbAnaliza.Text += zad.Opis_Sredni;
                }
                else if (Osoba.ZAD >= 4)
                {
                    _tbAnaliza.Text += "Duże\n";
                    _tbAnaliza.Text += zad.Opis_Duzy;
                }
                _tbAnaliza.Text += "Użyte słowa: ";
                foreach (var item in znalezioneSlowa)
                {
                    _tbAnaliza.Text += item + " | ";
                }
                _tbAnaliza.Text += "\n";
            }

        }

       
    }
}
