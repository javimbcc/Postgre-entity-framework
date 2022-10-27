using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entityBasicoDAL
{
    public class AccesoDC: DbContext
    {

        public AccesoDC(DbContextOptions<AccesoDC> options) : base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.UseSerialColumns();
        }
        public DbSet<Empleado> empleados { get; set; }

        public DbSet<nivel_acc> nivel_acceso { get; set; }
    }
}
