﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NewPlatform.RecordBookBL.ServiceReference1 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ОценкаДляПроверки", Namespace="http://tempuri.org/")]
    [System.SerializableAttribute()]
    public partial class ОценкаДляПроверки : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PrimaryKeyField;
        
        private NewPlatform.RecordBookBL.ServiceReference1.ЗначениеОценки MarkField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public string PrimaryKey {
            get {
                return this.PrimaryKeyField;
            }
            set {
                if ((object.ReferenceEquals(this.PrimaryKeyField, value) != true)) {
                    this.PrimaryKeyField = value;
                    this.RaisePropertyChanged("PrimaryKey");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=1)]
        public NewPlatform.RecordBookBL.ServiceReference1.ЗначениеОценки Mark {
            get {
                return this.MarkField;
            }
            set {
                if ((this.MarkField.Equals(value) != true)) {
                    this.MarkField = value;
                    this.RaisePropertyChanged("Mark");
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
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ЗначениеОценки", Namespace="http://tempuri.org/")]
    public enum ЗначениеОценки : int {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        НетОценки = 0,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Удовлетворительно = 1,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Хорошо = 2,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Отлично = 3,
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.CollectionDataContractAttribute(Name="ArrayOfString", Namespace="http://tempuri.org/", ItemName="string")]
    [System.SerializableAttribute()]
    public class ArrayOfString : System.Collections.Generic.List<string> {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.CheckExamSoap")]
    public interface CheckExamSoap {
        
        // CODEGEN: Generating message contract since element name оценки from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/CheckChangedMarks", ReplyAction="*")]
        NewPlatform.RecordBookBL.ServiceReference1.CheckChangedMarksResponse CheckChangedMarks(NewPlatform.RecordBookBL.ServiceReference1.CheckChangedMarksRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/CheckChangedMarks", ReplyAction="*")]
        System.Threading.Tasks.Task<NewPlatform.RecordBookBL.ServiceReference1.CheckChangedMarksResponse> CheckChangedMarksAsync(NewPlatform.RecordBookBL.ServiceReference1.CheckChangedMarksRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class CheckChangedMarksRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="CheckChangedMarks", Namespace="http://tempuri.org/", Order=0)]
        public NewPlatform.RecordBookBL.ServiceReference1.CheckChangedMarksRequestBody Body;
        
        public CheckChangedMarksRequest() {
        }
        
        public CheckChangedMarksRequest(NewPlatform.RecordBookBL.ServiceReference1.CheckChangedMarksRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class CheckChangedMarksRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public NewPlatform.RecordBookBL.ServiceReference1.ОценкаДляПроверки[] оценки;
        
        public CheckChangedMarksRequestBody() {
        }
        
        public CheckChangedMarksRequestBody(NewPlatform.RecordBookBL.ServiceReference1.ОценкаДляПроверки[] оценки) {
            this.оценки = оценки;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class CheckChangedMarksResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="CheckChangedMarksResponse", Namespace="http://tempuri.org/", Order=0)]
        public NewPlatform.RecordBookBL.ServiceReference1.CheckChangedMarksResponseBody Body;
        
        public CheckChangedMarksResponse() {
        }
        
        public CheckChangedMarksResponse(NewPlatform.RecordBookBL.ServiceReference1.CheckChangedMarksResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class CheckChangedMarksResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public NewPlatform.RecordBookBL.ServiceReference1.ArrayOfString CheckChangedMarksResult;
        
        public CheckChangedMarksResponseBody() {
        }
        
        public CheckChangedMarksResponseBody(NewPlatform.RecordBookBL.ServiceReference1.ArrayOfString CheckChangedMarksResult) {
            this.CheckChangedMarksResult = CheckChangedMarksResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface CheckExamSoapChannel : NewPlatform.RecordBookBL.ServiceReference1.CheckExamSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class CheckExamSoapClient : System.ServiceModel.ClientBase<NewPlatform.RecordBookBL.ServiceReference1.CheckExamSoap>, NewPlatform.RecordBookBL.ServiceReference1.CheckExamSoap {
        
        public CheckExamSoapClient() {
        }
        
        public CheckExamSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CheckExamSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CheckExamSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CheckExamSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        NewPlatform.RecordBookBL.ServiceReference1.CheckChangedMarksResponse NewPlatform.RecordBookBL.ServiceReference1.CheckExamSoap.CheckChangedMarks(NewPlatform.RecordBookBL.ServiceReference1.CheckChangedMarksRequest request) {
            return base.Channel.CheckChangedMarks(request);
        }
        
        public NewPlatform.RecordBookBL.ServiceReference1.ArrayOfString CheckChangedMarks(NewPlatform.RecordBookBL.ServiceReference1.ОценкаДляПроверки[] оценки) {
            NewPlatform.RecordBookBL.ServiceReference1.CheckChangedMarksRequest inValue = new NewPlatform.RecordBookBL.ServiceReference1.CheckChangedMarksRequest();
            inValue.Body = new NewPlatform.RecordBookBL.ServiceReference1.CheckChangedMarksRequestBody();
            inValue.Body.оценки = оценки;
            NewPlatform.RecordBookBL.ServiceReference1.CheckChangedMarksResponse retVal = ((NewPlatform.RecordBookBL.ServiceReference1.CheckExamSoap)(this)).CheckChangedMarks(inValue);
            return retVal.Body.CheckChangedMarksResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<NewPlatform.RecordBookBL.ServiceReference1.CheckChangedMarksResponse> NewPlatform.RecordBookBL.ServiceReference1.CheckExamSoap.CheckChangedMarksAsync(NewPlatform.RecordBookBL.ServiceReference1.CheckChangedMarksRequest request) {
            return base.Channel.CheckChangedMarksAsync(request);
        }
        
        public System.Threading.Tasks.Task<NewPlatform.RecordBookBL.ServiceReference1.CheckChangedMarksResponse> CheckChangedMarksAsync(NewPlatform.RecordBookBL.ServiceReference1.ОценкаДляПроверки[] оценки) {
            NewPlatform.RecordBookBL.ServiceReference1.CheckChangedMarksRequest inValue = new NewPlatform.RecordBookBL.ServiceReference1.CheckChangedMarksRequest();
            inValue.Body = new NewPlatform.RecordBookBL.ServiceReference1.CheckChangedMarksRequestBody();
            inValue.Body.оценки = оценки;
            return ((NewPlatform.RecordBookBL.ServiceReference1.CheckExamSoap)(this)).CheckChangedMarksAsync(inValue);
        }
    }
}
