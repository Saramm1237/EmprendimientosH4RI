using Microsoft.AspNetCore.Mvc;
using Emprendimientos4RI.Models;

namespace Emprendimientos4RI.Controllers
{
    public class IntegranteController : Controller
    {
        private readonly IdeasNegocioManager _ideasNegocioManager;

        public IntegranteController()
        {
            _ideasNegocioManager = new IdeasNegocioManager();
        }

        public IActionResult Index()
        {
            return View("~/Views/Home/Integrante.cshtml");
        }

        [HttpPost]
        public IActionResult AgregarEliminarIntegrante(string CodigoIdea, string Identificacion, string Nombre, string Apellidos, string Rol, string Email, string Accion)
        {
            IdeaNegocio ideaNegocio = _ideasNegocioManager.IdeasNegocio.Find(idea => idea.Codigo.ToString() == CodigoIdea);

            if (ideaNegocio == null)
            {
                return NotFound("Idea de negocio no encontrada.");
            }

            IntegranteEquipo integrante = new IntegranteEquipo
            {
                Identificacion = Identificacion,
                Nombre = Nombre,
                Apellidos = Apellidos,
                Rol = Rol,
                Email = Email
            };

            if (Accion == "agregar")
            {
                ideaNegocio.AgregarIntegrante(integrante);
            }
            else if (Accion == "eliminar")
            {
                ideaNegocio.EliminarIntegrante(integrante);
            }
            else
            {
                return BadRequest("Acción no válida.");
            }
            return RedirectToAction("Detalle", new { codigoIdea = ideaNegocio.Codigo });
        }
    }
}