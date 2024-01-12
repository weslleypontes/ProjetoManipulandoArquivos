using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LeituraArquivos.Models
{
    [Table("tb_prod_serv")]
    public class ProdServ
    {
        public int Id { get; set; }
        [Column("nItem")]
        public int NItem { get; set; }

        [Column("cprod", TypeName= "TEXT(60)")]
        public string? CProd { get; set; }

        [Column("cean", TypeName = "TEXT(14)")]
        public string? CEAN { get; set; }

        [Display(Name = "Descrição")]
        [Column("xprod", TypeName = "TEXT(120)")]
        public string? XProd { get; set; }
        
        [Column("ncm")]
        public int NCM { get; set; }

        [Column("cfop", TypeName = "TEXT(6)")]
        public int CFOP { get; set; }

        [Column("cest")]
        public int CEST { get; set; }

        [Display(Name = "Unid. Com.")]
        [Column("ucom", TypeName = "TEXT(6)")]
        public string? UCom { get; set; }
        [Display(Name = "Quantidade")]
        [Column("qcom", TypeName = "decimal(15, 4)")]
        public decimal QCom { get; set; }

        [Display(Name = "Valor Unit.")]
        [Column("vuncom", TypeName = "decimal(21, 10)")]
        public decimal VUnCom { get; set; }

        [Display(Name = "Valor Prod.")]
        [Column("vprod", TypeName = "decimal(15, 2)")]
        public decimal VProd { get; set; }

        [Column("ceantrib", TypeName = "TEXT(14)")]
        public string? CEANTrib { get; set; }

        [Column("utrib", TypeName = "TEXT(6)")]
        public string? UTrib { get; set; }

        [Column("qtrib", TypeName = "decimal(15, 4)")]
        public decimal QTrib { get; set; }

        [Column("vuntrib", TypeName = "decimal(21, 10)")]
        public decimal VUnTrib { get; set; }

        [Column("indtot")]
        public int IndTot { get; set; }
        public Emitente Emitentes { get; set; }

        public ProdServ() { }

        public ProdServ(int nItem, string? cProd, string? cEAN, string? xProd, int nCM, int cFOP, int cEST, string? uCom, decimal qCom, decimal vUnCom, decimal vProd, string? cEANTrib, string? uTrib, decimal qTrib, decimal vUnTrib, int indTot, Emitente emitente)      
        {
            NItem = nItem;
            CProd = cProd;
            CEAN = cEAN;
            XProd = xProd;
            NCM = nCM;
            CFOP = cFOP;
            CEST = cEST;
            UCom = uCom;
            QCom = qCom;
            VUnCom = vUnCom;
            VProd = vProd;
            CEANTrib = cEANTrib;
            UTrib = uTrib;
            QTrib = qTrib;
            VUnTrib = vUnTrib;
            IndTot = indTot;
            Emitentes = emitente;
        }
    }
}
