﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Grupperum_Website_Klient.GrumService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Class", Namespace="http://schemas.datacontract.org/2004/07/GrupperumServer.ModelLayer")]
    [System.SerializableAttribute()]
    public partial class Class : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private Grupperum_Website_Klient.GrumService.Student[] StudentListField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int id1Field;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private Grupperum_Website_Klient.GrumService.Student[] studentList1Field;
        
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
        public Grupperum_Website_Klient.GrumService.Student[] StudentList {
            get {
                return this.StudentListField;
            }
            set {
                if ((object.ReferenceEquals(this.StudentListField, value) != true)) {
                    this.StudentListField = value;
                    this.RaisePropertyChanged("StudentList");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Name="id")]
        public int id1 {
            get {
                return this.id1Field;
            }
            set {
                if ((this.id1Field.Equals(value) != true)) {
                    this.id1Field = value;
                    this.RaisePropertyChanged("id1");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Name="studentList")]
        public Grupperum_Website_Klient.GrumService.Student[] studentList1 {
            get {
                return this.studentList1Field;
            }
            set {
                if ((object.ReferenceEquals(this.studentList1Field, value) != true)) {
                    this.studentList1Field = value;
                    this.RaisePropertyChanged("studentList1");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Student", Namespace="http://schemas.datacontract.org/2004/07/GrupperumServer.ModelLayer")]
    [System.SerializableAttribute()]
    public partial class Student : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="GrumService.IGrumService")]
    public interface IGrumService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGrumService/getClassById", ReplyAction="http://tempuri.org/IGrumService/getClassByIdResponse")]
        Grupperum_Website_Klient.GrumService.Class getClassById(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGrumService/getClassById", ReplyAction="http://tempuri.org/IGrumService/getClassByIdResponse")]
        System.Threading.Tasks.Task<Grupperum_Website_Klient.GrumService.Class> getClassByIdAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGrumService/CreateGroupRoom", ReplyAction="http://tempuri.org/IGrumService/CreateGroupRoomResponse")]
        bool CreateGroupRoom(string name, bool whiteboard, bool monitor);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGrumService/CreateGroupRoom", ReplyAction="http://tempuri.org/IGrumService/CreateGroupRoomResponse")]
        System.Threading.Tasks.Task<bool> CreateGroupRoomAsync(string name, bool whiteboard, bool monitor);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IGrumServiceChannel : Grupperum_Website_Klient.GrumService.IGrumService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class GrumServiceClient : System.ServiceModel.ClientBase<Grupperum_Website_Klient.GrumService.IGrumService>, Grupperum_Website_Klient.GrumService.IGrumService {
        
        public GrumServiceClient() {
        }
        
        public GrumServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public GrumServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public GrumServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public GrumServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public Grupperum_Website_Klient.GrumService.Class getClassById(int id) {
            return base.Channel.getClassById(id);
        }
        
        public System.Threading.Tasks.Task<Grupperum_Website_Klient.GrumService.Class> getClassByIdAsync(int id) {
            return base.Channel.getClassByIdAsync(id);
        }
        
        public bool CreateGroupRoom(string name, bool whiteboard, bool monitor) {
            return base.Channel.CreateGroupRoom(name, whiteboard, monitor);
        }
        
        public System.Threading.Tasks.Task<bool> CreateGroupRoomAsync(string name, bool whiteboard, bool monitor) {
            return base.Channel.CreateGroupRoomAsync(name, whiteboard, monitor);
        }
    }
}