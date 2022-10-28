using entityBasicoDAL;
using EntityFrameworkDAL.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PostgreEntityFramework.Models;
using System.Diagnostics;

namespace PostgreEntityFramework.Controllers
{
    public class HomeController : Controller
    {
        private readonly AccesoDC context;

        public HomeController(AccesoDC context)
        {
            this.context = context;
        }

        public IActionResult Index()
        {
            //Listamos en la vista los nombres de los empleados
            var empleados = this.context.empleados.Include(e => e.nombre_empleado).Select(e => new EmpleadoViewModel
            {
               Nombre = e.nombre_empleado
            });
            return View(empleados);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}