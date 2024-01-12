using Microsoft.AspNetCore.Mvc;
using LeituraArquivos.Services;
using Microsoft.EntityFrameworkCore;
using DanfePDF.Esquemas.NFe;
using DanfePDF.Modelo;
using LeituraArquivos.Data;
using LeituraArquivos.Models;
using LeituraArquivos.Models.ViewModels;
using DanfePDF;
using System.Diagnostics;
namespace LeituraArquivos.Controllers
{
    public class UploadController : Controller
    {
        private readonly UploadService _uploadService;
        private readonly AppDbContext _context;
        const string caminho = "C:\\projetos\\LeituraArquivos\\LeituraArquivos\\wwwroot\\Arquivos\\Arquivos_Usuario\\Recebidos\\";
        const string path = "C:\\projetos\\LeituraArquivos\\LeituraArquivos\\wwwroot\\Arquivos\\Arquivos_Usuario\\Danfe\\";
        public UploadController(UploadService uploadService, AppDbContext context)
        {
            _uploadService = uploadService;
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> Listar()
        {
            var list = await _uploadService.FindAllAsync();
            return View(list);
        }

        [HttpPost]
        public async Task<IActionResult> EnviarAquivo(List<IFormFile> arquivos)
        {
            if (arquivos == null || arquivos.Count == 0)
            {
                TempData["Erro"] = "Erro: nenhum arquivo(s) selecionado(s).";
                return RedirectToAction(nameof(Index));
            }

            await _uploadService.LerAquivoAsync(arquivos);

            TempData["Sucesso"] = "Sucesso: arquivo(s) enviado(s) com sucesso.";
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Completa(string? id)
        {
            var viewModels = new NotaFiscalViewModels();
             viewModels.NotaFiscal = _context.NFes
            .Include(e => e.Emitentes)
            .ThenInclude(ps => ps.ProdServs)
            .Include(d => d.Destinatarios)
            .Single(e => e.Id == id);
            return View(viewModels);
        }

        public IActionResult DanFe(string id)
        {
            if (id != null)
            {
                var modelo = DanfeViewModelCreator.CriarDeArquivoXml(caminho + id + ".xml");
                using (var danfe = new Danfe(modelo))
                {
                    danfe.Gerar();
                    danfe.Salvar(path + id + ".pdf");
                }
                TempData["Sucesso"] = $"DANFE gerado com sucesso";
                return RedirectToAction("Listar", "Upload"); 
            }
            else
            {
                TempData["Erro"] = $"Erro ao gerar DANFE";
                return RedirectToAction("Listar", "Upload");
            }
        }
    }
}
