﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AcmeCursos.Presentation.ProfessorServiceRemote {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ProfessorDTO", Namespace="http://schemas.datacontract.org/2004/07/AcmeCursos.Service.DTO")]
    [System.SerializableAttribute()]
    public partial class ProfessorDTO : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Collections.Generic.List<AcmeCursos.Presentation.ProfessorServiceRemote.CursoDTO> CursosField;
        
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
        public System.Collections.Generic.List<AcmeCursos.Presentation.ProfessorServiceRemote.CursoDTO> Cursos {
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
        private System.Collections.Generic.List<AcmeCursos.Presentation.ProfessorServiceRemote.ProfessorDTO> ProfessoresField;
        
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
        public System.Collections.Generic.List<AcmeCursos.Presentation.ProfessorServiceRemote.ProfessorDTO> Professores {
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ProfessorServiceRemote.IProfessorService")]
    public interface IProfessorService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProfessorService/GetAll", ReplyAction="http://tempuri.org/IProfessorService/GetAllResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(AcmeCursos.Presentation.ProfessorServiceRemote.ServiceException), Action="http://tempuri.org/IProfessorService/GetAllServiceExceptionFault", Name="ServiceException", Namespace="http://schemas.datacontract.org/2004/07/AcmeCursos.Service.Exceptions")]
        System.Collections.Generic.List<AcmeCursos.Presentation.ProfessorServiceRemote.ProfessorDTO> GetAll();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProfessorService/GetAll", ReplyAction="http://tempuri.org/IProfessorService/GetAllResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<AcmeCursos.Presentation.ProfessorServiceRemote.ProfessorDTO>> GetAllAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProfessorService/GetAllWithCursos", ReplyAction="http://tempuri.org/IProfessorService/GetAllWithCursosResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(AcmeCursos.Presentation.ProfessorServiceRemote.ServiceException), Action="http://tempuri.org/IProfessorService/GetAllWithCursosServiceExceptionFault", Name="ServiceException", Namespace="http://schemas.datacontract.org/2004/07/AcmeCursos.Service.Exceptions")]
        System.Collections.Generic.List<AcmeCursos.Presentation.ProfessorServiceRemote.ProfessorDTO> GetAllWithCursos();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProfessorService/GetAllWithCursos", ReplyAction="http://tempuri.org/IProfessorService/GetAllWithCursosResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<AcmeCursos.Presentation.ProfessorServiceRemote.ProfessorDTO>> GetAllWithCursosAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProfessorService/Find", ReplyAction="http://tempuri.org/IProfessorService/FindResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(AcmeCursos.Presentation.ProfessorServiceRemote.ServiceException), Action="http://tempuri.org/IProfessorService/FindServiceExceptionFault", Name="ServiceException", Namespace="http://schemas.datacontract.org/2004/07/AcmeCursos.Service.Exceptions")]
        AcmeCursos.Presentation.ProfessorServiceRemote.ProfessorDTO Find(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProfessorService/Find", ReplyAction="http://tempuri.org/IProfessorService/FindResponse")]
        System.Threading.Tasks.Task<AcmeCursos.Presentation.ProfessorServiceRemote.ProfessorDTO> FindAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProfessorService/FindWithCursos", ReplyAction="http://tempuri.org/IProfessorService/FindWithCursosResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(AcmeCursos.Presentation.ProfessorServiceRemote.ServiceException), Action="http://tempuri.org/IProfessorService/FindWithCursosServiceExceptionFault", Name="ServiceException", Namespace="http://schemas.datacontract.org/2004/07/AcmeCursos.Service.Exceptions")]
        AcmeCursos.Presentation.ProfessorServiceRemote.ProfessorDTO FindWithCursos(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProfessorService/FindWithCursos", ReplyAction="http://tempuri.org/IProfessorService/FindWithCursosResponse")]
        System.Threading.Tasks.Task<AcmeCursos.Presentation.ProfessorServiceRemote.ProfessorDTO> FindWithCursosAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProfessorService/Delete", ReplyAction="http://tempuri.org/IProfessorService/DeleteResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(AcmeCursos.Presentation.ProfessorServiceRemote.ServiceException), Action="http://tempuri.org/IProfessorService/DeleteServiceExceptionFault", Name="ServiceException", Namespace="http://schemas.datacontract.org/2004/07/AcmeCursos.Service.Exceptions")]
        bool Delete(AcmeCursos.Presentation.ProfessorServiceRemote.ProfessorDTO professor);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProfessorService/Delete", ReplyAction="http://tempuri.org/IProfessorService/DeleteResponse")]
        System.Threading.Tasks.Task<bool> DeleteAsync(AcmeCursos.Presentation.ProfessorServiceRemote.ProfessorDTO professor);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProfessorService/Add", ReplyAction="http://tempuri.org/IProfessorService/AddResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(AcmeCursos.Presentation.ProfessorServiceRemote.ServiceException), Action="http://tempuri.org/IProfessorService/AddServiceExceptionFault", Name="ServiceException", Namespace="http://schemas.datacontract.org/2004/07/AcmeCursos.Service.Exceptions")]
        bool Add(AcmeCursos.Presentation.ProfessorServiceRemote.ProfessorDTO professor);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProfessorService/Add", ReplyAction="http://tempuri.org/IProfessorService/AddResponse")]
        System.Threading.Tasks.Task<bool> AddAsync(AcmeCursos.Presentation.ProfessorServiceRemote.ProfessorDTO professor);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProfessorService/Update", ReplyAction="http://tempuri.org/IProfessorService/UpdateResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(AcmeCursos.Presentation.ProfessorServiceRemote.ServiceException), Action="http://tempuri.org/IProfessorService/UpdateServiceExceptionFault", Name="ServiceException", Namespace="http://schemas.datacontract.org/2004/07/AcmeCursos.Service.Exceptions")]
        bool Update(AcmeCursos.Presentation.ProfessorServiceRemote.ProfessorDTO professor);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProfessorService/Update", ReplyAction="http://tempuri.org/IProfessorService/UpdateResponse")]
        System.Threading.Tasks.Task<bool> UpdateAsync(AcmeCursos.Presentation.ProfessorServiceRemote.ProfessorDTO professor);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProfessorService/GetAllByCurso", ReplyAction="http://tempuri.org/IProfessorService/GetAllByCursoResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(AcmeCursos.Presentation.ProfessorServiceRemote.ServiceException), Action="http://tempuri.org/IProfessorService/GetAllByCursoServiceExceptionFault", Name="ServiceException", Namespace="http://schemas.datacontract.org/2004/07/AcmeCursos.Service.Exceptions")]
        System.Collections.Generic.List<AcmeCursos.Presentation.ProfessorServiceRemote.ProfessorDTO> GetAllByCurso(int idCurso);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProfessorService/GetAllByCurso", ReplyAction="http://tempuri.org/IProfessorService/GetAllByCursoResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<AcmeCursos.Presentation.ProfessorServiceRemote.ProfessorDTO>> GetAllByCursoAsync(int idCurso);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IProfessorServiceChannel : AcmeCursos.Presentation.ProfessorServiceRemote.IProfessorService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ProfessorServiceClient : System.ServiceModel.ClientBase<AcmeCursos.Presentation.ProfessorServiceRemote.IProfessorService>, AcmeCursos.Presentation.ProfessorServiceRemote.IProfessorService {
        
        public ProfessorServiceClient() {
        }
        
        public ProfessorServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ProfessorServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ProfessorServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ProfessorServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Collections.Generic.List<AcmeCursos.Presentation.ProfessorServiceRemote.ProfessorDTO> GetAll() {
            return base.Channel.GetAll();
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<AcmeCursos.Presentation.ProfessorServiceRemote.ProfessorDTO>> GetAllAsync() {
            return base.Channel.GetAllAsync();
        }
        
        public System.Collections.Generic.List<AcmeCursos.Presentation.ProfessorServiceRemote.ProfessorDTO> GetAllWithCursos() {
            return base.Channel.GetAllWithCursos();
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<AcmeCursos.Presentation.ProfessorServiceRemote.ProfessorDTO>> GetAllWithCursosAsync() {
            return base.Channel.GetAllWithCursosAsync();
        }
        
        public AcmeCursos.Presentation.ProfessorServiceRemote.ProfessorDTO Find(int id) {
            return base.Channel.Find(id);
        }
        
        public System.Threading.Tasks.Task<AcmeCursos.Presentation.ProfessorServiceRemote.ProfessorDTO> FindAsync(int id) {
            return base.Channel.FindAsync(id);
        }
        
        public AcmeCursos.Presentation.ProfessorServiceRemote.ProfessorDTO FindWithCursos(int id) {
            return base.Channel.FindWithCursos(id);
        }
        
        public System.Threading.Tasks.Task<AcmeCursos.Presentation.ProfessorServiceRemote.ProfessorDTO> FindWithCursosAsync(int id) {
            return base.Channel.FindWithCursosAsync(id);
        }
        
        public bool Delete(AcmeCursos.Presentation.ProfessorServiceRemote.ProfessorDTO professor) {
            return base.Channel.Delete(professor);
        }
        
        public System.Threading.Tasks.Task<bool> DeleteAsync(AcmeCursos.Presentation.ProfessorServiceRemote.ProfessorDTO professor) {
            return base.Channel.DeleteAsync(professor);
        }
        
        public bool Add(AcmeCursos.Presentation.ProfessorServiceRemote.ProfessorDTO professor) {
            return base.Channel.Add(professor);
        }
        
        public System.Threading.Tasks.Task<bool> AddAsync(AcmeCursos.Presentation.ProfessorServiceRemote.ProfessorDTO professor) {
            return base.Channel.AddAsync(professor);
        }
        
        public bool Update(AcmeCursos.Presentation.ProfessorServiceRemote.ProfessorDTO professor) {
            return base.Channel.Update(professor);
        }
        
        public System.Threading.Tasks.Task<bool> UpdateAsync(AcmeCursos.Presentation.ProfessorServiceRemote.ProfessorDTO professor) {
            return base.Channel.UpdateAsync(professor);
        }
        
        public System.Collections.Generic.List<AcmeCursos.Presentation.ProfessorServiceRemote.ProfessorDTO> GetAllByCurso(int idCurso) {
            return base.Channel.GetAllByCurso(idCurso);
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<AcmeCursos.Presentation.ProfessorServiceRemote.ProfessorDTO>> GetAllByCursoAsync(int idCurso) {
            return base.Channel.GetAllByCursoAsync(idCurso);
        }
    }
}
