﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DesktopClientToService.ServiceRefAuction {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Auction", Namespace="http://schemas.datacontract.org/2004/07/WcfServiceWithDatabaseAccess.ModelLayer")]
    [System.SerializableAttribute()]
    public partial class Auction : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int AuctionIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool PaymentField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime PaymentDateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ProductDescriptionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ProductNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ResultField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private decimal TimeLeftField;
        
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
        public int AuctionId {
            get {
                return this.AuctionIdField;
            }
            set {
                if ((this.AuctionIdField.Equals(value) != true)) {
                    this.AuctionIdField = value;
                    this.RaisePropertyChanged("AuctionId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool Payment {
            get {
                return this.PaymentField;
            }
            set {
                if ((this.PaymentField.Equals(value) != true)) {
                    this.PaymentField = value;
                    this.RaisePropertyChanged("Payment");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime PaymentDate {
            get {
                return this.PaymentDateField;
            }
            set {
                if ((this.PaymentDateField.Equals(value) != true)) {
                    this.PaymentDateField = value;
                    this.RaisePropertyChanged("PaymentDate");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ProductDescription {
            get {
                return this.ProductDescriptionField;
            }
            set {
                if ((object.ReferenceEquals(this.ProductDescriptionField, value) != true)) {
                    this.ProductDescriptionField = value;
                    this.RaisePropertyChanged("ProductDescription");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ProductName {
            get {
                return this.ProductNameField;
            }
            set {
                if ((object.ReferenceEquals(this.ProductNameField, value) != true)) {
                    this.ProductNameField = value;
                    this.RaisePropertyChanged("ProductName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Result {
            get {
                return this.ResultField;
            }
            set {
                if ((object.ReferenceEquals(this.ResultField, value) != true)) {
                    this.ResultField = value;
                    this.RaisePropertyChanged("Result");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal TimeLeft {
            get {
                return this.TimeLeftField;
            }
            set {
                if ((this.TimeLeftField.Equals(value) != true)) {
                    this.TimeLeftField = value;
                    this.RaisePropertyChanged("TimeLeft");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceRefAuction.IAuctionService")]
    public interface IAuctionService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAuctionService/GetAuctionById", ReplyAction="http://tempuri.org/IAuctionService/GetAuctionByIdResponse")]
        DesktopClientToService.ServiceRefAuction.Auction GetAuctionById(int auctionId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAuctionService/GetAuctionById", ReplyAction="http://tempuri.org/IAuctionService/GetAuctionByIdResponse")]
        System.Threading.Tasks.Task<DesktopClientToService.ServiceRefAuction.Auction> GetAuctionByIdAsync(int auctionId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAuctionService/AddAuction", ReplyAction="http://tempuri.org/IAuctionService/AddAuctionResponse")]
        bool AddAuction(DesktopClientToService.ServiceRefAuction.Auction auctionToAdd);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAuctionService/AddAuction", ReplyAction="http://tempuri.org/IAuctionService/AddAuctionResponse")]
        System.Threading.Tasks.Task<bool> AddAuctionAsync(DesktopClientToService.ServiceRefAuction.Auction auctionToAdd);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAuctionService/DeleteAuction", ReplyAction="http://tempuri.org/IAuctionService/DeleteAuctionResponse")]
        void DeleteAuction(int auctionId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAuctionService/DeleteAuction", ReplyAction="http://tempuri.org/IAuctionService/DeleteAuctionResponse")]
        System.Threading.Tasks.Task DeleteAuctionAsync(int auctionId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAuctionService/UpdateAuction", ReplyAction="http://tempuri.org/IAuctionService/UpdateAuctionResponse")]
        void UpdateAuction(DesktopClientToService.ServiceRefAuction.Auction auctionToUpdate);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAuctionService/UpdateAuction", ReplyAction="http://tempuri.org/IAuctionService/UpdateAuctionResponse")]
        System.Threading.Tasks.Task UpdateAuctionAsync(DesktopClientToService.ServiceRefAuction.Auction auctionToUpdate);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IAuctionServiceChannel : DesktopClientToService.ServiceRefAuction.IAuctionService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class AuctionServiceClient : System.ServiceModel.ClientBase<DesktopClientToService.ServiceRefAuction.IAuctionService>, DesktopClientToService.ServiceRefAuction.IAuctionService {
        
        public AuctionServiceClient() {
        }
        
        public AuctionServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public AuctionServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AuctionServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AuctionServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public DesktopClientToService.ServiceRefAuction.Auction GetAuctionById(int auctionId) {
            return base.Channel.GetAuctionById(auctionId);
        }
        
        public System.Threading.Tasks.Task<DesktopClientToService.ServiceRefAuction.Auction> GetAuctionByIdAsync(int auctionId) {
            return base.Channel.GetAuctionByIdAsync(auctionId);
        }
        
        public bool AddAuction(DesktopClientToService.ServiceRefAuction.Auction auctionToAdd) {
            return base.Channel.AddAuction(auctionToAdd);
        }
        
        public System.Threading.Tasks.Task<bool> AddAuctionAsync(DesktopClientToService.ServiceRefAuction.Auction auctionToAdd) {
            return base.Channel.AddAuctionAsync(auctionToAdd);
        }
        
        public void DeleteAuction(int auctionId) {
            base.Channel.DeleteAuction(auctionId);
        }
        
        public System.Threading.Tasks.Task DeleteAuctionAsync(int auctionId) {
            return base.Channel.DeleteAuctionAsync(auctionId);
        }
        
        public void UpdateAuction(DesktopClientToService.ServiceRefAuction.Auction auctionToUpdate) {
            base.Channel.UpdateAuction(auctionToUpdate);
        }
        
        public System.Threading.Tasks.Task UpdateAuctionAsync(DesktopClientToService.ServiceRefAuction.Auction auctionToUpdate) {
            return base.Channel.UpdateAuctionAsync(auctionToUpdate);
        }
    }
}
