using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Projeto_Aplicado.Entidades;
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
        public IActionResult Acessar(UsuarioModel model)
        {
            if (ModelState.IsValid)
            {
                var user = new Usuario();
                user.Email = model.Email;
                user.Senha = model.Senha;
                if (_acessoRepository.Acessa(user))
                {
                    var usuario = new Usuario() { Id = user.Id};
                    HttpContext.Session.SetString("SessionUser", JsonConvert.SerializeObject(usuario));
;                    return RedirectToAction("Index", "Home");
                }
                    
            }
            ViewBag.Message1 = "Acesso Negado!!!";
            return View("Login", model);
        }
    }
}
