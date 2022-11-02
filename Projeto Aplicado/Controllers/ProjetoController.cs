using Microsoft.AspNetCore.Mvc;
using Projeto_Aplicado.Entidades;
using Projeto_Aplicado.Models;
using Projeto_Aplicado.Repositorios.Interfaces;
using System;
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
                foreach (var file in model.Imagem)
                {
                    using (var ms = new MemoryStream())
                    {
                        file.CopyTo(ms);
                        var filebytes = ms.ToArray();
                        projeto.Imagem = Convert.ToBase64String(filebytes);
                        projeto.Imagem = "data:image/png;base64," + projeto.Imagem;
                    }
                }
                _projetoRepository.Salvar(projeto);
                return RedirectToAction("Index");
            }
            return View(model);
        }
    }
}

