﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WcfSysOticaClient.ServiceReference1 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CompositeType", Namespace="http://schemas.datacontract.org/2004/07/WcfSysOtica")]
    [System.SerializableAttribute()]
    public partial class CompositeType : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool BoolValueField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string StringValueField;
        
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
        public bool BoolValue {
            get {
                return this.BoolValueField;
            }
            set {
                if ((this.BoolValueField.Equals(value) != true)) {
                    this.BoolValueField = value;
                    this.RaisePropertyChanged("BoolValue");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string StringValue {
            get {
                return this.StringValueField;
            }
            set {
                if ((object.ReferenceEquals(this.StringValueField, value) != true)) {
                    this.StringValueField = value;
                    this.RaisePropertyChanged("StringValue");
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Cliente", Namespace="http://schemas.datacontract.org/2004/07/WcfSysOtica")]
    [System.SerializableAttribute()]
    public partial class Cliente : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string cl_bairroField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string cl_celularField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string cl_cepField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string cl_cidadeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string cl_cpfField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime cl_datanascimentoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string cl_emailField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string cl_enderecoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int cl_idField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string cl_nomeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string cl_nomemaeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string cl_nomepaiField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string cl_numeroField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string cl_observacoesField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string cl_profissaoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string cl_rgField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string cl_telefoneField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string cl_telefone2Field;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string cl_ufField;
        
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
        public string cl_bairro {
            get {
                return this.cl_bairroField;
            }
            set {
                if ((object.ReferenceEquals(this.cl_bairroField, value) != true)) {
                    this.cl_bairroField = value;
                    this.RaisePropertyChanged("cl_bairro");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string cl_celular {
            get {
                return this.cl_celularField;
            }
            set {
                if ((object.ReferenceEquals(this.cl_celularField, value) != true)) {
                    this.cl_celularField = value;
                    this.RaisePropertyChanged("cl_celular");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string cl_cep {
            get {
                return this.cl_cepField;
            }
            set {
                if ((object.ReferenceEquals(this.cl_cepField, value) != true)) {
                    this.cl_cepField = value;
                    this.RaisePropertyChanged("cl_cep");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string cl_cidade {
            get {
                return this.cl_cidadeField;
            }
            set {
                if ((object.ReferenceEquals(this.cl_cidadeField, value) != true)) {
                    this.cl_cidadeField = value;
                    this.RaisePropertyChanged("cl_cidade");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string cl_cpf {
            get {
                return this.cl_cpfField;
            }
            set {
                if ((object.ReferenceEquals(this.cl_cpfField, value) != true)) {
                    this.cl_cpfField = value;
                    this.RaisePropertyChanged("cl_cpf");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime cl_datanascimento {
            get {
                return this.cl_datanascimentoField;
            }
            set {
                if ((this.cl_datanascimentoField.Equals(value) != true)) {
                    this.cl_datanascimentoField = value;
                    this.RaisePropertyChanged("cl_datanascimento");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string cl_email {
            get {
                return this.cl_emailField;
            }
            set {
                if ((object.ReferenceEquals(this.cl_emailField, value) != true)) {
                    this.cl_emailField = value;
                    this.RaisePropertyChanged("cl_email");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string cl_endereco {
            get {
                return this.cl_enderecoField;
            }
            set {
                if ((object.ReferenceEquals(this.cl_enderecoField, value) != true)) {
                    this.cl_enderecoField = value;
                    this.RaisePropertyChanged("cl_endereco");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int cl_id {
            get {
                return this.cl_idField;
            }
            set {
                if ((this.cl_idField.Equals(value) != true)) {
                    this.cl_idField = value;
                    this.RaisePropertyChanged("cl_id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string cl_nome {
            get {
                return this.cl_nomeField;
            }
            set {
                if ((object.ReferenceEquals(this.cl_nomeField, value) != true)) {
                    this.cl_nomeField = value;
                    this.RaisePropertyChanged("cl_nome");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string cl_nomemae {
            get {
                return this.cl_nomemaeField;
            }
            set {
                if ((object.ReferenceEquals(this.cl_nomemaeField, value) != true)) {
                    this.cl_nomemaeField = value;
                    this.RaisePropertyChanged("cl_nomemae");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string cl_nomepai {
            get {
                return this.cl_nomepaiField;
            }
            set {
                if ((object.ReferenceEquals(this.cl_nomepaiField, value) != true)) {
                    this.cl_nomepaiField = value;
                    this.RaisePropertyChanged("cl_nomepai");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string cl_numero {
            get {
                return this.cl_numeroField;
            }
            set {
                if ((object.ReferenceEquals(this.cl_numeroField, value) != true)) {
                    this.cl_numeroField = value;
                    this.RaisePropertyChanged("cl_numero");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string cl_observacoes {
            get {
                return this.cl_observacoesField;
            }
            set {
                if ((object.ReferenceEquals(this.cl_observacoesField, value) != true)) {
                    this.cl_observacoesField = value;
                    this.RaisePropertyChanged("cl_observacoes");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string cl_profissao {
            get {
                return this.cl_profissaoField;
            }
            set {
                if ((object.ReferenceEquals(this.cl_profissaoField, value) != true)) {
                    this.cl_profissaoField = value;
                    this.RaisePropertyChanged("cl_profissao");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string cl_rg {
            get {
                return this.cl_rgField;
            }
            set {
                if ((object.ReferenceEquals(this.cl_rgField, value) != true)) {
                    this.cl_rgField = value;
                    this.RaisePropertyChanged("cl_rg");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string cl_telefone {
            get {
                return this.cl_telefoneField;
            }
            set {
                if ((object.ReferenceEquals(this.cl_telefoneField, value) != true)) {
                    this.cl_telefoneField = value;
                    this.RaisePropertyChanged("cl_telefone");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string cl_telefone2 {
            get {
                return this.cl_telefone2Field;
            }
            set {
                if ((object.ReferenceEquals(this.cl_telefone2Field, value) != true)) {
                    this.cl_telefone2Field = value;
                    this.RaisePropertyChanged("cl_telefone2");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string cl_uf {
            get {
                return this.cl_ufField;
            }
            set {
                if ((object.ReferenceEquals(this.cl_ufField, value) != true)) {
                    this.cl_ufField = value;
                    this.RaisePropertyChanged("cl_uf");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetData", ReplyAction="http://tempuri.org/IService1/GetDataResponse")]
        string GetData(int value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetData", ReplyAction="http://tempuri.org/IService1/GetDataResponse")]
        System.Threading.Tasks.Task<string> GetDataAsync(int value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetDataUsingDataContract", ReplyAction="http://tempuri.org/IService1/GetDataUsingDataContractResponse")]
        WcfSysOticaClient.ServiceReference1.CompositeType GetDataUsingDataContract(WcfSysOticaClient.ServiceReference1.CompositeType composite);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetDataUsingDataContract", ReplyAction="http://tempuri.org/IService1/GetDataUsingDataContractResponse")]
        System.Threading.Tasks.Task<WcfSysOticaClient.ServiceReference1.CompositeType> GetDataUsingDataContractAsync(WcfSysOticaClient.ServiceReference1.CompositeType composite);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetCliente", ReplyAction="http://tempuri.org/IService1/GetClienteResponse")]
        WcfSysOticaClient.ServiceReference1.Cliente GetCliente(WcfSysOticaClient.ServiceReference1.Cliente c);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetCliente", ReplyAction="http://tempuri.org/IService1/GetClienteResponse")]
        System.Threading.Tasks.Task<WcfSysOticaClient.ServiceReference1.Cliente> GetClienteAsync(WcfSysOticaClient.ServiceReference1.Cliente c);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : WcfSysOticaClient.ServiceReference1.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<WcfSysOticaClient.ServiceReference1.IService1>, WcfSysOticaClient.ServiceReference1.IService1 {
        
        public Service1Client() {
        }
        
        public Service1Client(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Service1Client(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string GetData(int value) {
            return base.Channel.GetData(value);
        }
        
        public System.Threading.Tasks.Task<string> GetDataAsync(int value) {
            return base.Channel.GetDataAsync(value);
        }
        
        public WcfSysOticaClient.ServiceReference1.CompositeType GetDataUsingDataContract(WcfSysOticaClient.ServiceReference1.CompositeType composite) {
            return base.Channel.GetDataUsingDataContract(composite);
        }
        
        public System.Threading.Tasks.Task<WcfSysOticaClient.ServiceReference1.CompositeType> GetDataUsingDataContractAsync(WcfSysOticaClient.ServiceReference1.CompositeType composite) {
            return base.Channel.GetDataUsingDataContractAsync(composite);
        }
        
        public WcfSysOticaClient.ServiceReference1.Cliente GetCliente(WcfSysOticaClient.ServiceReference1.Cliente c) {
            return base.Channel.GetCliente(c);
        }
        
        public System.Threading.Tasks.Task<WcfSysOticaClient.ServiceReference1.Cliente> GetClienteAsync(WcfSysOticaClient.ServiceReference1.Cliente c) {
            return base.Channel.GetClienteAsync(c);
        }
    }
}
