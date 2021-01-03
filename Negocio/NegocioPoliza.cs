using Datos;
using Entidad;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Negocio
{
    public class NegocioPoliza
    {
        public ContextoDatos _context { get; set; }
        
        public List<Poliza> ListarPolizas()
        {
            return _context.Polizas.ToList();
        }
        public void BatchCalculoPension(DateTime FechaProyeccion)
        {
            _context.Polizas.ToList().ForEach(x => x.PensionCalculada = CalcularPension(x.PensionInicial, x.FechaDevengue, FechaProyeccion));
            _context.SaveChanges();
        }


        //Evaluación Resolver
        private decimal CalcularPension(decimal PensionInicial, DateTime FechaDevengue, DateTime FechaProyeccion)
        {
            return 100;
        }
    }
}
