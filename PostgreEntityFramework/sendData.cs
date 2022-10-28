using entityBasicoDAL;
using System.Runtime.CompilerServices;

namespace EntityFrameworkDAL
{
    public static class sendData
    {
        public static void Seed(this IHost host)
        {
            using var scope = host.Services.CreateScope();
            using var context = scope.ServiceProvider.GetRequiredService<AccesoDC>();
            context.Database.EnsureCreated();
            AddEmployees(context);
        }

        private static void AddEmployees(AccesoDC context)
        {
            var employee = context.empleados.FirstOrDefault();
            if (employee != null) return;
            context.empleados.Add(new Empleado
            {
                nombre_empleado = "Javier mena",
                
            }) ;
            context.SaveChanges();
        }
    }
}
