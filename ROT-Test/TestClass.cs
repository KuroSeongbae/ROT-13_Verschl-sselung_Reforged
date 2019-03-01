using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using ROT_13_Verschlüsselung;


namespace ROT_Test
{
    [TestFixture]
    public class TestClass
    {
        [Test, Category("Gerüsttest")]

        // Je nach Pfad der .txt Datei muss Pfad geändert werden
        // Ebenso je nachdem was in der .txt steht muss Ausgabe verändert werden
        public void DateiLesen()
        {
            var ergebnis = EinUndAusgabe.LeseDatei(@"Z:\Programmierung\VisualStudio\Konsolenanwendungen\Test.txt");
            Assert.AreEqual("Hallöle Welt\r\nasdf", ergebnis);
        }

        [Test, Category("Gerüsttest")]

        public void UmlauteErsetzen()
        {
            var ergebnis = Verarbeitung.ErsetzeUmlaute("Hallülä Wöltß");
            Assert.AreEqual("Halluelae Woeltss", ergebnis);
        }

        [Test, Category("Gerüsttest")]

        public void ZeichenKleinchreiben()
        {
            var ergebnis = Verarbeitung.SchreibeZeichenKlein("HaLlO wElT");
            Assert.AreEqual("hallo welt", ergebnis);
        }

        [Test, Category("Gerüsttest")]

        public void ZeichenVerschlüsseln()
        {
            var ergebnis = Verarbeitung.VerschlüsselZeichen("ha11o we!t?");
            Assert.AreEqual("UNEE1 9R!6?", ergebnis);
        }
    }
}
