using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LeituraArquivos.Models
{
    [Table("tb_ide")]
    public class NFe
    {
        [Display(Name = "Chave de acesso")]
        [Key]
        public string? Id { get; set; }  
        [Display(Name = "Versão")]
        [Column("versao")]
        public string? Versao { get; set; }

        [Display(Name = "Codigo do emitente")]
        [Column("cuf")]
        public int CUf { get; set; }

        [Display(Name = "Chav. do emitente")]
        [Column("cnf")]
        public int CNf { get; set; }

        [Display(Name = "Natureza da operação")]
        [Column("natop")]
        public string? NatOp { get; set; }

        [Display(Name = "Modelo")]
        [Column("modelo")]
        public int Mod { get; set; }

        [Display(Name = "Serie")]
        [Column("serie")]
        public int Serie { get; set; }

        [Column("nnf")]
        public int Nnf { get; set; }

        [Display(Name = "Data e hora de emis.")]
        [Column("dhemi",TypeName = "date")]
        public DateTime DhEmi { get; set; }

        [Column("dhsaient", TypeName = "date")]
        public DateTime DhSaiEnt { get; set; }

        [Display(Name = "Tipo de Operação")]
        [Column("tpnf")]
        public int TpNf { get; set; }

        [Column("iddest")]
        public int IdDest { get; set; }

        [Column("cmunfg")]
        public int CMunFG { get; set; }

        [Column("tpimp")]
        public int TpImp { get; set; }

        [Column("tpemis")]
        public int TpEmis { get; set; }

        [Column("cdv")]
        public int CDv { get; set; }

        [Column("tpamb")]
        public int TpAmb { get; set; }

        [Column("finnfe")]
        public int FinNFe { get; set; }

        [Column("indfinal")]
        public int IndFinal { get; set; }

        [Column("indpres")]
        public int IndPres { get; set; }

        [Column("procEmi")]
        public int ProcEmi { get; set; }

        [Column("verProc")]
        public int VerProc { get; set; }

        public string? Caminho { get; set; }

        public Emitente? Emitentes { get; set; }
        public Destinatario? Destinatarios { get; set; }

        public NFe()
        {

        }
        public NFe(string? versao, string? id, int cUf, int cNf, string? natOp, int mod, int serie, int nnf, DateTime dhEmi, DateTime dhSaiEnt, int tpNf, int idDest, int cMunFG, int tpImp, int tpEmis, int cDv, int tpAmb, int finNFe, int indFinal, int indPres,string? caminho, Emitente emit, Destinatario desti)
        {
            Versao = versao;
            Id = id;
            CUf = cUf;
            CNf = cNf;
            NatOp = natOp;
            Mod = mod;
            Serie = serie;
            Nnf = nnf;
            DhEmi = dhEmi;
            DhSaiEnt = dhSaiEnt;
            TpNf = tpNf;
            IdDest = idDest;
            CMunFG = cMunFG;
            TpImp = tpImp;
            TpEmis = tpEmis;
            CDv = cDv;
            TpAmb = tpAmb;
            FinNFe = finNFe;
            IndFinal = indFinal;
            IndPres = indPres;
            Caminho = caminho;
            Emitentes = emit;
            Destinatarios = desti;
        }

    }
}
