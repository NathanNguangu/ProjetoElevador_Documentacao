using Microsoft.AspNetCore.Mvc;

namespace ProjetoElevador_Documentacao.Controllers
{
    public class ElevadorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
