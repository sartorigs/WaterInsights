using Projeto_Aplicado.Entidades;
using Projeto_Aplicado.Models;
using Microsoft.AspNetCore.Mvc;

namespace Projeto_Aplicado.Controllers
{
    public class CadastroController : Controller
    {
        public IActionResult Novo()
        {
            var model = new UsuarioModel();
            return View(model);
        }
        [HttpPost]
        public IActionResult Novo(UsuarioModel model)
        {
            if (ModelState.IsValid)
            {
                var usuario = new Usuario()
                {
                    Id = model.id,
                    Nome = model.Nome,
                    Regiao = new Regiao()
                    {
                        Id = model.id,
                        Bairro = model.,
                        Cidade = model.Cidade,
                        Estado = model.Estado
                    }
                };
                _colegioRepositorio.Salvar(colegio);
                return RedirectToAction("Index", "Colegio");
            }
            return View(model);
        }
    }
}
