using Microsoft.AspNetCore.Mvc;
using Emprendimientos4RI.Models;
using System.Collections.Generic;

namespace Emprendimientos4RI.Controllers
{
    public class IdeaNegocioController : Controller
    {
        private readonly IdeasNegocioManager _ideasNegocioManager;

        public IdeaNegocioController()
        {
            _ideasNegocioManager = new IdeasNegocioManager();
        }

        public IActionResult Index()
        {
            return View(_ideasNegocioManager.IdeasNegocio);
        }
        public IActionResult Menu()
        {
            return View("~/Views/Home/Index.cshtml");
        }

        public IActionResult IdeaMasDepartamentos()
        {
            var idea = _ideasNegocioManager.ObtenerIdeaMasDepartamentos();
            return View("~/Views/Home/Index.cshtml", idea);
        }

        public IActionResult IdeaMayorIngresos()
        {
            var idea = _ideasNegocioManager.ObtenerIdeaMayorIngresos();
            return View("~/Views/Home/Index.cshtml", idea);
        }

        public IActionResult Top3Rentables()
        {
            var ideas = _ideasNegocioManager.ObtenerTop3Rentables();
            return View("~/Views/Home/Index.cshtml", ideas);
        }

        public IActionResult IdeasMasTresDepartamentos()
        {
            var ideas = _ideasNegocioManager.ObtenerIdeasMasTresDepartamentos();
            return View("~/Views/Home/Index.cshtml", ideas);
        }

        public IActionResult SumaTotalIngresos()
        {
            var sumaTotalIngresos = _ideasNegocioManager.ObtenerSumaTotalIngresos();
            return View("~/Views/Home/Index.cshtml", sumaTotalIngresos);
        }

        public IActionResult SumaTotalInversion()
        {
            var sumaTotalInversion = _ideasNegocioManager.ObtenerSumaTotalInversion();
            return View("~/Views/Home/Index.cshtml", sumaTotalInversion);
        }

        public IActionResult IdeaConMasHerramientas4RI()
        {
            var ideaConMasHerramientas = _ideasNegocioManager.ObtenerIdeaConMasHerramientas4RI();
            return View("~/Views/Home/Index.cshtml", ideaConMasHerramientas);
        }

        public IActionResult CantidadIdeasConIA()
        {
            var cantidadIdeasConIA = _ideasNegocioManager.ContarIdeasConIA();
            return View("~/Views/Home/Index.cshtml", cantidadIdeasConIA);
        }

        public IActionResult IdeasConDesarrolloSostenible()
        {
            var ideas = _ideasNegocioManager.ObtenerIdeasConDesarrolloSostenible();
            return View("~/Views/Home/Index.cshtml", ideas);
        }

        [HttpGet]
        public IActionResult Agregar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Agregar(IdeaNegocio ideaNegocio)
        {
            _ideasNegocioManager.AgregarIdeaNegocio(ideaNegocio);
            return View("~/Views/Home/IdeaNegocio.cshtml");
        }
    }
}
