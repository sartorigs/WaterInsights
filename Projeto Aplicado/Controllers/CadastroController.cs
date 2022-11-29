using Projeto_Aplicado.Entidades;
using Projeto_Aplicado.Models;
using Microsoft.AspNetCore.Mvc;
using Projeto_Aplicado.Repositorios.Interfaces;
using System.Security.Cryptography;
using System.Text;
using System;

namespace Projeto_Aplicado.Controllers
{
    public class CadastroController : Controller
    {
        private readonly IAcessoRepository _acessoRepository;
        public CadastroController(IAcessoRepository acessoRepository)
        {
            _acessoRepository = acessoRepository;
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
                    Sobrenome = model.Sobrenome,
                    Email = model.Email,
                    Senha = HashPassord(model.Senha),
                    DataNascimento = model.DataNascimento,
                    Regiao = new Regiao()
                    {
                        Id = model.id,
                        Bairro = model.Bairro,
                        Cidade = model.Cidade,
                        Estado = model.Estado
                    }
                };
                _acessoRepository.Cadastrar(usuario);
                return RedirectToAction("Index", "Home");
            }
            return View(model);
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
