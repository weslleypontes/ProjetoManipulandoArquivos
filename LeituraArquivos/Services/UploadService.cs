using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Xml;
using LeituraArquivos.Models;
using LeituraArquivos.Data;
using System.Security.Cryptography;

namespace LeituraArquivos.Services
{
    public class UploadService
    {

        //Dodas da nota fiscal
        string? _versao = "";
        string? _id = "";
        int _mod = 0;
        int _cuf = 0;
        int _cnf = 0;
        string _natOp = "";
        int _serie = 0;
        int _nnf = 0;
        DateTime _dhEmi = DateTime.Now;
        DateTime _dhSaiEnt = DateTime.Now;
        int _tpNF = 0;
        int _idDest = 0;
        int _cMunFG = 0;
        int _tpImp = 0;
        int _tpEmis = 0;
        int _cDV = 0;
        int _tpAmb = 0;
        int _finNFe = 0;
        int _indFinal = 0;
        int _indPres = 0;
        //Dados do Emitente
        string? e_cNPJ = "";
        string? e_xNome = "";
        string? e_xFant = "";
        string? e_nFeId = "";
        string? e_xLgr = "";
        string? e_nro = "";
        string? e_xCpl = "";
        string? e_xBairro = "";
        int e_cMun = 0;
        string? e_xMun = "";
        string? e_uf = "";
        int e_cep = 0;
        int e_cPais = 0;
        string? e_xPais = "";
        string? e_fone = "";
        string? e_ie = "";
        int e_crt = 0;
        

