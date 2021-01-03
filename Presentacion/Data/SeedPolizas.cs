using System.Linq;
using Datos;

namespace Presentacion.Data
{
    public class SeedPolizas
    {
        public static void Initialize(ContextoDatos context)
        {            
            if(!context.Polizas.Any())
            {
                context.Polizas.AddRange(
                    new Entidad.Poliza(1,"Pedro",1000,new System.DateTime(2015,01,01)),
                    new Entidad.Poliza(2,"Santiago",1000,new System.DateTime(2015,02,01)),
                    new Entidad.Poliza(3,"Juan",1000,new System.DateTime(2015,03,01)),
                    new Entidad.Poliza(4,"Andres",1000,new System.DateTime(2015,04,01)),
                    new Entidad.Poliza(5,"Bartolome",1000,new System.DateTime(2015,05,01)),
                    new Entidad.Poliza(6,"Santiago",1000,new System.DateTime(2015,06,01)),
                    new Entidad.Poliza(7,"Judas",1000,new System.DateTime(2015,07,01)),
                    new Entidad.Poliza(8,"Judas Tadeo",1000,new System.DateTime(2015,08,01)),
                    new Entidad.Poliza(9,"Mateo",1000,new System.DateTime(2015,09,01)),
                    new Entidad.Poliza(10,"Felipe",1000,new System.DateTime(2015,10,01)),
                    new Entidad.Poliza(11,"Simon",1000,new System.DateTime(2015,11,01)),
                    new Entidad.Poliza(12,"Tomás",1000,new System.DateTime(2015,12,01))
                    
                );
                context.SaveChanges();
            }            
        }
    }
}