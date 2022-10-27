using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entityBasicoDAL
{
    public class Empleado
    {
        //Esto es la estructura de un registro de la tabla (Se pone en singular)
        public int Id { get; set; }

        public string nombre_empleado { get; set; }
        public List<nivel_acc> nivel_accesos { get; set; }
    }

    public class nivel_acc
    {
        public int Id { get; set; }
        [Required]
        public string nivel_acceso { get; set; }
        public string desc_acceso { get; set; }
    }
}
