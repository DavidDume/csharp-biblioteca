using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca
{
    public class Libro : Documento
    {
        public string NPagine {  get; private set; }
        public Libro(string titolo, int anno, string settore, string posizioneScaffale, string autore, string nPagine) : base(titolo, anno, settore, autore, posizioneScaffale) {
            this.NPagine = nPagine;
        }
    }
}
