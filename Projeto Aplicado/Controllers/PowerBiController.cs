using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Projeto_Aplicado.Entidades;
using Projeto_Aplicado.Models;
using System;

namespace Projeto_Aplicado.Controllers
{
    public class PowerBiController : Controller
    {
        public IActionResult PowerBi()
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
    }
}
