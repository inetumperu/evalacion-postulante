using System;
using System.ComponentModel.DataAnnotations;

namespace Entidad
{
    public class Poliza
    {
        
        [Display(Name="Numero de Póliza")]
        public int Id { get; set; }

        [Display(Name="Nombre de Titular")]
        public string NombreTitular { get; set; }

        [Display(Name="Pensión Inicial"),DataType(DataType.Currency)]
        public decimal PensionInicial { get; set; }

        [Display(Name="Fecha Devengue"),DataType(DataType.Date)]
        public DateTime FechaDevengue { get; set; }

        [Display(Name="Pensión Actual"),DataType(DataType.Currency)]
        public decimal PensionCalculada { get; set; }

        public Poliza(int Id, string NombreTitular, decimal PensionInicial, DateTime FechaDevengue)
        {
          this.Id= Id;
          this.NombreTitular = NombreTitular;
          this.PensionInicial = PensionInicial;
          this.FechaDevengue = FechaDevengue;    
        }
    }
}
