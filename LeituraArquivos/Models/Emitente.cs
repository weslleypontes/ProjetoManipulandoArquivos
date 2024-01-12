using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace LeituraArquivos.Models
{
    [Table("tb_emit")]
    public class Emitente : Endereco
    {
        [Key]
        public int Id { get; set; }
        [Column("cnpj")]
        public string? CNPJ { get; set; }
        [Column("cpf")]
        public int CPF { get; set; }
        [Display(Name = "Razão social")]
        [Column("xnome")]
        public string? XNome { get; set; }
        [Display(Name = "Nome da empresa")]
        [Column("xfant")]
        public string? XFant { get; set; }

        public ICollection<ProdServ> ProdServs { get; set; }
        public Emitente(string? cNPJ, string? xNome, string? xFant,
            string? xLgr, string? nro, string? xBairro, int cMun, string? xMun,
            string? uF, int cEP, int cPais, string? xPais, string? fone, string? iE, int cRT)
        {
            CNPJ = cNPJ;
            XNome = xNome;
            XFant = xFant;
            XLgr = xLgr;
            Nro = nro;
            XBairro = xBairro;
            CMun = cMun;
            XMun = xMun;
            UF = uF;
            CEP = cEP;
            CPais = cPais;
            XPais = xPais;
            Fone = fone;
            IE = iE;
            CRT = cRT;
        }

        public void AddProdServ(ProdServ prodServ)
        {
            ProdServs.Add(prodServ);
        }
    }
}
