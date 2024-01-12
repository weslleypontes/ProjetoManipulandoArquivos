using System.Collections.Generic;
namespace LeituraArquivos.Models.ViewModels
{
    public class NotaFiscalViewModels
    {
        public NFe? NotaFiscal{ get; set; }
        public Emitente? Emitente{ get; set; }
        public Destinatario? Destinatario { get; set; }
        public IEnumerable<ProdServ>? ProdServs { get; set; }
    }
}
