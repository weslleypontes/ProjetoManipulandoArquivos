using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LeituraArquivos.Models
{
    [Table("tb_nfe")]
    public class NFe
    {
        [Display(Name = "Versão")]
        [Column("versao", TypeName = "char(4)")]
        public string? Versao { get; set; }

        [Column("id", TypeName = "char(47)")]
        public string? Id { get; set; }

        [Column("cuf", TypeName = "int(2)")]
        public int cuf { get; set; }

        [Column("cnf", TypeName = "int(8)")]
        public int cnf { get; set; }

        [Column("natop", TypeName = "char(60)")]
        public string? NatOp { get; set; }

        [Column("mod", TypeName ="int(2)")]
        public int Mod { get; set; }

        [Column("serie", TypeName = "int(3)")]
        public int Serie { get; set; }

        [Column("nnf", TypeName = "int(9)")]
        public int Nnf { get; set; }

        [Column("dhemi",TypeName = "date")]
        public DateTime DhEmi { get; set; }

        [Column("dhsaient", TypeName = "date")]
        public DateTime DhSaiEnt { get; set; }

        [Column("tpnf", TypeName = "int(1)")]
        public int TpNf { get; set; }

        [Column("iddest", TypeName = "int(1)")]
        public int IdDest { get; set; }

        [Column("cmunfg", TypeName = "int(7)")]
        public int CMunFG { get; set; }

        [Column("tpimp", TypeName = "int(1)")]
        public int TpImp { get; set; }

        [Column("tpemis", TypeName = "int(1)")]
        public int TpEmis { get; set; }

        [Column("cdv", TypeName ="int(1)")]
        public int CDv { get; set; }

        [Column("tpamb", TypeName = "int(1)")]
        public int TpAmb { get; set; }

        [Column("finnfe", TypeName = "int(1)")]
        public int FinNFe { get; set; }

        [Column("indfinal", TypeName = "int(1)")]
        public int IndFinal { get; set; }

        [Column("indpres", TypeName = "int(1)")]
        public int IndPres { get; set; }
    }
}
