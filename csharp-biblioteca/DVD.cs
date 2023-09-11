using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca
{
    public class DVD : Documento
    {
        public int Durata { get; private set; }
        public DVD(string titolo, int anno, string settore, string posizioneScaffale, string autore, int durata) : base(titolo, anno, settore, autore, posizioneScaffale) {
            this.Durata = durata;
        
        }
    }
}
