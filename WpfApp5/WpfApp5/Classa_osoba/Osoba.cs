using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp5.Classa_osoba
{
    public static class Osoba
    {
        public static string Imie { get; set; }
        //charaktery
        public static int DOM { get; set; }
        public static int MAK { get; set; }
        public static int INS { get; set; }
        public static int ODK { get; set; }
        public static int WER { get; set; }
        public static int SYS { get; set; }
        public static int ASE { get; set; }
        public static int HAR { get; set; }
        public static int EMP { get; set; }
        public static int ZAD { get; set; }
        public static int ROW { get; set; }
        
        //Odpowiedzi użytkownika - przechowywanie
        public static List<string> Odpowiedzi { get; set; }

        // Ustawienie charakteru na niezdyfiniowany w konstruktorze
        public static void  UstawOsoba()
        {
            DOM = 0;
            MAK = 0;
            INS = 0;
            ODK = 0;
            WER = 0;
            SYS = 0;
            ASE = 0;
            HAR = 0;
            EMP = 0;
            ZAD = 0;
            ROW = 0;
            Odpowiedzi = new List<string>();
        }

    }
}
