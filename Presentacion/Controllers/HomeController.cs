using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Presentacion.Models;
using Negocio;
using Entidad;
using Datos;

namespace Presentacion.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly NegocioPoliza _negocioPoliza;


        //Evaluación
        public HomeController(ILogger<HomeController> logger,  ContextoDatos _context)
        {
            _logger = logger;
            _negocioPoliza = new NegocioPoliza();
            _negocioPoliza._context = _context;
        }

        public IActionResult Index()
        {
            return View(_negocioPoliza.ListarPolizas());
        }

        public IActionResult CalcularPension()
        {
            var FechaCalcular = new DateTime(2020, 12, 01);
            _negocioPoliza.BatchCalculoPension(FechaCalcular);
            return RedirectToAction("Index");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
