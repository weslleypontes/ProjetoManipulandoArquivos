using System.Xml;
using LeituraArquivos.Data;
using LeituraArquivos.Models;
namespace LeituraArquivos.Services
{
    public class DestinatarioService
    {
        //Dados Destinatario
        string? _id = "";
        string? d_cNPJ = "";
        string? d_xNome = "";
        string? d_nFeId = "";
        string? d_xLgr = "";
        string? d_nro = "";
        string? d_xCpl = "";
        string? d_xBairro = "";
        int d_cMun = 0;
        string? d_xMun = "";
        string? d_uf = "";
        int d_cep = 0;
        int d_cPais = 0;
        string? d_xPais = "";
        int d_indIEDest = 0;
        string? d_ie = "";
        Destinatario desti;
        private readonly AppDbContext _context;
        public DestinatarioService(AppDbContext context)
        {
            _context = context;
        }
        public async Task<Destinatario> DadosDestinatarioAsync(string arquivo)
        {
            var isDestinatario = false;

            using (XmlReader meuXml = XmlReader.Create(arquivo))
            {
                while (meuXml.Read())
                {
                    if (meuXml.NodeType == XmlNodeType.Element && meuXml.Name == "infNFe")
                        _id = meuXml.GetAttribute("Id");

                    if (meuXml.NodeType == XmlNodeType.Element && meuXml.Name == "dest")
                        isDestinatario = true;
                    //Dados do Destinatario
                    else if (meuXml.NodeType == XmlNodeType.Element && meuXml.Name == "det")
                        break;

                    if (isDestinatario)
                    {
                        if (meuXml.NodeType == XmlNodeType.Element && meuXml.Name == "CNPJ")
                            d_cNPJ = meuXml.ReadElementString();
                        if (meuXml.NodeType == XmlNodeType.Element && meuXml.Name == "xNome")
                            d_xNome = meuXml.ReadElementString();
                        if (meuXml.NodeType == XmlNodeType.Element && meuXml.Name == "xLgr")
                            d_xLgr = meuXml.ReadElementString();
                        if (meuXml.NodeType == XmlNodeType.Element && meuXml.Name == "nro")
                            d_nro = meuXml.ReadElementString();
                        if (meuXml.NodeType == XmlNodeType.Element && meuXml.Name == "xBairro")
                            d_xBairro = meuXml.ReadElementString();
                        if (meuXml.NodeType == XmlNodeType.Element && meuXml.Name == "cMun")
                            d_cMun = int.Parse(meuXml.ReadElementString());
                        if (meuXml.NodeType == XmlNodeType.Element && meuXml.Name == "xMun")
                            d_xMun = meuXml.ReadElementString();
                        if (meuXml.NodeType == XmlNodeType.Element && meuXml.Name == "UF")
                            d_uf = meuXml.ReadElementString();
                        if (meuXml.NodeType == XmlNodeType.Element && meuXml.Name == "CEP")
                            d_cep = int.Parse(meuXml.ReadElementString());
                        if (meuXml.NodeType == XmlNodeType.Element && meuXml.Name == "cPais")
                            d_cPais = int.Parse(meuXml.ReadElementString());
                        if (meuXml.NodeType == XmlNodeType.Element && meuXml.Name == "xPais")
                            d_xPais = meuXml.ReadElementString();
                        if (meuXml.NodeType == XmlNodeType.Element && meuXml.Name == "indIEDest")
                            d_indIEDest = int.Parse(meuXml.ReadElementString());
                        if (meuXml.NodeType == XmlNodeType.Element && meuXml.Name == "IE")
                            d_ie = meuXml.ReadElementString();

                    }
                }
                //Salvar no bamco de dados
                desti = new Destinatario(d_cNPJ, d_xNome, d_xLgr, d_nro, d_xBairro, d_cMun, d_xMun, d_uf, d_cep, d_cPais, d_xPais, d_indIEDest, d_ie);
                return desti;
            }
        }
        public Destinatario RetonarDesti(Destinatario desti)
        {
            return desti;
        }
    }
}
