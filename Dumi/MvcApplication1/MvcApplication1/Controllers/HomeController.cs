using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcApplication1.Models;

namespace MvcApplication1.Controllers
{
    public class HomeController : Controller
    {
        #region Call Views
        public ActionResult Index()
        {
            ViewBag.Message = "Taller 1 Modelo y validación de arquitectura";

            return View();
        }
        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Login()
        {
            return View();
        }
        public ActionResult ConsultaSaldo()
        {
            return View();
        }
        public ActionResult VerificarSaldo()
        {
            return View();
        }
        public ActionResult RealizarPago()
        {
            return View();
        }
        #endregion

        #region Call Actions
        public ActionResult ConsultarLogin(HomeModel model, string returnUrl)
        {
            model.RetornoWS = "";
            WSSeguridad.SeguridadClient proxy = new WSSeguridad.SeguridadClient();
            bool rta = false;
            bool colocaValor = false;
            if (colocaValor = model.Usuario != null && model.Contraseña != null == true)
            {
                proxy.AutenticarUsuario(model.Usuario, model.Contraseña, out rta);
            }
            if (colocaValor)
                model.RetornoWS = rta.ToString();
            else
                model.RetornoWS = "";
            return View("Login",model);
        }
        public ActionResult ConsultarSaldo(SaldoModel model, string returnUrl)
        {
            WSConsultarSaldo.ConsultaSaldoClient proxy = new WSConsultarSaldo.ConsultaSaldoClient ();
            WSConsultarSaldo.ConsultaSaldoPagarResponse Msg = new WSConsultarSaldo.ConsultaSaldoPagarResponse();
            
            WSConsultarSaldo.ConsultaSaldoPagarRequest MsgReq = new WSConsultarSaldo.ConsultaSaldoPagarRequest();
            MsgReq.Body = new WSConsultarSaldo.ConsultaSaldoPagarRequestBody();
            MsgReq.Body.NoFactura = model.NumeroFactura;
            MsgReq.Body.TipoServicio = model.TipoServicio;
            Msg=  proxy.ConsultaSaldoPagar( MsgReq);
            if (Msg.Body != null)
            {
                model.Retorno = true;
                model.ReferenciaFactura = Msg.Body.referenciaFactura;
                model.TotalPagar = Msg.Body.totalPagar;
            }
            else
            {
                model.Retorno = false;
            }

            return View("ConsultaSaldo", model);
        }
        public ActionResult VerificacionSaldo(VerificarSaldoModel model, string returnUrl)
        {
            WSVerificarSaldo.VerificarSaldoClient proxy = new WSVerificarSaldo.VerificarSaldoClient();
            bool rta = false;
            
            bool colocaValor = false;
            if (colocaValor = model.Producto != 0 && model.Valor != null == true)
            {
                proxy.VerificarSaldo(model.Producto, model.Valor, out rta);
            }
            if (colocaValor)
                model.RetornoWS = rta.ToString();
            else
                model.RetornoWS = "";
            return View("VerificarSaldo", model);
        }
        public ActionResult Pagar(PagoModel model, string returnUrl)
        {
            WSPagos.RealizarPagoClient proxy = new WSPagos.RealizarPagoClient();
            bool rta = false;
            bool colocaValor = false;
            if (colocaValor = model.TipoServicio != null && model.Nofactura != null & model.IdProducto != null && model.ValorFactura >0 == true)
            {
                proxy.RealizarPago(model.TipoServicio, model.Nofactura, model.IdProducto, model.ValorFactura, out rta);
            }
            if (colocaValor)
            {
                if (rta)//!rta
                {
                    WSCompensar.CompensaIIClient proxyCompensa = new WSCompensar.CompensaIIClient();
                    proxyCompensa.Compensacion(model.TipoServicio, model.Nofactura, model.IdProducto, model.ValorFactura, out rta);
                    if(notificarUsuario(model.Usuario))
                        model.RetornoWS = "transacción cancelada";
                }
                else
                    model.RetornoWS = rta.ToString();
            }
            else
                model.RetornoWS = "";
            return View("RealizarPago", model);
        }
        #endregion

        #region functions
        public bool notificarUsuario(string Usuario)
        {
            WSNotificacionUsuario.NotificarUsuarioClient ProxyNotifica = new WSNotificacionUsuario.NotificarUsuarioClient();
            string CorreoUsuario = "";
            string Mensaje = "Su transacción no se pudo llevar a cabo por favor intente de nuevo, el dinero descontado en su cuenta ha sido reembolsado de inmediato.";
            getEmailUsuario(Usuario, out CorreoUsuario);
            return ProxyNotifica.NotificarUsuario("Correo@Javeriana.edu.co", CorreoUsuario, ref Mensaje);
        }
        public void getEmailUsuario(string usuario, out string Correo)
        {
            Correo = "CorreoUsuario@javeriana.edu.co";
        }
        #endregion

    }
}
