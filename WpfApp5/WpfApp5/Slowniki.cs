using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WpfApp5
{
    public partial class MainWindow : Window
    {
        string[] UzytkownikKonczySlowami = {

           "to wszystko, lecę",  "to wszystko, lece",
            "trzymaj się", "trzymaj sie",
            "Może porozmawiamy później",
            "Moze porozmawiamy pozniej",
            "pozniej", "poźniej", "pózniej",
            "To wszystko",
            "do zobaczenia",
            "muszę cię opuścić", "musze cie opuscic",
            "pożegnać", "pozegnac", "pozegnać", "pozegnac",
            "muszę odejść", "musze odejsc",
            "muszę lecieć, pa",
            "musze leciec, czesc", "muszę lecieć, cześć",
            "muszę lecieć, hej",
            "muszę lecieć, do zoba",
            "rozstac", "rozstać",
            "muszę jednak kończyć", "musze jednak konczyc",
            "muszę kończyć", "musze konczyc",
            "porozmawiamy innym razem",
            "moze innym razem cos opowiem", "może innym razem coś opowiem",
            "teraz będę kończył", "teraz bede konczyl",
            "uciekam, trzymaj się", "uciekam, trzymaj sie", "uciekam trzymaj sie", "uciekam trzymaj się",
            "narazie., trzymaj się",
            "muszę kończyć",
            "musze konczyc",
            "jednak konczyc",
           



        };
        string[] OdpTW_1 = {

           "lubię", "lubie", "uwielbiam", "kocham", "uwielbiam",
            " tak ", "tak,",  "tak.","tak ,","tak .",
            "dobrze",
            "świetnie",
            "u mnie dobrze",
            "porządek", "porządek", "w porządku", "w porzadku", "porzadku",
            "wszystko w porządku", "wszystko w porzadku",
            "ok  ","okej",
            "nazywam",
            "a ty ", 
            "mam",  
            "pracuje", "pracuję",
            "jestem",
            "nazywa",
            "mam",



            "kebab","donald", "burger",  "falafel",  "frytk",  "hot dog", "popcorn", "zapiekank", "lody", "kanapk",//fast food 
            //Muzyka
            //Rodzenstwo
            //ImieIleLat
            //Praca
            //Filmy
            //MiastoCzyWies
            //Psy
            //Koty
            //FastFood
            //Wakacje
            //Sport
            //Jezyk
            //kawa
            //prawo jazdy
            //pogoda


            //kraje

            "Afganist", "Albani", "Algieri","Andor","Angol","Antigu","Arabi","Argent","Armeni","Austra","Austri","Azerbe","Baham","Bahraj","Bangla","Barbad",
            "Belgi", "Beliz", "Benin","Bhutan","Białoruś", "Bialorus", "Białorus", "Bialoruś", "Białoru", "Bialoru",
            "Boliw","Bośni","Bosni","Botswan","Brazyl","Brunei","Bułgar","Bulgar","Burkin","Faso","Burundi",
            "Chile","Chin","Chorwacja","Cypr","Czad","Czarnogóra","Czarnogora","Czechy","Dania","Danie","Danii","Kong","Dominika","Dominikana","Dżibuti",
            "Egipt","Ekwador","Erytrea","Estonia","Eswatini","Etiopi","Fid","Filipin","Finland","Francj","Gabon","Gambi","Ghan","Grecj","Grenad",
            "Gruzj","Gujana","Gwatemal","Gwine","Haiti","Hiszpan","Holand","Hondur","Indie","Indonez","Irak","Iran","Irland","Island","Izrael",
            "Jamajk","Japoni","Jemen","Jordani","Kambod","Kamerun","Kanad","Katar","Kazachstan","Kenia","Kirgistan","Kiribati","Kolumbi","Komor","Kong",
            "Kore","Kostary","Kuba","Kuwejt","Laos","Lesoth","Liban","Liberi","Libi","Liechten","","Lichten","Litw","Luksemb","Luxemb",
            "Łotw","Lotw","Macedoni","Madagask","Malaw","Maledi","Malezj","Mali","Malt","Marok","Mauretani","Maurit","Meksyk","Mikronez","Mjan",
            "Mołdawi","Moldawi","Monak","Mongol","Mozamb","Namib","Naur","Nepal","Niemc","Niger","Nikarag","Norweg","Zeland","Oman","Pakistan",
            "Pala","Panam","Gwine","Papua","Paragwaj","Peru","Polsk","Afryk","Portug","Republik","Rosj","Rosy","Rumun","Rwand","Saint", "Kitts", "Nevis",
            "Lucia","Vincent","Grenady","Salwador","Samo","Marin","Senegal","Serbi","Seszele","Sier","Leone","Słowac","Singapur","Slowac","Slowen", "Słowen", "Somali",
            "Sri","Lank","Stany","USA","Anglia","Turcja","sudan","Surinam","Syri","szwajcar","Szwecj","Szwedz","tadżykist","Tajland","tanzan", "Timor", "Togo",
            "tong","Tobag","Trynid","Tunezj","Tuval","Turkemist","Ugand","Ukrain","Urugwa","Uzbekis","Vanua","Watyka","Wenezu","Węgr","Wegr", "Brytan", "Wietnam",
            "Włoch","Wloch","Wybrzeż","Kośc","","Wybrzez","Kosc","Mashall","Salomon","Zambi","Zimbatw","Zjednoczon","Emirat","Arab",

            //imiona
             "Abercjusz", "Ada","Adam","Adolf","Adrian","Adriana","Adrianna","Alfred","Agat","Agnieszk","Alan","Albert","Aleksand",
             "Aleks","Alicj","Alfons","Alwin","Amadea","Amadeu","Ambrozja","Ambroży","Anastazj","Andre","Andrzej","Andżelik","Andzelik",
             "Anet","Angelik","Arek","Arkadiusz","August","Augustyn","Augustyna",

             "Aaron","Abbo","Abbon","Abdiasz","Abdon","Abel","Abelard","Abercjusz","Abiasz","Abigail","Abraham","Absalon","Abundancja","Abundancjusz","Achacja","Achacjusz","Achacy","Achilles","Ada","Adalbert","Adalberta","Adalgunda","Adalruna","Alruna","Adalryk","Alderyk","Adalwin","Adalwina","Adam","Adamina","Adamnan","Adaukt","Addar","Adela","Adelajda","Adelard","Adelina","Adelinda","Ademar","Adolf","Adolfa","Adolfina","Adrian","Adriana","Adrianna","Aelred","Afra","Afrodyta","Afrodyzja","Afrodyzjusz","Afrodyzy","Afrykan","Agapit","Agapita","Agapiusz","Agata","Agatangel","Agaton","Agatonik","Agatonika","Agenor","Aggeusz","Agis","Agnellus","Agnieszka","Agrykola","Agrypin","Agrypina","Agryppa","Ahmed","Aida","Aidan","Aisza","Aital","Ajaks","Akcjusz","Akwila","Akwilin","Akwilina","Alan","Alana","Alba","Alban","Albana","Albert","Alberta","Albertyna","Albin","Albina","Albwin","Albuin","Aldegunda","Aldhelm","Aldmir",
             "Aldona","Aldowin","Aleksa","Aleksander","Aleksandra","Aleksja","Aleksy","Alfeusz","Alfons","Alfonsa","Alfonsyna","Alfred","Alfreda",
            "Alicja","Alina","Alipiusz","Alma","Alodia","Alodiusz","Alojza","Alojzja","Alojzy","Alwar","Alwin","Alwina","Amadea","Amadeusz","Amalberga",
            "Amalgunda","Amalia","Amancjusz","Amand","Amanda","Amaranta","Amat","Amata","Ambrozja","Ambroży","Amelia","Amfiloch","Amilkar","Amira","Ammonia",
            "Ammoniusz","Amon","Amonaria","Amonariusz","Amoniusz","Amos","Ampelia","Ampeliusz","Ananiasz","Anastazja","Anastazy","Anatol","Anatola","Anatolia",
            "Anatoliusz","Andromeda","Andronik","Andrea","Andromacha","Andrzej","Andrzeja","Andżela","Andżelika","Aneta","Angela","Angelika","Angelina","Anian",
            "Anicet","Aniceta","Aniela","Anioł","Anita","Anizja","Anizjusz","Anna","Ansbert","Ansgar","Ansgary","Anter","Antioch","Antoni","Antonia","Antonin",
            "Antonina","Antuza","Antyd","Antym","Antypas","Antypater","Anuncjata","Anzelm","Anzelma","Apolinaria","Apolinary","Apollina","Apollo","Apollon","Apolonia",
            "Apoloniusz","Apulejusz","Arabela","Arbogast","Archelaus","Archibald","Archip","Ardalion","Arediusz","Areta","Aretas","Argea","Argeus","Argymir","Ariadna",
            "Arian","Ariana","Ariel","Ariela","Arkadia","Arkadiusz","Arkady","Arleta","Armand","Armida","Armin","Arnold","Arnolf","Arnulf","Aron","Arsacjusz","Arseniusz",
            "Artemia","Artemiusz","Artemizja","Artemon","Artur","Arwid","Arystarch","Arystea","Arysteusz","Arystion","Arystokles","Arystyda","Arystydes","Asaf","Asenata",
            "Askaniusz","Asklepiades","Aspazja","Aspazjusz","Aspazy","Asteria","Asteriusz","Astryda","Asumpta","Asynkryt","Atalia","Atanazja","Atanazy","Atenaida", "Ateniada",
            "Atenodor","Atenogenes","Aubert","Audoen","Audomar","August","Augusta","Augustyn","Augustyna","Auksencja","Auksencjusz","Auksenty","Aulus","Aurea","Aureli","Aurelia",
            "Aurelian","Aureliusz","Aureusz","Aurora","Awentyn","Awit","Awita","Azariasz",

             "Barabasz","Barbara","Basi","Bartek","Bartłomiej","Bartlomiej", "Bartosz","Beata","Benedykt","Bernadeta", "Bogu","Bor","Brajan",
             "Bronis",

             "Baalis","Babilas","Bachus","Bakchus","Balbin","Balbina","Baldomer","Baldomera","Baldwin","Baldwina","Balladyna","Baltazar","Barabasz","Barbacjan","Barbacy","Barbat","Barbara",
            "Barlaam","Barnaba","Barnim","Baroncjusz","Bartłomiej","Bartłomieja","Bartosz","Basjan","Basjana","Batylda",
             "Bawon","Bazyla","Bazyli","Bazylides","Bazyliusz","Bazylisa","Bądzsław","Bądzsława","Bdzigost",
             "Beat","Beata","Beatrycze","Beda","Bega","Benedykt","Benedykta","Beniamin","Benicjusz","Benigna","Benignus",
             "Benon","Benona","Benwenut","Benwenuta","Berard","Berengar","Berengaria","Berenika","Bernadeta",
             "Bernarda","Bernardyn","Bernardyna","Berta","Bertold","Bertrada","Bertram",
            "Bertrand","Bertyn","Berwin","Besarion","Bezprym","Będzieciech","Będzimir","Będzimysł","Bianka",
            "Bianor","Bibian","Bibiana","Bibianna","Biecsław","Biecsława","Biedrzysław","Biryn","Biezrząd","Biezuj","Biruta","Blanda","Blandyn","Blandyna",
            "Blanka","Blizbor","Błażej","Błażeja","Bodzepor","Bodzęta","","Bogdała","","Bogdan","Bogdana","Bogna","Bogodał","Boguchwał","Boguchwała","Bogudar",
            "Bogufała","Bogumił","Bogumiła","Bogumysław","Bogurad","Bogusąd","Bogusław","Bogusława","Boguwłość","","Boguwola","Bogwidza","","Bogwiedz","Bohdan","Bohdana",
            "Bolebor","Boleczaj","Boleczest","Bolelut","Bolemir","Bolemira","Bolemysł","Bolesław","Bolesława","Bona","Bonawentura","Bonfilia","Bonfiliusz","Bonifacja","Bonifacy","Boromea",
            "Boromeusz","Borys","Borzuj","Borzygniew","Borzymir","Borzysław","Borzywoj","Bożebor","Bożeciech","BożeciechaBożena",
            "Bożydar","Bracsław","Brajan","Bratomir","Bratumił","Bratumiła","Braturad","Brenda","Brendan",
            "Briok","Brodzisław","Bromir","","Bronimir","Bronisąd","Bronisław","Bronisława","Brosław","Bruno",
            "Brunon","Brygida","Brykcjusz","Budziboj","Budzigniew","Budzimir","Budzisław",
            "Budzisława","Budziwoj","Budziwuj","Burchard","Bygost","Bytomir",


             "Cecylia", "Cezary","Czarek","Adolf","Chrystian","Cieszybor","Adrianna","Alfred","Agat","Agnieszk","Alan","Albert","Aleksand",
             "Aleks","Alicj","Alfons","Alwin","Amadea","Amadeu","Ambrozja","Ambroży","Anastazj","Andre","Andrzej","Andżelik","Andzelik",
             "Anet","Angelik","Arek","Arkadiusz","August","Augustyn","Augustyna",

            "Carmen","Cecylia","Cecylian","Cecyliusz","Cedmon","Celeryn","Celeryna","Celestyn","Celestyna",
            "Celia","Celina","Celiusz","Celzjusz","Cezaria","Cezariusz","Cezary","Cezaryna","Charłamp","Charłampa",
            "Charytyna","Charyzjusz","Cherubin","Chionia","Chloe","Chociebąd","Chociebor","Chociemir","Chociesław",
            "Chocsław","Choroman","Chrystian","Chryzant","Chryzanta","Chryzogon","Chwalibog","Chwalimir","Chwalimira",
            "Chwalisław","Chwalisława","Cibor","Cibora","Ciechosław","Ciechosława","Ciecierad","Ciecimiar","Ciecirada",
            "Ciesław","Ciesława","Cieszybor","Cieszygor","Cieszymir","Cieszymysł","Cieszyrad","Cieszysław","Cieszysława",
            "Cirzpibog","Cirzpisława","Cymbarka","Cyntia","Cyprian","Cyra","Cyrenia","Cyriak","Cyriaka","Cyrus","Cyryk","Cyryl",
            "Cyryla","Cyryn","Cyryna","Czabor","Czasław","Czasława","Czcibor","Czcibora","Czcirad","Czcisław","Czedrog","Czesbor",
            "Czesław","Czesława","Czębira","Czębor","Czędomir","Częstobor","Częstobrona","Częstogoj","Częstomir","Częstowoj","Częstowojna","Częścibor",


            "Dacjan","Dacjusz","Dadzbog","Dadzboga","Dafroza","Dagmara","Dagna","Dagobert","Dalbor","Dalebor",
            "Dalebora","Dalegor","Dalemir","Dalestryj","Dalewin","","Dalwin","Dalewuja","Dalia","Dalibor",
            "Dalila","Dalimir","Dalmacjusz","Dalwin","Damazy","Damian","Damiana","Damroka","Daniel","","Daniela",
            "Danuta","Dargomier","Dargorad","Dargosław","Daria","Dariusz","Datyw","Dawid","Dawida","Dąbrówka","Debora","Deder","Delfin","Delfina","Demetria","Demetriusz","Demokryt",
            "Derwan","Dezyderia","Dezyderiusz","Dezydery","Diana","Digna","Dina","Diodor","Diodora","Diogenes",
            "Diomedes","Dionizja","Dionizjusz","Dionizy","Dioskur","Ditmar","Długomił","Dobiegniew",
            "Dobiegniewa","Dobielut","Dobiemiest","Dobiemir","Dobiesław","Dobiesława","Dobosław","Dobosława","Dobrawa","Dobrobąd","Dobrochna","Dobrociech","Dobrogniew","Dobrogniewa",
            "Dobromił","Dobromiła","Dobromir","Dobromira","Dobromysł","Dobroniega","Dobrosiodł",
            "Dobrosław","Dobrosława","Dobrosułka","Dobrowieść","Dobrowit","Dobrowoj","Dobrowoja",
            "Dobrożyźń","Dobrutro","Dobrzegniew","Dolores","Domabor","Domaczaja","Domagniew","Domamir","Domarad","Domaradz","Domasław","Domasława","Domastoj","Domastryj","Domasuł","Domawuj","Domażyr",
            "Domicela","Domicjan","Domicjana","Domicjusz","Dominik","Dominika","Domna","Domniusz","Domorad",
            "Domosław","Donacjan","Donald","Donat","Donata","Dorian","Dorota","Doroteusz","Doryda","Drogodziej",
            "Drogomił","Drogomir","Drogomira","Drogomysł","Drogoradz","Drogosław","Drogosława","Drohobysz","Dromił","Druzjan","Druzjanna","DruzusDula","Dunstan","Dydak","Dydym","Dydymus","Dyter","Dytwin",
            "Dyzma","","Dziadumiła","Dziebor","DziersławDziersława","Dzierżykraj","","Dzierżysław","Dziesław",
            "Dziesława","Dzirżysława","Dzirżyterg","Dzirżywuj","Dziwigor","Dziwisław","Dżesika",


            "Eberhard","Ebrulf","Edbert","Edburga","Edda","Edelburga","Edeltruda","Edgar","Edmund",
            "Edmunda","Edward","Edwarda","Edwin","Edwina","Edyta","Efraim","Efrem","Egbert","Egidia","Egidiusz",
            "Egon","Egwin","Ekhard","Eghard","Ekard","Ekspedyt","Ekspedyta","Eksuperancjusz","Eksuperiusz","Eleazar",
            "Eleonora","Eleukadiusz","Eleuteria","Eleuteriusz","Eleutery","Elfeg","Elfryda","Eliasz","","Elifia","Elifiusz",
            "Eligia","Eligiusz","Eliza","Elizeusz","Elmira","Elpidia","Elpidiusz","Elpin","Elwira","Elżbieta","Ema","Emma","Emanuel",
            "Emanuela","Emerencja","Emeryk","Emeryka","Emeryta","","Emil","Emilia","Emilian","Emiliana","Emmeram","Emmeran","Emnilda","Engelbert",
            "Enniusz","Enoch","Epafras","Epifani","Epifania","Epifaniusz","Erast","Erazm","Erazma","Erhard","Ermegarda","","Ermelinda","Ermenfryd",
            "Ermenfryda","Ermentruda","Ernest","Ernesta","Ernestyna","Erwin","Erwina","Eryk","Eryka","Esmeralda","Estera","Etelwold","Eubul","Euchariusz",
            "Euchary","Eudokia","Eudoksja","Eudoksjusz","Eufemia","Eufemiusz","Eufrazja","Eufroniusz","Eufrozyna","Eugenia","Eugeniusz","Eulalia","Eulampia",
            "Eulampiusz","Eulogia","Eulogiusz","Eunika","Eunomia","Eupsychia","","Eupsychiusz","Eustachia","Eustachiusz","Eustachy","Eustacjusz","Eustazja","Eustazjusz",
            "Eustazy","Eutropia","Eutropiusz","Eutyches","Eutychia","Eutychian","Eutychiusz","Eutymiusz","","Euzebia","Euzebiusz","Ewa","Ewald","Ewangelina","Ewaryst","Ewarysta",
            "Ewelina","Ewodia","Ewodiusz","Ezdrasz","Ezechiel",

            "Fabia","Fabian","Fabiana","Fabiola","Fabiusz","Fabrycjan","Fabrycy","Faina","Falibog","Falibor","","Falimir","Falisław","Falisława","Falkon","Faro","Faust","Fausta",
            "Faustyn","Faustyna","Faustynian","Fawila","Feba","Febron","Febronia","Felicja","Felicjan","Felicjana","Felicysym","Felicyta","Feliks","","Feliksa","Felin","Felina","Fenenna","Ferdynand","Fereol","Festus",
            "Fidelis","Fidelisa","Fidol","Fiebrosław","Filadelf","Filadelfia","Filaret","Filemon","Filemona",
            "Filibert","Filiberta","Filip","Filip","Neriusz","Filipa","FilipinaFilomela","Filomen",
            "Filomena","Filon","Filona","Filotea","Filoteusz","Fintan","Firmin","Firmina","Firmus","Flawia",
            "Flawian","Flawiana","Flawiusz","Flora","Florencja","Florencjusz,","Florenty","Florentyn","","Florentyna","Florian",
            "Florianna","Floriana","Floryn","Floryna","Fokas","Fortunat","Fortunata",
            "Fotyn","Fotyna","Franciszek","Franciszek","Ksawery","Franciszek","Salezy","Franciszka","Franciszka","Ksawera",
            "Fraternus","Fredeswinda","Frumencjusz","Fryda","Fryderyk","Fryderyka",
            "Frydolin","Fulbert","Fulgencjusz","Fulgenty","Fulko","Furseusz",


            "Gabriel","Gabriela","Gaja","Gajana","Gajusz","Galezy","Galfryd","Galla","Gandalf","Gandolf",
            "Gandulf","Gardomir","Gaston","Gaudencja","Gaudencjusz","Gaudenty","Gaweł","Gawin","Gebhard","Gedeon","Gelazja","Gelazy","Geminian","Gemma",
            "Genadia","Genadiusz","Genady","Genezjusz","Genowefa","","Gerald","Geraldyna","Gerard","Gerarda","Gerazym","Gerbert","Gerda","Gereon","Gerlinda",
            "German","Germana","Germanik","Germeriusz","Geroncjusz","Gertruda","Gerwazy","Gerwin","Gerwina","Giedymin","","Gilbert","Gildas","Ginewra","Ginter","Gizbert","Gizela","Glafira","Gleb",
            "Gliceria","Gliceriusz","Glicery","Gloria","Gnierat","Gniewko","Gniewomir","Gniewosądka","Godfryd","","Godzimir","Godzisław","Gonsalwy","Gorazd","Gordian","Gordiana","Gordiusz","Gorgonia",
            "Gorgoniusz","","Gorzysław","Gosław","Gosława","Gostmił","Gościmir","Gościrad","Gościsław","Gościsława","Gościwid","","Gościwit","GościwujGotard","Gotfryd","Gracja","Gracjan","Gracjana",
            "Gratus","Grażyna","Greta","","Grimbald","Grodzisław","Gromisław","Grymilda","Gryzelda","Grzegorz",
            "Grzymisław","Grzymisława","Gumbert","Guncerz","Gunter","Guntram","Gurias","Gustaw","Gustawa","Gwalbert",
            "Gwendalina","Gwendolina","Gwenol","Gwibert","Gwido","Gwidon","Gwidona","Gwisław",


            "Habakuk","Hadrian","Hadriana","Halina","Hamilkar","Hanna","Hannibal","Haralampia","Haralampiusz",
            "Harald","Hegezyp","Hektor","Heladia","Heladiusz","Helena","Helga","Heliasz","Heliodor","Heliodora",
            "Helmut","Heloiza","Henryk","Henryka","Herakles","Heraklides","Herakliusz","Herbert","Herbort","","Herburt","Herena","Herenia",
            "Herkulan","Herkules","Herman","Hermana","Hermenegild","Hermenegilda","","Hermes","Hermina","Hermiona","Hermogenes","Herodion",
            "Heron","Hersylia","Hezychiusz","Hiacynt","","Hiacynta","Hieronim","Hieronima","Hilaria","Hilarion","Hilariona","Hilary","Hilda",
            "Hildebrand","","Hildebranda","Hildegarda","Hildegunda","Hildemar","Hiltruda",
            "Himisław","Hiob","Hipacy","Hipolit","Hipolita","Hodysław","Honorat","Honorata","Honoriusz","Honory","","Honoryna","Horacjusz",
            "Horacy","Hortensja","Hortensjusz","Hubald","Hubert","Huberta","Hubysław",
            "Hubysława","Hugo","Hugon","Hugona","HumbelinaHumbert","Huniemir","Huniesław","Hunold","Hygin",


            "Ida","Idalia","Idzi","Ifigenia","Iga","Ignacja","Ignacy","Igor","Ildefons","Ildefonsa","Ilidia",
            "Ilidiusz","Ilona","Imbram","Imelda","Imisław","ImisławaIndracht","Indrakt","Inga","Inka",
            "Ingarda","Ingbert","Ingeborga","Ingobert","Ingolf","Ingryda","Innocencja","Innocenta","Innocenty","","Innocentyna","Irena","Ireneusz","Irma",
            "Irmegarda","Irmgarda","Irmentruda","Irmtruda","Irmfryd","","Irmfryda","Irmina","Iryda","Irydion","Ischyrion","Ismena","Iweta","Iwo","Iwon",
            "Iwona","Izaak","Izabela","Izajasz","Izaur","Izaura","Izbor","Izbygniew","Izbygniewa","Izbylut",
            "Izolda","Izyda","Izydor","Izydora",


            "Jacek","Jacenty","Jacław","Jaczemir","Jaczewoj","Jadwiga","Jagna","Jagoda","Jakert","Jaktor","Jakub",
            "Jakubina","Jan","Jan","Chrzciciel","Jan","Chryzostom","Jan","Gwalbert","Jan","Kanty","Jan","Nepomucen",
            "Janczysława","Janina","Janisław","Januaria","Januariusz","January","Janusz","Jarogniew","Jarogniewa",
            "Jaromir","Jaromira","Jarosław","Jarosława","JarostryjJaśminaJazon","Jenny","Jeremi","Jarema","Jeremiasz","Jerosława","Jerzy","Jesse","Jędrzej","Jimisław","Joachim",
            "Joachima","Joanna","Joannicjusz","Jodok","Joel","Jokasta","Jolanta","Jonasz","Jonatan","Jordan","Jordana","Jowinian","Jowita","","Jozafat","Jozafata","Jozue","Józef",
            "Józefa","Józefina","Juda","Juda","Tadeusz","Judyta","Jukund","Julia","Julian","Julianna","Juliana","Julita","Juliusz","Juniesław","Jurand",
            "Just","Justa","Justyn","Justyna","Justynian","Jutrogost","Jutrowoj","Jutrowuj","Juwenalis","Juwencja","Juwencjusz","Juwentyn",


            "Kacper","Kaja","Kajetan","Kajetana","Kajmir","Kajus","Kalasanty","Kalikst","Kalista","KalinaKalinik","Kalistrat",
            "Kalmir","Kamil","Kamila","Kancjan","Kancjanela","Kancjusz","KandydKandyda","Kanizjusz","Kanimir","Kanizja","Kanmił","Kanut",
            "Kanuta","Kapitolina","KarinaKarol","Karol","Boromeusz","Karola","Karolina","Karp","Karina","KarynaKasandra","KasjanKasjana","Kasjusz",
            "Kasper","Kastor","Kasylda","Katarzyna","Kazimiera","KazimierzKewin","Kiejstut","Kilian","Kiliana","Kineburga","Kinga","Kira","Klara","KlarencjuszKlarus",
            "Klarysa","Klaudia","Klaudian","Klaudiusz","Klaudyna","Klemencja","KlemensKlementyn","Klementyna","Kleofas","Kleonik","Kleonika","Kleopatra","Klet","Klotylda",
            "Kociebor","Kociemir","Koleta","Kolumb","Kolumba","Kolumban","Konkordia","Konkordiusz","Konrad","KonradaKonradyn","Konradyna","Konstancja","Konstancjusz","Konstans","Konstanty",
            "Konstantyn","Konstantyna","Kordian","Kordula","Kornel","Korneli","Kornelia","Korneliusz","Kora","KorynaKosma","","Krescencja","Krescencjusz","Krescens","Krescenty","Kryspin","Kryspina",
            "KryspinianKrystian","Krystiana","Krystyn","Krystyna","Krzesąd","Krzesimir","Krzesisław","KrzesisławaKrzesław","Krzesława","Krzysław","Krzysztof","Krzysztofa","Ksawera","KsawerynaKsawery","Ksenia",
            "Ksenofont","Ksymena","Kunegunda","Kunibert","Kutbert","Kwalimir","KwalisławKwieta","Kwintus","Kwintylian","Kwintyn","Kwiryn","Kwiryna","Kwiryniusz",


            "Laliczaj","Lambert","Lamberta","Largus","Larysa","Lasota","Laura","Laurencja","LaurencjuszLaurenty",
            "Laurentyn","Laurentyna","Lawinia","Lawiniusz","Lea","Leander","Leandra","Lech","Lechosław","Lechosława",
            "Lederg","Lelistryj","Lena","Leodegar","LeokadiaLeokadiusz","Leokrycja","Leon","Leona","Leonard","Leonarda",
            "Leoncja","Leoncjusz","LeoniaLeonid","Leonida","Leontyn","Leontyna","Leopold","Leopolda","Leopoldyna","Leowigild",
            "LesławLesława","Leszek","Letycja","Lewin","Liba","Liceria","Liceriusz","Licynia","Licyniusz","Liberat","Liberata","Libert",
            "Liberiusz","Liboriusz","Lidia","Ligia","Lilia","Liliana","LiliannaLilioza","Lilla","Lina","Linda","Linus","Litawor","Litobor",
            "Litoriusz","Liwia","LiwiuszLongin","Longina","Loreta","Lotar","Lubart","Lubgost","Lubodrog","LubomirLubomira","Lubomysł","Luboradz",
            "Lubowid","Lucydiusz","Lucja","Lucjan","Lucjana","Lucjusz","Lucyla","Lucyliusz","LucynaLudan","Ludgarda","Ludger","Ludolf","LudolfinaLudmar",
            "Ludmiła","Ludomił","Ludomiła","Ludomir","Ludomira","Ludosław","Ludwik","LudwikaLudwin","Lutwin","LudwinaLudziwoj","Luiza","Lukrecja","Lutfryd",
            "LutoborLutogniew","Lutomir","Lutosław","Lutosława",

            "Łazarz","Łękomir","Łękomira","Łucja","Łucjan","Łucjana","Łucjusz","Łukasz",

            "Macedoniusz","Machabeusz","Maciej","Macieja","Magdalena","Magnus","Maja","Majnard","Majol","Majola","Makaria","Makary","Makrobiusz",
            "MakrynMakryna","Maksencja","Maksencjusz,","MaksantyMaksym","Maksyma","Maksymian","Maksymilian","Maksymiliana","Maksymin","Maksymina","Malachiasz",
            "Malchus","Malina","MalkolmMalwina","Małgorzata","Małobąd","Małogost","Małomir","Małostryj","Małowid","Małowuj","Mamelta","Mamert","Mamerta","Mamertyn","Mamertyna",
            "Manea","Manfred","Manfreda","Maniusz","Manomir","Manswet","Marana","Marcela","Marceli",
            "Marcelin","Marcelina","Marcin","Marcisław","Marcja","Marcjalis","Marcjan","Marcjanna","Marcjusz","Mardoniusz","Marek","Maria","Miriam","Marian","Marianna",
            "Mariola","Mariusz","Markusław","Markwart","Marlena","Maro","Marol","Marold","Maron","Marot","Marotas","Marta","Martyna","Martynian","Marut","Maruta","Marutas",
            "Marwald","Maryla","Maryn","Maryna","Marzanna","Marzena","Masław","Matea","Matern","Materna","Mateusz","Matron","Matrona","Matylda","Maur","Maura","Maurycja",
            "Maurycy","Mauryliusz","Mauryn","Medard","Medarda","Mederyk","Mederyka","Meinrad","Melania","Melaniusz","Melchiades","Melchior","Melecjusz","Melisa","Melizanda",
            "Memiusz","Menander","Menas","Menelaus","Meriadek","Meriadok","Merkuria","Merkury","Merul","Metoda","Metody","Metrofan","Męcimir","Męcisław","Męsław","Michalina",
            "Michał","Micheasz","Miecisław","Mieczysław","Mieczysława","Miestwin","Mieszko","MikołajMilan","Milburga","Mildreda","Milena","Miłobąd","Miłobrat","Miłochat","Miłoczat",
            "Miłodrog","Miłogost","Miłorad","Miłosław","Miłosława","Miłostryj","Miłosz","Miłość","Miłowit","Miłowuj","Minigniew","Minogniew","Mira","Miranda","Mirela","Mirogod",
            "Mirogniew","Mirogniewa","Mirokles","Miron","Mirona","Mironieg","Mironiega","Mirosław","Mirosława","MisławModest","Modesta","Modlibog","Modliboga","Mojmir","Mojmira",
            "Mojżesz","Monika","Montan","Mordechaj", "Morzysław","Morzysława","Mroczysław","Mszczuj","Mszczuja","MściborMścigniew","MścisławMścisława","Mściwoj","Mściwuj","Mucjusz",
            "Mysław","Myślibor","Myślibora","Myślidar","Myślimir",


            "Nabor","Nabur","Naczęmir","Naczęrad","Naczęsław","Naczęsława","Naczęwoj","Naczęwuj","Nadar","Nadbor","Nadmir","Nadzieja","Nadia","Nagod","Nahum","Namir","Namysław",
            "Napoleon","Narcyz","Narcyza","Narzes","Nasiębąd","Nasiębor","Nasięgniew","Nasław","Nasława","Natalia","Natasza",
            "Natalis","Natan","Natanael","Nataniel","Nawoj","Nawoja","Nawuj","Nazaria","Nazariusz","Nażyr","Neftali","Nela","Nemezja","Nemezjusz","Nemezy","Neonila","Nepomucen",
            "Nepomucena","Nereusz","Nestor","Nicefor","Nikifor","Nicefora","Niceta","Nicetas","Niecisław","Niedamir","Niegodoma",
            "Niegosław","Niegosława","Niegowoj","Niemir","Niemst","Nienach","Niepełka","Nieprasz","Nierad","Nierod","Niesąd","Niesiebąd","Niesiebor",
            "Niesiodł","Niestanka","Niestoj","Niesuł","Nietęg","Nieznamir","Nieznawuj","Nika","Nikander","Nikandra","Nikanor","Nikanora","Nikazjusz" ,
            "Nikazy","Nikodem","Nikodema","Nikola","Nikoleta","Nikolina","Nikomedes","Nikon","NilaNilus","Nimfa","Nimfodora","Nina","Ninian","Ninogniew","Ninomysł","Noe","Noemi","Nonna",
            "Nonnus","Norbert","Norberta","Norma","Norman","Nostrian","Notger","Nowellon","Nunila","Nunilona",

            "Objęsław","Ocięsław","Oda","Odeta","Odo","Odon","Odoryk","Odylon","Odyseusz","Odys","Ofelia" ,"Okrzesław","Oktawia","Oktawian","Oktawiusz","Olaf",
            "Oldmir","Olga","Olgierd","Olimpia","Olimpiusz","Oliwer","Oliwia","Oliwier","Oliwiusz","Ondrzeja","Onezyfor","Onezym","Onold","Onufry","Optat","Orencjusz",
            "Orestes","Orfeusz","Orion","Osiębor","Osięgniew","Oskar","Osmund","Ostap","Ostrobod","Oriana","Ostrogniew","Ostrowod","Oswald","Oswalda","Otmar","Otokar","Otto",
            "Otton","Otylia","Owidia","Owidiusz","Ozeasz","Ożanna",

            "Pachomiusz","Pacyfik","Pafnucy","Pakosław","Pakosława","Paladiusz","Palemon","Palemona","Palmira","","Paloma","Pamela","Pamfil","Pamfilia",
            "Pankracy","Pantaleon","Papiasz","Paramon","Parascewa","","Parsifal","Partenia","Parteniusz","Parys","Paryzjusz","Paschalina","Paschalis","Paschazy",
            "Patapiusz","Patrokles","Patrycja","Patrycjusz","Patrycy","Patryk","Paula","Paulin","","Paulina","Paweł","Pelagia","Pelagiusz","Pelin","Pelina","Pełczybog",
            "Penelopa","Pepin","Peregryn","Perpetua","Perpetuus","Petronela","Petronia","Petroniusz","Pęcisław","Pęcisława","Pękosław","Pękosława","Pężyrka","Pia","Pioniusz",
            "Piotr","Piotra","Pius","Placyd","Placyda","Platon","Platonida","","Plautylla","Plutarch","Pola","Polian","Poliana","Polianna","Polichroniusz","Polidor","Polieukt",
            "Polikarp","Poliksena","Pomir","Pompejusz","Pompiliusz","Pomponiusz","","Pomścibor","Poncjan","Poncjusz","Porfirion","Porfiriusz","Porfiry","Potapiusz","Potencjana",
            "Potencjanna","Poznomir","Prakseda","Priam","Probus","Prochor","Prokles","Prokop","Prokul","Prosimir","Prosper","Prospera","Prot","Protazja","Protazy","Prudencjusz",
            "Pryma","Prymian","Prymityw","Prymus","Pryscylla","Pryska","Pryskus","Przebąd","Przebor","PrzeborkaPrzecław","Przecława","Przedabog","Przedbor","Przedmir","Przedpełk",
            "Przedsław","Przedsława","Przedwoj","Przedwuj","Przemęt","Przemił","Przemir","Przemysł","Przemysław","Przemysława","Przemyślibor","Przesław","Przesława","Przezdziad","Przezpraw",
            "Przezprawa","Przezprzem","Przybor","Przybycześć","Przybygniew","Przybylut","Przybymir","Przybyrad","Przybysław","Przybysława","","Przybywoj","Przybywuj","Przysnobor","Przywit",
            "Ptolemeusz","Publiusz","Pudencjana","Pudencjanna","Pulcheria",

            "Rachela","Racibor","Racigniew","Racimir","Racisław","Radbod","Radegunda","Radmir","Radociech","","Radogost","Radomił","Radomiła","Radomir","Radomira","Radosław",
            "Radosława","Radowit","Radowuj","Radsuł","Radzim","Radzisław","Radzisława","Rafał","Raisa","Rajner","Rajmund","Rajmunda","Ramona","Racsław","Racsława","Rajnold",
            "Rambert","Rebeka","Regina","Reginald","Reginbald","Remigia","Remigiusz","Remus","Renat","Renata","Retycja","Retyk","Robert","","Roberta","Roch","Rodomił","Rodsław",
            "Roderyk","Rogacjusz","Rogat","Roger","Roksana","Roland","Roma","Roman","Romana","Romaryk","Romeusz","Romuald","Romualda","Romula","Romulus","Ronald","Rosław","","Rosława",
            "Rościgniew","Rościsław","Rościsława","Rozalia","Rozalinda","Rozamunda","Rozwita","Róża","Ruben","Rudolf","Rudolfa","Rudolfina","Rufin","Rufina","Rufus","Rustyk","Rustyka",
            "Ruta","Rutyliusz","Rycheza","Rygobert","Ryksa","Rymwid","Rypsyma","Ryszard","Ryszarda","Ryta","Rzędzimir","Rzędzisław","Rzędziwoj",


            "Sabin","Sabina","Sabinian","Sabrina","Sadok","Safira","Salomea","Salomon","Salustia","Salwator","Salwin","Salwina","Salomea","Samanta","Samboja","Sambor","Samogost",
            "Samson","Samuel","Samuela","Sancja","Sandra","Sara","Sarbeliusz","Sator","Satora","Satur","Satura","Saturnin","Saturnina","Sawin","Scholastyka","Scypion","Sebald",
            "Sebastian","Sebastiana","Sebbus","Segolena","Seksburga","Sekunda","Sekundyn","Seleukos","Septym","Septymiusz","Serafin","Serafina","Serapia","Serapion","Seren","Serena",
            "Sergia","Sergiusz","Serwacy","Serwiusz","Serwul","Sewer","Sewera","Sewerian","Seweryn","Seweryna","Sęczygniew","Sędowin","Sędowoj","Sędzimir","Sędzisław","Sędzisława","Sędziwoj",
            "Sędziwuj","Sędźwoj","Sężyr","Siabor","Siabora","Siebąd","Siebor","Sieciebor","Sieciech","Sieciesław","Sieciesława","Siecław","Siecława","Siecsław","Siecsława","SiedlewitSiemidrog",
            "Siemierz","Siemił","Siemimił","Siemir","Siemirad","Siemimysł","Siemisław","Siemomysł","Siemoradz","Siemowit","Siepraw","Sierosław","Sierosława","Siesław","Siesława","Siestrzemił",
            "Siestrzewit","Sięgniew","Sięgniewa","Siężyr","Sirosław","Sirosława","Sjęgniew","Sjęgniewa","Skamir","Skarbimir","Skarbimira","Skarbimirz","Skarbisław","Skardmir","Sławobor",
            "Sławobora","Sławociech","Sławomiar","Sławomir","Sławomira","Sławomirza","Sławosław","Smaragd","Smysław","Smysława","Snowid","Sobiebor","Sobiemir","Sobiemysł","Sobierad","Sobiesąd",
            "Sobiesław","Sobiesława","Sobieżyr","Sofoniasz","Sofronia","Sofroniusz","Sokrates","Sostenes","Soter","Sotera","Sozont","Sozypater","Sperat","Spirydon","Spycigniew","Spycimir",
            "Stanibor","Stanimir","Stanisław","Stanisława","Stasław","Stefan","Stefania","Stella","Stoisław","Stoisława","Stojgniew","Stojsław","Stojsława","Stomir","Stosław","Strachomir",
            "Strogobor","Strogomir","Stronisław","Stronisława","Strosław","Strzebor","Strzecław","Strzecsław","Strzedziwoj","Strzedzsław","Strzesław","Strzesława","Strzeżymir","Strzeżysław",
            "Strzeżysława","Stylian","Sudywoj","Sulibor","Sulibrat","Sulidziad","Suligniewa","Suligost","Sulimir","Sulimiar","Sulmir","Sulirad","Sulisław","Sulisława","Sulistryj","Suliwuj",
            "Sulpicjusz","Switbert","Switun","Swojsław","Sybilla","Sybillina","Sydonia","Sydoniusz","Sykstus","Sylas","Sylwan","Sylwana","Sylweriusz","Sylwester","Sylwestra","Sylwia",
            "Sylwin","Sylwina","Sylwiusz","Symeon","Symforian","Symforiana","Symforoza","Symmach","Symplicja","Symplicjusz","Symplicy","Synezjusz","Syriusz","Syrycjusz","Syzyniusz","Szabor",
            "Szabora","Szaweł","Szebor","Szczepan","Szczęsna","Szczęsny","Szmaragd","Szymon","Szymona",


            "Ścibor","Ścibora","Śnieżka","Świebąd","Świebor","Świebora","Świeciech","Świecław","Świedarg","Świegniew","Świelub","Świemił","Świemir","Świerad",
            "Świetlana","Święcsława","Święsława","Świętobor","Świętomir","Świętomira","Świętopełk","Świętosław","Świętosława","Świętożyźń",

            "Tacjan","Tacjana","Tacjanna","Tatiana","Tacjusz","Tadea","Tadeusz","Taida","Tala","Taleleusz","Talita","Talus","Tamara","Tankred","Tarazjusz","Tarsycja",
            "Tarsycjusz","Tarsylia","Tatomir","Tekla","","Telesfor","Telesfora","Telimena","Temistokles","Teobald","Teobalda","Teodor","Teodora","Teodoryk","Teodot","Teodota",
            "Teodozja","Teodozjusz","Teodozy","Teodul","Teodulf","Teofan","Teofania","Teofil","Teofila","Teofilakt","Teogenes","Teona","Teonas","Teonilla","Teopist","Teopista",
            "Teotyk","Teotym","Tercjusz","Terencja","Terencjusz","Teresa","Tertulia","Tertulian","Tertuliana","Tespezjusz","Tespezy","Tezeusz","Tęgomir","Tina","Tobiasz","Tola",
            "Toligniew","Tolisław","Tolisława","Tomaida","Tomasz","Tomił","Tomiła","Tomir","Tomira","Tomisław","Tomisława","Torlak","Tosław","Treweriusz","Tristan","Troadiusz","Trofim",
            "Trofima","Trojan","Tryfena","Tryfiliusz","Tryfon","Tryfonia","Trzebiebor","Trzebiegost","Trzebiemir","Trzebiesław","Trzebiesława","Trzebomysł","Trzebor","Trzebowit","Tulia",
            "Tuliusz","Turybiusz","","Tuskana","Twardomir","Twardosław","Twardostoj","Tworzymir","Tworzysław","Tworzysława","Tybald","Tyberiusz","Tyburcja","Tyburcjusz","Tyburcy","Tychik",
            "Tychon","Tycjan","Tycjana","","Tygriusz","Tymon","Tymona","Tymoteusz","Tyrs","Tyter","Tytus",


            "Ubald","Ubysław","Ubysława","Udalryk","Ulryk","Ulryka","Unieboż","Uniedrog","Uniegost","Uniemir","Uniemysł","Unierad","Uniesław","Uniesława","Uniewit","Unold",
            "Urban","Uriel","Ursus","Ursycyn","","Ursyn","Urszula","Uściwoj",


            "Wacław","Wacława","Walbert","Walburga","Waldebert","Waldemar","Waldetruda","Walenty","Walentyn","","Walentyna","Waleria","Walerian",
            "Waleriana","Waleriusz","Walery","Walter","Waltrauda","Walwan","","Wanda","Wanesa","Wanessa","Warcisław","Wawrzyniec","Wedast","Wenancja","Wenancjusz","Wenanty","Wendelin",
            "Wenefryda","Wenerand","Werena","Wergilia","Wiara","Wiera","Wergiliusz","Weridiana","","Werner","Weronika","Wespazjan","Westyna","Wędziemir","Wiator","Wibert","Wielebor",
            "Wielebyt","Wieledrog","Wielimir","Wielisław","Wielisława","Wieńczysław","Wiercisław","Wierzyn","Wiesław","Wiesława","Więcemił","Więcemir","Więcerad","Więcesław","Więcesława",
            "Wigbert","Wigilia","","Wigiliusz","Wiktor","Wiktoria","Wiktorian","Wiktoriana","Wiktorianna","Wiktoryn","Wiktoryna","","Wilburga","Wilehad","Wilfryd","Wilhelm","Wilhelmina",
            "Wilibald","Wilibrord","Wilkomir","","Wiltruda","Winand","Winanda","Wincencja","Wincenta","Wincenty","Wincentyna","Winibald","","Winebald","Winibalda","Winicjusz","Wiola","Wioleta",
            "Wioletta","Wirciżyr","Wirgiliusz","Wirgilia","Wirginia","Wirginiusz","Wiron","Wirzchosław","Wirzchosława","Wirydiana","Wisław","","Wisława","Wit","Witalia","Witalian","Witalis",
            "Witburga","Witold","Witolda","Witomir","Witomysł","","Witosław","Witosława","Wiwald","Wiwina","Władysław","Władysława","Włodzimierz","Włodzimir","Włodzimira","Włodzisław",
            "Włodzisława","Włościbor","Włościbyt","Włościsława","Włościwoj","Wojbor","Wojciech","Wojciecha","Wojemił","Wojmir","Wojsław","Wojsława","WolfgangWolebor","Wolimir","Wolisław",
            "Wolisława","Wolrad","Wrocisław","Wrociwoj","Wrocsława","Wszebąd","Wszebor","Wszebora","Wszeciech","Wszegniew","Wszemił","Wszemiła","Wszemir","Wszesiodł","Wszesuł","","Wszetopełk",
            "Wulfram","Wulstan","Wunibald","Wysław","Wysława","Wyszebor","Wyszemir","Wyszeniega","","Wyszesław","Wyszesława","Wyszetrop","Wyszomir",


            "Zabulon","Zachariasz","Zachary","Zacheusz","Zadar","Zawisza","","Zbigniew","Zbigniewa","Zbrosław","","Zbygniew","Zbygniewa","Zbylut","Zbysław","Zbysława","Zbywoj",
            "Zdamir","Zdawuj","Zdzibor","","Zdziczest","Zdziebąd","Zdziebud","Zdziegod","Zdziegrod","Zdziemił","Zdziemir","Zdzierad","","Zdziesław","Zdziesława","Zdziesuł","Zdziewit",
            "Zdziewuj","Zdzigod","Zdzigrod","Zdzimir","","Zdzisław","Zdzisława","Zdzistryj","Zdziwoj","Zdziwuj","Zefiryn","Zefiryna","Zenaida","Zenobia","","Zenobiusz","Zenon","Zenona",
            "Ziemowit","Zoe","Zofia","Zotyk","Zozym","Zuzanna","Zwnisław","Zwnisława","Zybert","Zybracht","Zybart","Zygbert","Zygfryd","Zygfryda","Zyglinda","Zygmunt","Zygmunta","Zyndram",
            "Zyta",

            "Żaklina","Żaneta","Żanna","Żegota","Żelibor","Żelibrat","Żeligniew","Żelimysł","Żelisław","Żelisława","Żelistryj","Żeliwuj","Żyrosław","Żyrosława","Żywia","Żywila",



            "ciebie również", "ciebie rowniez", "również", "rowniez", "równiez", "rownież",
            "miło", "miła", "miłe", "miły",  "milo", "mila", "mila", "mile", "mily",
            "fajnie", "fajna", "fajne", "fajny",
            "tak właśnie jest", "tak właśnie", "tak wlasnie", "tak własnie", "tak wlaśnie",
            "tak, właśnie jest", "tak, właśnie", "tak, wlasnie", "tak, własnie", "tak, wlaśnie",
            "studi",
            "teraz",
            "tak mam", "tak, mam",
            "bardzo lubie", "bardzo lubię",
            "tworzę", "tworze",
            "mam nadzieję", "mam nadzieje",
            "nie narzekam", // ciekawe
            "uważa", "uwaza",
            "słyszał", "slyszal", "słyszal", "slyszał",
            "chodz",
            "specjal",
            "zbyt",
            "ciesz",
            "czego",
            " U mnie wszystko ok",
            "jest",
            "był", "byl",
            "polec",
            "tak",
            
            "rozum",
            "kup",
            "czas",
            "spok",
            "ale",
            " o ",
            "tobi",
            "wole","wolę",
            "kebab", "pizz", "hamburger", "zapiekank",
            "mały", "malutki", "maly",
            //liczby
            "1", "2", "3", "4","5","6","7","8","9","10","12","13","14","15","16", "17","18","19","20","0",


        };
        string[] OdpTW_2 = {
          "uwielbiam", "oczywiście, że uwielbiam", "oczywiscie, ze uwielbiam",
            "jeszcze jak", "jeszce jak", "jesce jak", "jescze jak", "jak ", "jka ", "jk",
            "jeszce jak",
            "ulubiony", "ulubiona", "ulubione", "lubić", "lubic",
            "najbardziej lubie", "najbardziej lubię",
            "jest dobrze",
            "wszystko jest ok", "jest ok",
            "jak należy", "jak nalezy",
            "piłka", "pilka", "siatk", "hokej", "rugby", "pływa", "plywa", "rower",
            "prac",
            "ciekawie", "ciekawe", "ciekawa", "ciekawy",
            "myśl", "mysl",
            "twierdz",
            "zgadza", "kto",
            "rozw",
            "ulubi",
            "dzięk", "dziek",
            "dzieki za", "dzięki za", "dzieki",  "dzięki",
             "miasto", "wieś", "wies,",
             "mieć", "miec",
             "prawd",
             "wdroż",
             "się", "sie",
             " lat",
             "miesi",
             "rok",
             "od ",
             "do ",
             "posiad",
             // kraje
             //

        };
        string[] OdpNG = {
        " nie,", " nie.", " nie ",

            "niedobrze",  "fatalnie","nie lubie" ,
            "jest źle", "jest zle", "źle", "zle", "złe", "zły", "zła", "zly", "zla",
            "miernie", "mierna", "mierna", "mierny",
            "nie jest kolorowo", "nie jest ",
            "niezbyt",
            "nie mam",  //do ugadania
            "nie pracuje", "nie pracuję",
            "coś ty", "cos ty",
            "nie miło", "nie miła",  "nie miłe", "nie miły",  "nie milo", "nie mila", "nie mila", "nie mile", "nie mily",
            "nie fajnie", "nie fajna", "nie fajne", "nie fajny",
            "nie ciekawie", "nie ciekawe", "nie ciekawa", "nie ciekawy",
            "nie studi",
            "nie teraz",
            "bardzo nie lubię", "bardzo nie lubie",
            "kiepsko", "kiepska", "kiepski", "kiepskie",
            "nie kocham",
            "nie tworze", "nie tworzę",
            "nie mam nadziei",
            "nie uważa", "nie uwaza",
            "nie słyszał", "nie slyszal", "nie slyszał", "nie słyszal",
            "nie chodz",
            "nie myśl", "nie mysl",
            "nie twierdz",
            "nie specjal",
            "nie zbyt",
            "nie ciesz",
            "nie czego",
            "nie zgadza",
            "nie jest",
            "kto nie",
            "nie rozw",
            "nie był", "nie byl",
            "nie ulubi",
            "nie posiad",
            "nie dzięk", "nie dziek",
            "nie rozum",
            "nie kup",
            "nie czas",
            "nie spok",
            "nie, ale", "nie ale",
            "nie dzieki za",  "nie dzięki za", "nie dzieki",  "nie dzięki",
            "nie tobi",
            "nie jestem",
            "nie nazywa",
            "nie a",
            "nie nawidzę", "nie nawidze", "nienawidzę", "nienawidze", "niena widze", "niena widzę",


        };
   
    }
}
