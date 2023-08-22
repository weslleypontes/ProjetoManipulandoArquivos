using Microsoft.AspNetCore.Mvc;

namespace LeituraArquivos.Controllers
{
    public class UploadController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        /*public async Task<IActionResult> LerAquivo(List<IFormFile> arquivo)
        {

        }*/
    }
}
