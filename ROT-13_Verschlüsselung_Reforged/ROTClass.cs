using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ROT_13_Verschlüsselung
{
    class ROTClass
    {
        static void Main(string[] args)
        {
            var dateipfad = EinUndAusgabe.GebePfadEin();
            var eingabe = "";

            eingabe = EinUndAusgabe.LeseDatei(dateipfad);
            eingabe = Verarbeitung.ErsetzeUmlaute(eingabe);
            eingabe = Verarbeitung.SchreibeZeichenKlein(eingabe);
            eingabe = Verarbeitung.VerschlüsselZeichen(eingabe);
            dateipfad = EinUndAusgabe.GebePfadEin();
            EinUndAusgabe.SchreibeDatei(dateipfad, eingabe);
        }
    }

    public class EinUndAusgabe
    {
        public static string GebePfadEin()
        {
            Console.WriteLine("Bitte geben Sie den Dateipfad an wo die Datei liegt, bzw. wo sie abgespeichert werden soll: ");
            return Console.ReadLine();
        }

        public static string LeseDatei(string dateipfad)
        {
            System.IO.StreamReader file = new System.IO.StreamReader(@dateipfad, Encoding.Default);
            return file.ReadToEnd();
        }

        public static void SchreibeDatei(string dateipfad, string ausgabe)
        {
            System.IO.File.WriteAllText(@dateipfad, ausgabe);
        }
    }

    public class Verarbeitung
    {
        public static string ErsetzeUmlaute(string eing)
        {
            eing = eing.Replace("ä", "ae");
            eing = eing.Replace("ö", "oe");
            eing = eing.Replace("ü", "ue");
            eing = eing.Replace("ß", "ss");

            return eing;
        }

        public static string SchreibeZeichenKlein(string eing)
        {
            return eing.ToLower();
        }

        public static string VerschlüsselZeichen(string eing)
        {
            Dictionary<string, string> Schlüssel = new Dictionary<string, string>();
            Schlüssel.Add("0", "D");
            Schlüssel.Add("1", "E");
            Schlüssel.Add("2", "F");
            Schlüssel.Add("3", "G");
            Schlüssel.Add("4", "H");
            Schlüssel.Add("5", "I");
            Schlüssel.Add("6", "J");
            Schlüssel.Add("7", "K");
            Schlüssel.Add("8", "L");
            Schlüssel.Add("9", "M");
            Schlüssel.Add("a", "N");
            Schlüssel.Add("b", "O");
            Schlüssel.Add("c", "P");
            Schlüssel.Add("d", "Q");
            Schlüssel.Add("e", "R");
            Schlüssel.Add("f", "S");
            Schlüssel.Add("g", "T");
            Schlüssel.Add("h", "U");
            Schlüssel.Add("i", "V");
            Schlüssel.Add("j", "W");
            Schlüssel.Add("k", "X");
            Schlüssel.Add("l", "Y");
            Schlüssel.Add("m", "Z");
            Schlüssel.Add("n", "0");
            Schlüssel.Add("o", "1");
            Schlüssel.Add("p", "2");
            Schlüssel.Add("q", "3");
            Schlüssel.Add("r", "4");
            Schlüssel.Add("s", "5");
            Schlüssel.Add("t", "6");
            Schlüssel.Add("u", "7");
            Schlüssel.Add("v", "8");
            Schlüssel.Add("w", "9");
            Schlüssel.Add("x", "A");
            Schlüssel.Add("y", "B");
            Schlüssel.Add("z", "C");
            Schlüssel.Add(" ", " ");

            foreach (KeyValuePair<string, string> eintrag in Schlüssel)
            {
                var wert = eintrag.Value;
                eing = eing.Replace(eintrag.Key, wert);
            }
            return eing;
        }
    }
}