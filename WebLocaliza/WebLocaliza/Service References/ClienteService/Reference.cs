﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.34014
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebLocaliza.ClienteService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Cliente", Namespace="http://schemas.datacontract.org/2004/07/LocalizaV1.Dominio")]
    [System.SerializableAttribute()]
    public partial class Cliente : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string apMaternoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string apPaternoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string direccionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string distritoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string dniField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string emailField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private char estadoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string generoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int idClienteField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string nombreField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string telefonoField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string apMaterno {
            get {
                return this.apMaternoField;
            }
            set {
                if ((object.ReferenceEquals(this.apMaternoField, value) != true)) {
                    this.apMaternoField = value;
                    this.RaisePropertyChanged("apMaterno");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string apPaterno {
            get {
                return this.apPaternoField;
            }
            set {
                if ((object.ReferenceEquals(this.apPaternoField, value) != true)) {
                    this.apPaternoField = value;
                    this.RaisePropertyChanged("apPaterno");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string direccion {
            get {
                return this.direccionField;
            }
            set {
                if ((object.ReferenceEquals(this.direccionField, value) != true)) {
                    this.direccionField = value;
                    this.RaisePropertyChanged("direccion");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string distrito {
            get {
                return this.distritoField;
            }
            set {
                if ((object.ReferenceEquals(this.distritoField, value) != true)) {
                    this.distritoField = value;
                    this.RaisePropertyChanged("distrito");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string dni {
            get {
                return this.dniField;
            }
            set {
                if ((object.ReferenceEquals(this.dniField, value) != true)) {
                    this.dniField = value;
                    this.RaisePropertyChanged("dni");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string email {
            get {
                return this.emailField;
            }
            set {
                if ((object.ReferenceEquals(this.emailField, value) != true)) {
                    this.emailField = value;
                    this.RaisePropertyChanged("email");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public char estado {
            get {
                return this.estadoField;
            }
            set {
                if ((this.estadoField.Equals(value) != true)) {
                    this.estadoField = value;
                    this.RaisePropertyChanged("estado");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string genero {
            get {
                return this.generoField;
            }
            set {
                if ((object.ReferenceEquals(this.generoField, value) != true)) {
                    this.generoField = value;
                    this.RaisePropertyChanged("genero");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int idCliente {
            get {
                return this.idClienteField;
            }
            set {
                if ((this.idClienteField.Equals(value) != true)) {
                    this.idClienteField = value;
                    this.RaisePropertyChanged("idCliente");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string nombre {
            get {
                return this.nombreField;
            }
            set {
                if ((object.ReferenceEquals(this.nombreField, value) != true)) {
                    this.nombreField = value;
                    this.RaisePropertyChanged("nombre");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string telefono {
            get {
                return this.telefonoField;
            }
            set {
                if ((object.ReferenceEquals(this.telefonoField, value) != true)) {
                    this.telefonoField = value;
                    this.RaisePropertyChanged("telefono");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ClienteService.IClienteSVC")]
    public interface IClienteSVC {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IClienteSVC/CrearCliente", ReplyAction="http://tempuri.org/IClienteSVC/CrearClienteResponse")]
        WebLocaliza.ClienteService.Cliente CrearCliente(string nombre, string paterno, string materno, string genero, string dni, string email, string telefono, string direccion, string distrito);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IClienteSVC/ObtenerCliente", ReplyAction="http://tempuri.org/IClienteSVC/ObtenerClienteResponse")]
        WebLocaliza.ClienteService.Cliente ObtenerCliente(int codigo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IClienteSVC/ModificarCliente", ReplyAction="http://tempuri.org/IClienteSVC/ModificarClienteResponse")]
        WebLocaliza.ClienteService.Cliente ModificarCliente(int codigo, string nombre, string paterno, string materno, string genero, string dni, string email, string telefono, string direccion, string distrito);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IClienteSVC/EliminarCliente", ReplyAction="http://tempuri.org/IClienteSVC/EliminarClienteResponse")]
        void EliminarCliente(int codigo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IClienteSVC/ListarCliente", ReplyAction="http://tempuri.org/IClienteSVC/ListarClienteResponse")]
        WebLocaliza.ClienteService.Cliente[] ListarCliente();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IClienteSVC/validaDni", ReplyAction="http://tempuri.org/IClienteSVC/validaDniResponse")]
        bool validaDni(string dni);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IClienteSVC/encuentraDni", ReplyAction="http://tempuri.org/IClienteSVC/encuentraDniResponse")]
        bool encuentraDni(string dni);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IClienteSVC/mensajes", ReplyAction="http://tempuri.org/IClienteSVC/mensajesResponse")]
        string mensajes(int valor);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IClienteSVC/BuscarDni", ReplyAction="http://tempuri.org/IClienteSVC/BuscarDniResponse")]
        WebLocaliza.ClienteService.Cliente[] BuscarDni(string dni);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IClienteSVCChannel : WebLocaliza.ClienteService.IClienteSVC, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ClienteSVCClient : System.ServiceModel.ClientBase<WebLocaliza.ClienteService.IClienteSVC>, WebLocaliza.ClienteService.IClienteSVC {
        
        public ClienteSVCClient() {
        }
        
        public ClienteSVCClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ClienteSVCClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ClienteSVCClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ClienteSVCClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public WebLocaliza.ClienteService.Cliente CrearCliente(string nombre, string paterno, string materno, string genero, string dni, string email, string telefono, string direccion, string distrito) {
            return base.Channel.CrearCliente(nombre, paterno, materno, genero, dni, email, telefono, direccion, distrito);
        }
        
        public WebLocaliza.ClienteService.Cliente ObtenerCliente(int codigo) {
            return base.Channel.ObtenerCliente(codigo);
        }
        
        public WebLocaliza.ClienteService.Cliente ModificarCliente(int codigo, string nombre, string paterno, string materno, string genero, string dni, string email, string telefono, string direccion, string distrito) {
            return base.Channel.ModificarCliente(codigo, nombre, paterno, materno, genero, dni, email, telefono, direccion, distrito);
        }
        
        public void EliminarCliente(int codigo) {
            base.Channel.EliminarCliente(codigo);
        }
        
        public WebLocaliza.ClienteService.Cliente[] ListarCliente() {
            return base.Channel.ListarCliente();
        }
        
        public bool validaDni(string dni) {
            return base.Channel.validaDni(dni);
        }
        
        public bool encuentraDni(string dni) {
            return base.Channel.encuentraDni(dni);
        }
        
        public string mensajes(int valor) {
            return base.Channel.mensajes(valor);
        }
        
        public WebLocaliza.ClienteService.Cliente[] BuscarDni(string dni) {
            return base.Channel.BuscarDni(dni);
        }
    }
}