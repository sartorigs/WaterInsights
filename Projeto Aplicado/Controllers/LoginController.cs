using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Projeto_Aplicado.Entidades;
using Projeto_Aplicado.Models;
using Projeto_Aplicado.Repositorios.Interfaces;
using System;
using System.Security.Cryptography;
using System.Text;

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
                user.Senha = HashPassord(model.Senha);
                if (_acessoRepository.Acessa(user))
                {
                    var usuario = _acessoRepository.RetornaUser(user);
                    HttpContext.Session.SetString("SessionUser", JsonConvert.SerializeObject(usuario));
;                    return RedirectToAction("Index", "Home");
                }
                    
            }
            ViewBag.Message1 = "Acesso Negado!!!";
            return View("Login", model);
        }

        private string HashPassord(string password)
        {
            var sha = SHA256.Create();
            var byteArray = Encoding.Default.GetBytes(password);
            var hashedPassword = sha.ComputeHash(byteArray);
            return Convert.ToBase64String(hashedPassword);

        }
    }
}
