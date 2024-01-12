using System.Xml;
using System.Collections.Generic;
using LeituraArquivos.Data;
using LeituraArquivos.Models;
using System.Globalization;
namespace LeituraArquivos.Services
{
    public class ProdServService
    {
        //Dados do produto e serviço
        int nItem = 0;
        string? cProd = "";
        string? cEAN = "";
        string? xProd = "";
        int nCM = 0;
        int cFOP = 0;
        int cEST = 0;
        string? uCom = "";
        decimal qCom = 0;
        string? qComT = "";
        decimal vUnComm = 0;
        string? vUnCommT = "";
        decimal vProd = 0;
        string? vProdT = "";
        string? cEANTrib = "";
        string? uTrib = "";
        decimal qTrib = 0;
        string? qTribT = "";
        decimal vUnTrib = 0;
        string? vUnTribT = "";
        int indTot = 0;
        List<ProdServ> ListPS = new List<ProdServ>();

        private readonly AppDbContext _context;
        public ProdServService(AppDbContext context)
        {
            _context = context;
        }
        public async Task<ICollection<ProdServ>> DadosItensAsync(string arquivo, Emitente emit)
        {
            var fimItens = false;

            using (XmlReader meuXml = XmlReader.Create(arquivo))
            {
                while (meuXml.Read())
                {

                    if (meuXml.NodeType == XmlNodeType.Element && meuXml.Name == "det")
                    {
                        nItem = int.Parse(meuXml.GetAttribute("nItem"));

                        cProd = "";
                        cEAN = "";
                        xProd = "";
                        nCM = 0;
                        cFOP = 0;
                        cEST = 0;
                        uCom = "";
                        qCom = 0;
                        qComT = "";
                        vUnComm = 0;
                        vUnCommT = "";
                        vProd = 0;
                        vProdT = "";
                        cEANTrib = "";
                        uTrib = "";
                        qTrib = 0;
                        qTribT = "";
                        vUnTrib = 0;
                        vUnTribT = "";
                        indTot = 0;
                    }
                    //Dados do Destinatario
                    else if (meuXml.NodeType == XmlNodeType.Element && meuXml.Name == "total")
                    {
                        fimItens = true;
                    }

                    if (!fimItens)
                    {
                        if (meuXml.NodeType == XmlNodeType.Element && meuXml.Name == "cProd")
                            cProd = meuXml.ReadElementString();
                        if (meuXml.NodeType == XmlNodeType.Element && meuXml.Name == "cEAN")
                            cEAN = meuXml.ReadElementString();
                        if (meuXml.NodeType == XmlNodeType.Element && meuXml.Name == "xProd")
                            xProd = meuXml.ReadElementString();
                        if (meuXml.NodeType == XmlNodeType.Element && meuXml.Name == "NCM")
                            nCM = int.Parse(meuXml.ReadElementString());
                        if (meuXml.NodeType == XmlNodeType.Element && meuXml.Name == "CFOP")
                            cFOP = int.Parse(meuXml.ReadElementString());
                        if (meuXml.NodeType == XmlNodeType.Element && meuXml.Name == "uCom")
                            uCom = meuXml.ReadElementString();
                        if (meuXml.NodeType == XmlNodeType.Element && meuXml.Name == "qCom")
                        {
                            qComT = meuXml.ReadElementString().Replace(".", ",");
                            qCom = Convert.ToDecimal(qComT);
                            qCom.ToString("N3", new CultureInfo("en-US"));
                        }
                        if (meuXml.NodeType == XmlNodeType.Element && meuXml.Name == "vUnCom")
                        {
                            vUnCommT = meuXml.ReadElementString().Replace(".", ",");
                            vUnComm = Convert.ToDecimal(vUnCommT);
                            vUnComm.ToString("N3", new CultureInfo("en-US"));
                        }
                        if (meuXml.NodeType == XmlNodeType.Element && meuXml.Name == "vProd")
                        {
                            vProdT = meuXml.ReadElementString().Replace(".", ",");
                            vProd = Convert.ToDecimal(vProdT);
                            vProd.ToString("N3", new CultureInfo("en-US"));
                        }
                        if (meuXml.NodeType == XmlNodeType.Element && meuXml.Name == "cEANTrib")
                            cEANTrib = meuXml.ReadElementString();
                        if (meuXml.NodeType == XmlNodeType.Element && meuXml.Name == "uTrib")
                            uTrib = meuXml.ReadElementString();
                        if (meuXml.NodeType == XmlNodeType.Element && meuXml.Name == "qTrib")
                        {
                            qTribT = meuXml.ReadElementString().Replace(".", ",");
                            qTrib = Convert.ToDecimal(qTribT);
                            qTrib.ToString("N3", new CultureInfo("en-US"));
                        }
                        if (meuXml.NodeType == XmlNodeType.Element && meuXml.Name == "vUnTrib")
                        {
                            vUnTribT = meuXml.ReadElementString().Replace(".", ",");
                            vUnTrib = Convert.ToDecimal(vUnTribT);
                            vUnTrib.ToString("N3", new CultureInfo("en-US"));
                        }
                        if (meuXml.NodeType == XmlNodeType.Element && meuXml.Name == "indTot") 
                        {
                            indTot = int.Parse(meuXml.ReadElementString());
                            //Salvar no bamco de dados
                            ProdServ ps = new ProdServ(nItem, cProd, cEAN, xProd, nCM, cFOP, cEST, uCom, qCom, vUnComm, vProd, cEANTrib, uTrib, qTrib, vUnTrib, indTot, emit);
                            ListPS.Add(ps);
                        }
                    }
                }
                return ListPS;
            }
        }
    }
}
