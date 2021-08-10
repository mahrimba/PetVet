using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PetVet.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace SiteVeterinaria.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Servicos()
        {
            return View();
        }

        public IActionResult Agendamento()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Agendamento(Agendamento pet)
        {
            ViewBag.nome = pet.Nome;
            ViewBag.telefone = pet.Telefone;
            ViewBag.data = pet.Data;
            ViewBag.animal = pet.Animal;
            ViewBag.necessidade = pet.Necessidade;
            return View("Detalhe");
        }

        public IActionResult Detalhe()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
