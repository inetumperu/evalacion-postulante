using System;
using Microsoft.EntityFrameworkCore;
using Entidad;

namespace Datos
{
    public class ContextoDatos : DbContext
    {
        public ContextoDatos(DbContextOptions options) : base(options)
        {            
        }

        public DbSet<Poliza> Polizas { get; set; }

    }
}
