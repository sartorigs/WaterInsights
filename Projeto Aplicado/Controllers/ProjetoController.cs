using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Projeto_Aplicado.Entidades;
using Projeto_Aplicado.Models;
using Projeto_Aplicado.Repositorios.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;

namespace Projeto_Aplicado.Controllers
{
    public class ProjetoController : Controller
    {
        private readonly IProjetoRepository _projetoRepository;
        public ProjetoController(IProjetoRepository projetoRepository)
        {
            _projetoRepository = projetoRepository;
        }
        public IActionResult Index()
        {
            try
            {
                var sessionUser = JsonConvert.DeserializeObject<Usuario>(HttpContext?.Session.GetString("SessionUser"));
            }catch(Exception e)
            {
                return RedirectToAction("Login", "Login");
            }
            
            
                
            ViewBag.Projetos = _projetoRepository.BuscarTodosProjetos();
            return View();
        }

        public IActionResult Novo()
        {
            var model = new ProjetoModel();
            return View(model);
        }

        [HttpPost]
        public IActionResult Novo(ProjetoModel model)
        {
            if (ModelState.IsValid)
            {
                var projeto = new Projeto();
                projeto.Id = model.Id;
                projeto.Descricao = model.Descricao;
                projeto.Itens = model.Itens;
                projeto.Titulo = model.Titulo;
                projeto.Imagem = conversorImagem(model.Imagem);

                _projetoRepository.Salvar(projeto);
                return RedirectToAction("Index");
            }
            return View(model);
        }


        public string conversorImagem(List<IFormFile> img)
        {
            string retorno;
            foreach (var file in img)
            {
                using (var ms = new MemoryStream())
                {
                    file.CopyTo(ms);
                    var filebytes = ms.ToArray();
                    retorno = Convert.ToBase64String(filebytes);
                    retorno = "data:image/png;base64," + retorno;
                }
                return retorno;
            }
            return null;
        }

    }
}

