using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using registro.Models;

namespace registro.Controllers
{
    public class RegistroController : Controller
    {
        private readonly ILogger<RegistroController> _logger;

        public RegistroController(ILogger<RegistroController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Calcular(Registro objRegistro)
        {
            double mat, len, his, igv, res1, res2 = 0.0;

            mat = (objRegistro.Matematica == true) ? 300.0 : 0.0;
            len = (objRegistro.Lenguaje == true) ? 300.0 : 0.0;
            his = (objRegistro.Historia == true) ? 300.0 : 0.0;

            res1 = mat + len + his;
            igv = Math.Round((res1 * 0.18), 2);
            res2 = res1 + igv;

            ViewData ["Message-1"] = "TOTAL DE CURSOS: " + res1;
            ViewData ["Message-2"] = "IGV: " + igv;
            ViewData ["Message-3"] = "TOTAL A PAGAR: " + res2;
            return View("Index");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}