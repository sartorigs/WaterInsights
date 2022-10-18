using Microsoft.AspNetCore.Mvc;
using Projeto_Aplicado.Models;
using Projeto_Aplicado.Repositorios.Interfaces;

namespace Projeto_Aplicado.Controllers
{
    public class LoginController : Controller
    {
        private readonly IAcessoRepository _acessoRepository;
        public LoginController(IAcessoRepository acessoRepository)
        {
            _acessoRepository = acessoRepository;
        }
        public IActionResult Login()
        {
            var model = new UsuarioModel();
            return View(model);
        }
    }
}
