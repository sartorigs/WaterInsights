﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Projeto_Aplicado.Entidades;
using Projeto_Aplicado.Models;
using Projeto_Aplicado.Repositorios.Interfaces;
using System;

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
            try
            {
                var sessionUser = JsonConvert.DeserializeObject<Usuario>(HttpContext?.Session.GetString("SessionUser"));
            }
            catch (Exception e)
            {
                return RedirectToAction("Login", "Login");
            }
            var model = new PowerBiModel();
            return View(model);
        }
        public IActionResult Value(PowerBiModel model)
        {
            if (ModelState.IsValid)
            {
                var powerBi = new PowerBi()
                {
                    UsuarioId = model.UsuarioId,
                    value1 = model.value1,
                    value2 = model.value2,
                    value3 = model.value3,
                    value4 = model.value4,
                    value5 = model.value5,
                };
                _powerBiRepository.Salvar(powerBi);
                return RedirectToAction("PowerBi", "PowerBi");
            }
            return View(model);
        }
    }
}
