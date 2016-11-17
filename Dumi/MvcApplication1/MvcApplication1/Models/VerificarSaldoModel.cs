using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvcApplication1.Models
{
    public class VerificarSaldoModel
    {
        [Display(Name = "Producto")]
        public int Producto { get; set; }

        [Display(Name = "Valor Factura")]
        public double Valor { get; set; }

        [Display(Name = "Resultado Web Service")]
        public string RetornoWS { get; set; }
        
    }
}
