using Emprendimientos4RI.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Emprendimientos4RI.Models
{
    public class IdeasNegocioManager
    {
        public List<IdeaNegocio> IdeasNegocio { get; set; }

        public IdeasNegocioManager()
        {
            IdeasNegocio = new List<IdeaNegocio>();
        }

        public void AgregarIdeaNegocio(IdeaNegocio idea)
        {
            IdeasNegocio.Add(idea);
        }

        public IdeaNegocio ObtenerIdeaMasDepartamentos()
        {
            return IdeasNegocio.OrderByDescending(idea => idea.Departamentos.Count).FirstOrDefault();
        }

        public IdeaNegocio ObtenerIdeaMayorIngresos()
        {
            return IdeasNegocio.OrderByDescending(idea => idea.Ingresos).FirstOrDefault();
        }

        public List<string> ObtenerTop3Rentables()
        {
            return IdeasNegocio.OrderByDescending(idea => idea.Ingresos).Take(3).Select(idea => idea.Nombre).ToList();
        }

        public List<string> ObtenerIdeasMasTresDepartamentos()
        {
            return IdeasNegocio.Where(idea => idea.Departamentos.Count > 3).Select(idea => idea.Nombre).ToList();
        }

        public decimal ObtenerSumaTotalIngresos()
        {
            return IdeasNegocio.Sum(idea => idea.Ingresos);
        }

        public decimal ObtenerSumaTotalInversion()
        {
            return IdeasNegocio.Sum(idea => idea.Inversion);
        }

        public string ObtenerIdeaConMasHerramientas4RI()
        {
            var idea = IdeasNegocio.OrderByDescending(i => i.Herramientas4RI.Count).FirstOrDefault();
            return idea != null ? idea.Nombre : "Ninguna idea tiene herramientas 4RI.";
        }

        public int ContarIdeasConIA()
        {
            return IdeasNegocio.Count(idea => idea.Herramientas4RI.Any(herramienta => herramienta.Nombre.ToLower().Contains("inteligencia artificial")));
        }

        public List<string> ObtenerIdeasConDesarrolloSostenible()
        {
            return IdeasNegocio.Where(idea => idea.ImpactoSocialEconomico.ToLower().Contains("desarrollo sostenible")).Select(idea => idea.Nombre).ToList();
        }
    }
}

