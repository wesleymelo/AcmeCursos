﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AcmeCursos.Presentation.InscricaoServiceRemoto {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="InscricaoDTO", Namespace="http://schemas.datacontract.org/2004/07/AcmeCursos.Service.DTO")]
    [System.SerializableAttribute()]
    public partial class InscricaoDTO : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private AcmeCursos.Presentation.InscricaoServiceRemoto.CursoDTO CursoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int CursoIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime DataInscricaoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private AcmeCursos.Presentation.InscricaoServiceRemoto.EstudanteDTO EstudanteField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int EstudanteIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
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
        public AcmeCursos.Presentation.InscricaoServiceRemoto.CursoDTO Curso {
            get {
                return this.CursoField;
            }
            set {
                if ((object.ReferenceEquals(this.CursoField, value) != true)) {
                    this.CursoField = value;
                    this.RaisePropertyChanged("Curso");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int CursoId {
            get {
                return this.CursoIdField;
            }
            set {
                if ((this.CursoIdField.Equals(value) != true)) {
                    this.CursoIdField = value;
                    this.RaisePropertyChanged("CursoId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime DataInscricao {
            get {
                return this.DataInscricaoField;
            }
            set {
                if ((this.DataInscricaoField.Equals(value) != true)) {
                    this.DataInscricaoField = value;
                    this.RaisePropertyChanged("DataInscricao");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public AcmeCursos.Presentation.InscricaoServiceRemoto.EstudanteDTO Estudante {
            get {
                return this.EstudanteField;
            }
            set {
                if ((object.ReferenceEquals(this.EstudanteField, value) != true)) {
                    this.EstudanteField = value;
                    this.RaisePropertyChanged("Estudante");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int EstudanteId {
            get {
                return this.EstudanteIdField;
            }
            set {
                if ((this.EstudanteIdField.Equals(value) != true)) {
                    this.EstudanteIdField = value;
                    this.RaisePropertyChanged("EstudanteId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="CursoDTO", Namespace="http://schemas.datacontract.org/2004/07/AcmeCursos.Service.DTO")]
    [System.SerializableAttribute()]
    public partial class CursoDTO : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime DataLimiteInscricaoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DescricaoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NomeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Collections.Generic.List<AcmeCursos.Presentation.InscricaoServiceRemoto.ProfessorDTO> ProfessoresField;
        
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
        public System.DateTime DataLimiteInscricao {
            get {
                return this.DataLimiteInscricaoField;
            }
            set {
                if ((this.DataLimiteInscricaoField.Equals(value) != true)) {
                    this.DataLimiteInscricaoField = value;
                    this.RaisePropertyChanged("DataLimiteInscricao");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Descricao {
            get {
                return this.DescricaoField;
            }
            set {
                if ((object.ReferenceEquals(this.DescricaoField, value) != true)) {
                    this.DescricaoField = value;
                    this.RaisePropertyChanged("Descricao");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Nome {
            get {
                return this.NomeField;
            }
            set {
                if ((object.ReferenceEquals(this.NomeField, value) != true)) {
                    this.NomeField = value;
                    this.RaisePropertyChanged("Nome");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Collections.Generic.List<AcmeCursos.Presentation.InscricaoServiceRemoto.ProfessorDTO> Professores {
            get {
                return this.ProfessoresField;
            }
            set {
                if ((object.ReferenceEquals(this.ProfessoresField, value) != true)) {
                    this.ProfessoresField = value;
                    this.RaisePropertyChanged("Professores");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="EstudanteDTO", Namespace="http://schemas.datacontract.org/2004/07/AcmeCursos.Service.DTO")]
    [System.SerializableAttribute()]
    public partial class EstudanteDTO : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime DataMatriculaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Collections.Generic.List<AcmeCursos.Presentation.InscricaoServiceRemoto.InscricaoDTO> InscricoesField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NomeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string SobreNomeField;
        
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
        public System.DateTime DataMatricula {
            get {
                return this.DataMatriculaField;
            }
            set {
                if ((this.DataMatriculaField.Equals(value) != true)) {
                    this.DataMatriculaField = value;
                    this.RaisePropertyChanged("DataMatricula");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Collections.Generic.List<AcmeCursos.Presentation.InscricaoServiceRemoto.InscricaoDTO> Inscricoes {
            get {
                return this.InscricoesField;
            }
            set {
                if ((object.ReferenceEquals(this.InscricoesField, value) != true)) {
                    this.InscricoesField = value;
                    this.RaisePropertyChanged("Inscricoes");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Nome {
            get {
                return this.NomeField;
            }
            set {
                if ((object.ReferenceEquals(this.NomeField, value) != true)) {
                    this.NomeField = value;
                    this.RaisePropertyChanged("Nome");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string SobreNome {
            get {
                return this.SobreNomeField;
            }
            set {
                if ((object.ReferenceEquals(this.SobreNomeField, value) != true)) {
                    this.SobreNomeField = value;
                    this.RaisePropertyChanged("SobreNome");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="ProfessorDTO", Namespace="http://schemas.datacontract.org/2004/07/AcmeCursos.Service.DTO")]
    [System.SerializableAttribute()]
    public partial class ProfessorDTO : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Collections.Generic.List<AcmeCursos.Presentation.InscricaoServiceRemoto.CursoDTO> CursosField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NomeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string SobrenomeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TitulacaoField;
        
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
        public System.Collections.Generic.List<AcmeCursos.Presentation.InscricaoServiceRemoto.CursoDTO> Cursos {
            get {
                return this.CursosField;
            }
            set {
                if ((object.ReferenceEquals(this.CursosField, value) != true)) {
                    this.CursosField = value;
                    this.RaisePropertyChanged("Cursos");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Nome {
            get {
                return this.NomeField;
            }
            set {
                if ((object.ReferenceEquals(this.NomeField, value) != true)) {
                    this.NomeField = value;
                    this.RaisePropertyChanged("Nome");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Sobrenome {
            get {
                return this.SobrenomeField;
            }
            set {
                if ((object.ReferenceEquals(this.SobrenomeField, value) != true)) {
                    this.SobrenomeField = value;
                    this.RaisePropertyChanged("Sobrenome");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Titulacao {
            get {
                return this.TitulacaoField;
            }
            set {
                if ((object.ReferenceEquals(this.TitulacaoField, value) != true)) {
                    this.TitulacaoField = value;
                    this.RaisePropertyChanged("Titulacao");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="ServiceException", Namespace="http://schemas.datacontract.org/2004/07/AcmeCursos.Service.Exceptions")]
    [System.SerializableAttribute()]
    public partial class ServiceException : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MensagemField;
        
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
        public string Mensagem {
            get {
                return this.MensagemField;
            }
            set {
                if ((object.ReferenceEquals(this.MensagemField, value) != true)) {
                    this.MensagemField = value;
                    this.RaisePropertyChanged("Mensagem");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="InscricaoServiceRemoto.IInscricaoService")]
    public interface IInscricaoService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IInscricaoService/Add", ReplyAction="http://tempuri.org/IInscricaoService/AddResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(AcmeCursos.Presentation.InscricaoServiceRemoto.ServiceException), Action="http://tempuri.org/IInscricaoService/AddServiceExceptionFault", Name="ServiceException", Namespace="http://schemas.datacontract.org/2004/07/AcmeCursos.Service.Exceptions")]
        bool Add(AcmeCursos.Presentation.InscricaoServiceRemoto.InscricaoDTO inscricao);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IInscricaoService/Add", ReplyAction="http://tempuri.org/IInscricaoService/AddResponse")]
        System.Threading.Tasks.Task<bool> AddAsync(AcmeCursos.Presentation.InscricaoServiceRemoto.InscricaoDTO inscricao);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IInscricaoService/GetAllByEstudante", ReplyAction="http://tempuri.org/IInscricaoService/GetAllByEstudanteResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(AcmeCursos.Presentation.InscricaoServiceRemoto.ServiceException), Action="http://tempuri.org/IInscricaoService/GetAllByEstudanteServiceExceptionFault", Name="ServiceException", Namespace="http://schemas.datacontract.org/2004/07/AcmeCursos.Service.Exceptions")]
        System.Collections.Generic.List<AcmeCursos.Presentation.InscricaoServiceRemoto.InscricaoDTO> GetAllByEstudante(int idEstudante);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IInscricaoService/GetAllByEstudante", ReplyAction="http://tempuri.org/IInscricaoService/GetAllByEstudanteResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<AcmeCursos.Presentation.InscricaoServiceRemoto.InscricaoDTO>> GetAllByEstudanteAsync(int idEstudante);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IInscricaoServiceChannel : AcmeCursos.Presentation.InscricaoServiceRemoto.IInscricaoService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class InscricaoServiceClient : System.ServiceModel.ClientBase<AcmeCursos.Presentation.InscricaoServiceRemoto.IInscricaoService>, AcmeCursos.Presentation.InscricaoServiceRemoto.IInscricaoService {
        
        public InscricaoServiceClient() {
        }
        
        public InscricaoServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public InscricaoServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public InscricaoServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public InscricaoServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public bool Add(AcmeCursos.Presentation.InscricaoServiceRemoto.InscricaoDTO inscricao) {
            return base.Channel.Add(inscricao);
        }
        
        public System.Threading.Tasks.Task<bool> AddAsync(AcmeCursos.Presentation.InscricaoServiceRemoto.InscricaoDTO inscricao) {
            return base.Channel.AddAsync(inscricao);
        }
        
        public System.Collections.Generic.List<AcmeCursos.Presentation.InscricaoServiceRemoto.InscricaoDTO> GetAllByEstudante(int idEstudante) {
            return base.Channel.GetAllByEstudante(idEstudante);
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<AcmeCursos.Presentation.InscricaoServiceRemoto.InscricaoDTO>> GetAllByEstudanteAsync(int idEstudante) {
            return base.Channel.GetAllByEstudanteAsync(idEstudante);
        }
    }
}
