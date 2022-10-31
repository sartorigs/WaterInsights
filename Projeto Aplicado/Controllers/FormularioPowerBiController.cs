using Microsoft.AspNetCore.Mvc;
using Projeto_Aplicado.Models;

namespace Projeto_Aplicado.Controllers
{
    public class FormularioPowerBiController : Controller
    {
        public IActionResult FormularioPowerBi()
        {
            var model = new PowerBiModel();
            return View(model);
        }
    }
}
