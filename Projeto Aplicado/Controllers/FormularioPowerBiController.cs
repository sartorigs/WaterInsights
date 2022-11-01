using Microsoft.AspNetCore.Mvc;
using Projeto_Aplicado.Entidades;
using Projeto_Aplicado.Models;
using Projeto_Aplicado.Repositorios.Interfaces;

namespace Projeto_Aplicado.Controllers
{
    public class FormularioPowerBiController : Controller
    {
        private readonly IPowerBiRepository _powerBiRepository;
        public FormularioPowerBiController(IPowerBiRepository powerBiRepository)
        {
            _powerBiRepository = powerBiRepository;
        }

        public IActionResult FormularioPowerBi()
        {
            var model = new PowerBiModel();
            return View(model);
        }
        public IActionResult Value1(PowerBiModel model)
        {
            if (ModelState.IsValid)
            {
                var powerBi = new PowerBi()
                {
                    UsuarioId = model.UsuarioId,
                    value1 = model.value1,
                };
                _powerBiRepository.Salvar(powerBi);
                return RedirectToAction("Value2", "FormularioPowerBi");
            }
            return View(model);
        }
    }
}
