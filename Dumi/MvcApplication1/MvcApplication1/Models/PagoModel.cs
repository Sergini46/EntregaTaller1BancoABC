using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvcApplication1.Models
{
    public class PagoModel
    {
        [Display(Name = "Tipo Servicio")]
        public string TipoServicio { get; set; }

        [Display(Name = "Número Factura")]
        public string Nofactura { get; set; }

        [Display(Name = "Producto")]
        public string IdProducto { get; set; }

        [Display(Name = "Valor Factura")]
        public double ValorFactura { get; set; }

        [Display(Name = "Resultado Web Service")]
        public string RetornoWS { get; set; }

        [Display(Name = "Usuario")]
        public string Usuario { get; set; }
    }
}
