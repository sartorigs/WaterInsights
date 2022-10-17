using Microsoft.AspNetCore.Mvc;
using Projeto_Aplicado.Models;
using Projeto_Aplicado.Repositorios.Interfaces;

namespace Projeto_Aplicado.Controllers
{
    public class LoginController : Controller
    {
        private readonly IProjetoRepository _projetoRepository;
        public LoginController(IProjetoRepository projetoRepository)
        {
            _projetoRepository = projetoRepository;
        }
        public IActionResult Login()
        {
            var model = new UsuarioModel();
            return View(model);
        }
    }
}
