﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ServerApplication.ClientService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ClientComputer", Namespace="http://schemas.datacontract.org/2004/07/SeanLynch.YearFourProject.ProofOfConcept." +
        "WCFPOC")]
    [System.SerializableAttribute()]
    public partial class ClientComputer : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int CPUUsageField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ComputerNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string[] RunningProcessesField;
        
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
        public int CPUUsage {
            get {
                return this.CPUUsageField;
            }
            set {
                if ((this.CPUUsageField.Equals(value) != true)) {
                    this.CPUUsageField = value;
                    this.RaisePropertyChanged("CPUUsage");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ComputerName {
            get {
                return this.ComputerNameField;
            }
            set {
                if ((object.ReferenceEquals(this.ComputerNameField, value) != true)) {
                    this.ComputerNameField = value;
                    this.RaisePropertyChanged("ComputerName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string[] RunningProcesses {
            get {
                return this.RunningProcessesField;
            }
            set {
                if ((object.ReferenceEquals(this.RunningProcessesField, value) != true)) {
                    this.RunningProcessesField = value;
                    this.RaisePropertyChanged("RunningProcesses");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ClientService.IComputerData")]
    public interface IComputerData {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IComputerData/GetComputerData", ReplyAction="http://tempuri.org/IComputerData/GetComputerDataResponse")]
        string GetComputerData();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IComputerData/GetComputerData", ReplyAction="http://tempuri.org/IComputerData/GetComputerDataResponse")]
        System.Threading.Tasks.Task<string> GetComputerDataAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IComputerData/GetComputer", ReplyAction="http://tempuri.org/IComputerData/GetComputerResponse")]
        ServerApplication.ClientService.ClientComputer GetComputer();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IComputerData/GetComputer", ReplyAction="http://tempuri.org/IComputerData/GetComputerResponse")]
        System.Threading.Tasks.Task<ServerApplication.ClientService.ClientComputer> GetComputerAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IComputerData/StartProcess", ReplyAction="http://tempuri.org/IComputerData/StartProcessResponse")]
        void StartProcess(string ProcessName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IComputerData/StartProcess", ReplyAction="http://tempuri.org/IComputerData/StartProcessResponse")]
        System.Threading.Tasks.Task StartProcessAsync(string ProcessName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IComputerData/GetClientCPUUsage", ReplyAction="http://tempuri.org/IComputerData/GetClientCPUUsageResponse")]
        int GetClientCPUUsage();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IComputerData/GetClientCPUUsage", ReplyAction="http://tempuri.org/IComputerData/GetClientCPUUsageResponse")]
        System.Threading.Tasks.Task<int> GetClientCPUUsageAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IComputerDataChannel : ServerApplication.ClientService.IComputerData, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ComputerDataClient : System.ServiceModel.ClientBase<ServerApplication.ClientService.IComputerData>, ServerApplication.ClientService.IComputerData {
        
        public ComputerDataClient() {
        }
        
        public ComputerDataClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ComputerDataClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ComputerDataClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ComputerDataClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string GetComputerData() {
            return base.Channel.GetComputerData();
        }
        
        public System.Threading.Tasks.Task<string> GetComputerDataAsync() {
            return base.Channel.GetComputerDataAsync();
        }
        
        public ServerApplication.ClientService.ClientComputer GetComputer() {
            return base.Channel.GetComputer();
        }
        
        public System.Threading.Tasks.Task<ServerApplication.ClientService.ClientComputer> GetComputerAsync() {
            return base.Channel.GetComputerAsync();
        }
        
        public void StartProcess(string ProcessName) {
            base.Channel.StartProcess(ProcessName);
        }
        
        public System.Threading.Tasks.Task StartProcessAsync(string ProcessName) {
            return base.Channel.StartProcessAsync(ProcessName);
        }
        
        public int GetClientCPUUsage() {
            return base.Channel.GetClientCPUUsage();
        }
        
        public System.Threading.Tasks.Task<int> GetClientCPUUsageAsync() {
            return base.Channel.GetClientCPUUsageAsync();
        }
    }
}
