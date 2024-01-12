using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LeituraArquivos.Models
{
    
    public class Endereco
    {
        [Display(Name = "Logadouro")]
        [Column("xLgr")]
        public string? XLgr { get; set; }

        [Display(Name = "Numero")]
        [Column("nro")]
        public string? Nro { get; set; }
        [Column("xcpl")]
        public string? XCpl { get; set; }

        [Display(Name = "Bairro")]
        [Column("xbairro")]
        public string? XBairro { get; set; }
        [Column("cmun")]
        public int CMun { get; set; }

        [Display(Name = "Município")]
        [Column("xmun")]
        public string? XMun { get; set; }

        [Display(Name = "UF")]
        [Column("uf")]
        public string? UF { get; set; }

        [Display(Name = "CEP")]
        [Column("cep")]
        public int CEP { get; set; }
        [Column("cpais")]
        public int CPais { get; set; }

        [Display(Name = "Pais")]
        [Column("xpais")]
        public string? XPais { get; set; }
        [Column("fone")]
        public string? Fone { get; set; }
        [Column("ie")]
        public string? IE { get; set; }
        [Column("iest")]
        public string? IEST { get; set; }
        [Column("crt")]
        public int CRT { get; set; }
        [Column("indIEDest")]
        public int IndIEDest { get; set; }
        [Column("emails")]
        public string? Email { get; set; }
    }
}
