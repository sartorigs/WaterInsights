using Projeto_Aplicado.Entidades;
using Projeto_Aplicado.Models;
using Microsoft.AspNetCore.Mvc;
using Projeto_Aplicado.Repositorios.Interfaces;

namespace Projeto_Aplicado.Controllers
{
    public class CadastroController : Controller
    {
        private readonly IProjetoRepository _projetoRepository;
        public CadastroController(IProjetoRepository projetoRepository)
        {
            _projetoRepository = projetoRepository;
        }
        public IActionResult Cadastro()
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
                        Bairro = model.Bairro,
                        Cidade = model.Cidade,
                        Estado = model.Estado
                    }
                };
                _projetoRepository.Cadastrar(usuario);
                return RedirectToAction("Index", "Home");
            }
            return View(model);
        }
    }
}
