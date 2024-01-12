using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace LeituraArquivos.Models
{
    [Table("tb_desti")]
    public class Destinatario : Endereco
    {
        [Key]
        public int Id { get; set; }
        [Column("cnpj")]
        public string? CNPJ { get; set; }

        [Display(Name = "Razão social")]
        [Column("xnome")]
        public string? XNome { get; set; }

        public Destinatario() { }
        public Destinatario(string? cNPJ, string? xNome,
            string? xLgr, string? nro, string? xBairro, int cMun, string? xMun,
            string? uF, int cEP, int cPais, string? xPais, int indIEDest, string? iE)
        {
            CNPJ = cNPJ;
            XNome = xNome;
            XLgr = xLgr;
            Nro = nro;
            XBairro = xBairro;
            CMun = cMun;
            XMun = xMun;
            UF = uF;
            CEP = cEP;
            CPais = cPais;
            XPais = xPais;
            IndIEDest = indIEDest;
            IE = iE;
        }
    }
}
