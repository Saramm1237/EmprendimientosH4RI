namespace Emprendimientos4RI.Models
{
    public class IdeaNegocio
    {
        public int Codigo { get; set; }
        public string Nombre { get; set; }
        public string ImpactoSocialEconomico { get; set; }
        public List<Departamento> Departamentos { get; set; }
        public decimal Inversion { get; set; }
        public decimal Ingresos { get; set; }
        public List<IntegranteEquipo> Integrantes { get; set; }
        public List<Herramienta4RI> Herramientas4RI { get; set; }

        public IdeaNegocio()
        {
            Departamentos = new List<Departamento>();
            Integrantes = new List<IntegranteEquipo>();
            Herramientas4RI = new List<Herramienta4RI>();
        }

        public void AgregarIntegrante(IntegranteEquipo integrante)
        {
            Integrantes.Add(integrante);
        }

        public void EliminarIntegrante(IntegranteEquipo integrante)
        {
            Integrantes.Remove(integrante);
        }

        public void AgregarHerramienta(Herramienta4RI herramienta)
        {
            Herramientas4RI.Add(herramienta);
        }

        public void EliminarHerramienta(Herramienta4RI herramienta)
        {
            Herramientas4RI.Remove(herramienta);
        }
    }
}
