﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.18063
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MvcApplication1.WSPagos {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://www.BancoABC.com/RealizarPago/", ConfigurationName="WSPagos.RealizarPago")]
    public interface RealizarPago {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.BancoABC.com/RealizarPago/RealizarPago", ReplyAction="*")]
        MvcApplication1.WSPagos.RealizarPagoResponse RealizarPago(MvcApplication1.WSPagos.RealizarPagoRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.BancoABC.com/RealizarPago/RealizarPago", ReplyAction="*")]
        System.Threading.Tasks.Task<MvcApplication1.WSPagos.RealizarPagoResponse> RealizarPagoAsync(MvcApplication1.WSPagos.RealizarPagoRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class RealizarPagoRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="RealizarPago", Namespace="http://www.BancoABC.com/RealizarPago/", Order=0)]
        public MvcApplication1.WSPagos.RealizarPagoRequestBody Body;
        
        public RealizarPagoRequest() {
        }
        
        public RealizarPagoRequest(MvcApplication1.WSPagos.RealizarPagoRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://www.BancoABC/EntidadComun")]
    public partial class RealizarPagoRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string TipoServicio;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string NoFactura;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string IdProducto;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=3)]
        public double ValorFactura;
        
        public RealizarPagoRequestBody() {
        }
        
        public RealizarPagoRequestBody(string TipoServicio, string NoFactura, string IdProducto, double ValorFactura) {
            this.TipoServicio = TipoServicio;
            this.NoFactura = NoFactura;
            this.IdProducto = IdProducto;
            this.ValorFactura = ValorFactura;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class RealizarPagoResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="RealizarPagoResponse", Namespace="http://www.BancoABC.com/RealizarPago/", Order=0)]
        public MvcApplication1.WSPagos.RealizarPagoResponseBody Body;
        
        public RealizarPagoResponse() {
        }
        
        public RealizarPagoResponse(MvcApplication1.WSPagos.RealizarPagoResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://www.BancoABC/EntidadComun")]
    public partial class RealizarPagoResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string Mensaje;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=1)]
        public bool Result;
        
        public RealizarPagoResponseBody() {
        }
        
        public RealizarPagoResponseBody(string Mensaje, bool Result) {
            this.Mensaje = Mensaje;
            this.Result = Result;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface RealizarPagoChannel : MvcApplication1.WSPagos.RealizarPago, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class RealizarPagoClient : System.ServiceModel.ClientBase<MvcApplication1.WSPagos.RealizarPago>, MvcApplication1.WSPagos.RealizarPago {
        
        public RealizarPagoClient() {
        }
        
        public RealizarPagoClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public RealizarPagoClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public RealizarPagoClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public RealizarPagoClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        MvcApplication1.WSPagos.RealizarPagoResponse MvcApplication1.WSPagos.RealizarPago.RealizarPago(MvcApplication1.WSPagos.RealizarPagoRequest request) {
            return base.Channel.RealizarPago(request);
        }
        
        public string RealizarPago(string TipoServicio, string NoFactura, string IdProducto, double ValorFactura, out bool Result) {
            MvcApplication1.WSPagos.RealizarPagoRequest inValue = new MvcApplication1.WSPagos.RealizarPagoRequest();
            inValue.Body = new MvcApplication1.WSPagos.RealizarPagoRequestBody();
            inValue.Body.TipoServicio = TipoServicio;
            inValue.Body.NoFactura = NoFactura;
            inValue.Body.IdProducto = IdProducto;
            inValue.Body.ValorFactura = ValorFactura;
            MvcApplication1.WSPagos.RealizarPagoResponse retVal = ((MvcApplication1.WSPagos.RealizarPago)(this)).RealizarPago(inValue);
            Result = retVal.Body.Result;
            return retVal.Body.Mensaje;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<MvcApplication1.WSPagos.RealizarPagoResponse> MvcApplication1.WSPagos.RealizarPago.RealizarPagoAsync(MvcApplication1.WSPagos.RealizarPagoRequest request) {
            return base.Channel.RealizarPagoAsync(request);
        }
        
        public System.Threading.Tasks.Task<MvcApplication1.WSPagos.RealizarPagoResponse> RealizarPagoAsync(string TipoServicio, string NoFactura, string IdProducto, double ValorFactura) {
            MvcApplication1.WSPagos.RealizarPagoRequest inValue = new MvcApplication1.WSPagos.RealizarPagoRequest();
            inValue.Body = new MvcApplication1.WSPagos.RealizarPagoRequestBody();
            inValue.Body.TipoServicio = TipoServicio;
            inValue.Body.NoFactura = NoFactura;
            inValue.Body.IdProducto = IdProducto;
            inValue.Body.ValorFactura = ValorFactura;
            return ((MvcApplication1.WSPagos.RealizarPago)(this)).RealizarPagoAsync(inValue);
        }
    }
}