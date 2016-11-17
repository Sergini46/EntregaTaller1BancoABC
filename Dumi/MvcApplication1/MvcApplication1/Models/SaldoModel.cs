using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvcApplication1.Models
{
    public class SaldoModel
    {
        [Display(Name = "Tipo Servicio")]
        public string TipoServicio { get; set; }

        [Display(Name = "Número Factura")]
        public string NumeroFactura { get; set; }

        [Display(Name = "ReferenciaFactura")]
        public string ReferenciaFactura { get; set; }

        [Display(Name = "Total a Pagar")]
        public double TotalPagar { get; set; }

        [Display(Name = "Retorno")]
        public bool Retorno { get; set; }
            
    }
}
