using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca
{
    public class Documento
    {
        public string Codice { get; } = "DOC" + Random.Shared.Next(0, 999);
        public string Titolo { get; set; }
        public int Anno { get; set; }
        public string Settore { get; set; }
        public string PosizioneScaffale { get; set; }
        public string Autore { get; set; }

        public Documento(string titolo, int anno, string settore, string posizioneScaffale, string Autore) { 
            this.Anno = anno;
            this.Settore = settore;
            this.Titolo = titolo;
            this.PosizioneScaffale = posizioneScaffale;
            this.Autore = Autore;
        }
    }
}