        private readonly AppDbContext _context;
        private readonly DestinatarioService _destinatarioService;
        private readonly ProdServService _prodServService;
        private readonly IWebHostEnvironment _appEnvironment;
        public UploadService(AppDbContext context, IWebHostEnvironment env, DestinatarioService destinatarioService, ProdServService prodServService)
        {
            _context = context;
            _appEnvironment = env;
            _destinatarioService = destinatarioService;
            _prodServService = prodServService;
        }
        public async Task<List<NFe>> FindAllAsync()
        {
            return await _context.NFes.ToListAsync();
        }
        public async Task LerAquivoAsync(List<IFormFile> arquivos)
        {
            var isEmitente = false;
            foreach (var arquivo in arquivos)
            {

                // < define a pasta onde vamos salvar os arquivos >
                //string path = "Arquivos";
                string pasta = "Arquivos_Usuario";
                // Define um nome para o arquivo enviado incluindo o sufixo obtido de milesegundos
                string nomeArquivo = "NFe_" + DateTime.Now.Millisecond.ToString();
                string arq = nomeArquivo;

                //verifica qual o tipo de arquivo : jpg, gif, png, pdf ou tmp
                if (arquivo.FileName.Contains(".xml"))
                {
                    nomeArquivo += ".xml";
                }
                else
                {
                    nomeArquivo += ".tmp";
                }


                //< obtém o caminho físico da pasta wwwroot >
                string caminho_WebRoot = _appEnvironment.WebRootPath;

                // monta o caminho onde vamos salvar o arquivo :  ~\wwwroot\Arquivos\Arquivos_Usuario\Recebidos
                string caminhoDestinoArquivo = caminho_WebRoot + "\\Arquivos\\" + pasta + "\\";
                // incluir a pasta Recebidos e o nome do arquiov enviado : ~\wwwroot\Arquivos\Arquivos_Usuario\Recebidos\
                string caminhoDestinoArquivoOriginal = caminhoDestinoArquivo + "\\Recebidos\\" + nomeArquivo;

                //copia o arquivo para o local de destino original
                using (var stream = new FileStream(caminhoDestinoArquivoOriginal, FileMode.Create))
                {
                    await arquivo.CopyToAsync(stream);
                }
                
                using (XmlReader meuXml = XmlReader.Create(caminhoDestinoArquivoOriginal))
                {
                    while (meuXml.Read())
                    {
                        //Dados da nota fiscal
                        if (meuXml.NodeType == XmlNodeType.Element && meuXml.Name == "infNFe")
                            _versao = meuXml.GetAttribute("versao");

                        if (meuXml.NodeType == XmlNodeType.Element && meuXml.Name == "infNFe")
                            _id = meuXml.GetAttribute("Id");

                        if (meuXml.NodeType == XmlNodeType.Element && meuXml.Name == "cUF")
                            _cuf = int.Parse(meuXml.ReadElementString());

                        if (meuXml.NodeType == XmlNodeType.Element && meuXml.Name == "cNF")
                            _cnf = int.Parse(meuXml.ReadElementString());

                        if (meuXml.NodeType == XmlNodeType.Element && meuXml.Name == "natOp")
                            _natOp = meuXml.ReadElementString();

                        if (meuXml.NodeType == XmlNodeType.Element && meuXml.Name == "mod")
                            _mod = int.Parse(meuXml.ReadElementString());

                        if (meuXml.NodeType == XmlNodeType.Element && meuXml.Name == "serie")
                            _serie = int.Parse(meuXml.ReadElementString());

                        if (meuXml.NodeType == XmlNodeType.Element && meuXml.Name == "nNF")
                            _nnf = int.Parse(meuXml.ReadElementString());

                        if (meuXml.NodeType == XmlNodeType.Element && meuXml.Name == "dhEmi")
                            _dhEmi = DateTime.Parse(meuXml.ReadElementString());

                        if (meuXml.NodeType == XmlNodeType.Element && meuXml.Name == "dhSaiEnt")
                            _dhSaiEnt = DateTime.Parse(meuXml.ReadElementString());

                        if (meuXml.NodeType == XmlNodeType.Element && meuXml.Name == "tpNF")
                            _tpNF = int.Parse(meuXml.ReadElementString());

                        if (meuXml.NodeType == XmlNodeType.Element && meuXml.Name == "idDest")
                            _idDest = int.Parse(meuXml.ReadElementString());

                        if (meuXml.NodeType == XmlNodeType.Element && meuXml.Name == "cMunFG")
                            _cMunFG = int.Parse(meuXml.ReadElementString());

                        if (meuXml.NodeType == XmlNodeType.Element && meuXml.Name == "tpImp")
                            _tpImp = int.Parse(meuXml.ReadElementString());

                        if (meuXml.NodeType == XmlNodeType.Element && meuXml.Name == "tpEmis")
                            _tpEmis = int.Parse(meuXml.ReadElementString());

                        if (meuXml.NodeType == XmlNodeType.Element && meuXml.Name == "cDV")
                            _cDV = int.Parse(meuXml.ReadElementString());

                        if (meuXml.NodeType == XmlNodeType.Element && meuXml.Name == "tpAmb")
                            _tpAmb = int.Parse(meuXml.ReadElementString());

                        if (meuXml.NodeType == XmlNodeType.Element && meuXml.Name == "finNFe")
                            _finNFe = int.Parse(meuXml.ReadElementString());

                        if (meuXml.NodeType == XmlNodeType.Element && meuXml.Name == "indFinal")
                            _indFinal = int.Parse(meuXml.ReadElementString());

                        if (meuXml.NodeType == XmlNodeType.Element && meuXml.Name == "indPres")
                            _indPres = int.Parse(meuXml.ReadElementString());

                        //Dados do Emitente
                        if (meuXml.NodeType == XmlNodeType.Element && meuXml.Name == "emit")
                            isEmitente = true;
                        else if (meuXml.NodeType == XmlNodeType.Element && meuXml.Name == "dest")
                        {
                            isEmitente = false;
                        }
                        if (isEmitente)
                        {
                            if (meuXml.NodeType == XmlNodeType.Element && meuXml.Name == "CNPJ")
                                e_cNPJ = meuXml.ReadElementString();
                            if (meuXml.NodeType == XmlNodeType.Element && meuXml.Name == "xNome")
                                e_xNome = meuXml.ReadElementString();
                            if (meuXml.NodeType == XmlNodeType.Element && meuXml.Name == "xFant")
                                e_xFant = meuXml.ReadElementString();
                            if (meuXml.NodeType == XmlNodeType.Element && meuXml.Name == "xLgr")
                                e_xLgr = meuXml.ReadElementString();
                            if (meuXml.NodeType == XmlNodeType.Element && meuXml.Name == "nro")
                                e_nro = meuXml.ReadElementString();
                            if (meuXml.NodeType == XmlNodeType.Element && meuXml.Name == "xBairro")
                                e_xBairro = meuXml.ReadElementString();
                            if (meuXml.NodeType == XmlNodeType.Element && meuXml.Name == "cMun")
                                e_cMun = int.Parse(meuXml.ReadElementString());
                            if (meuXml.NodeType == XmlNodeType.Element && meuXml.Name == "xMun")
                                e_xMun = meuXml.ReadElementString();
                            if (meuXml.NodeType == XmlNodeType.Element && meuXml.Name == "UF")
                                e_uf = meuXml.ReadElementString();
                            if (meuXml.NodeType == XmlNodeType.Element && meuXml.Name == "CEP")
                                e_cep = int.Parse(meuXml.ReadElementString());
                            if (meuXml.NodeType == XmlNodeType.Element && meuXml.Name == "cPais")
                                e_cPais = int.Parse(meuXml.ReadElementString());
                            if (meuXml.NodeType == XmlNodeType.Element && meuXml.Name == "xPais")
                                e_xPais = meuXml.ReadElementString();
                            if (meuXml.NodeType == XmlNodeType.Element && meuXml.Name == "fone")
                                e_fone = meuXml.ReadElementString();
                            if (meuXml.NodeType == XmlNodeType.Element && meuXml.Name == "IE")
                                e_ie = meuXml.ReadElementString();
                            if (meuXml.NodeType == XmlNodeType.Element && meuXml.Name == "CRT")
                                e_crt = int.Parse(meuXml.ReadElementString());
                        }

                    }
                    //Salvar no bamco de dados
                    
                    Emitente emit = new Emitente(e_cNPJ, e_xNome, e_xFant, e_xLgr, e_nro, e_xBairro, e_cMun, e_xMun, e_uf, e_cep, e_cPais, e_xPais, e_fone, e_ie, e_crt);
                    
                    var desti = await _destinatarioService.DadosDestinatarioAsync(caminhoDestinoArquivoOriginal);
                    NFe nfe = new NFe(_versao, _id, _cuf, _cnf, _natOp, _mod, _serie, _nnf, _dhEmi, _dhSaiEnt, _tpNF, _idDest, _cMunFG, _tpImp, _tpEmis, _cDV, _tpAmb, _finNFe, _indFinal, _indPres, arq, emit, desti);

                    await _context.Emitentes.AddAsync(emit);
                    foreach (var ps in await _prodServService.DadosItensAsync(caminhoDestinoArquivoOriginal, emit))
                    {
                       await _context.ProdServs.AddAsync(ps);
                    }
                    await _context.Destinatarios.AddAsync(desti);
                    await _context.NFes.AddAsync(nfe);
                    await _context.SaveChangesAsync();
                }
            }
        }

    }
}

