using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvcApplication1.Models
{
    public class HomeModel
    {
        [Display(Name = "Nombre de usuario")]
        public string Usuario { get; set; }

        [Display(Name = "Contraseña")]
        [DataType(DataType.Password)]
        public string Contraseña { get; set; }

        [Display(Name = "Resultado Web Service")]
        public string RetornoWS { get; set; }
    }
}
