//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace NET_GetStartedWithSOA_WCF_Demo2_Client.WcfServerDuplex {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="WcfServerDuplex.IPublisher", CallbackContract=typeof(NET_GetStartedWithSOA_WCF_Demo2_Client.WcfServerDuplex.IPublisherCallback))]
    public interface IPublisher {
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IPublisher/Subscriber")]
        void Subscriber(string clientName);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IPublisher/Subscriber")]
        System.Threading.Tasks.Task SubscriberAsync(string clientName);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IPublisher/UnSubscriber")]
        void UnSubscriber(string clientName);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IPublisher/UnSubscriber")]
        System.Threading.Tasks.Task UnSubscriberAsync(string clientName);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IPublisherCallback {
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IPublisher/PublishMessage")]
        void PublishMessage(string message);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IPublisherChannel : NET_GetStartedWithSOA_WCF_Demo2_Client.WcfServerDuplex.IPublisher, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class PublisherClient : System.ServiceModel.DuplexClientBase<NET_GetStartedWithSOA_WCF_Demo2_Client.WcfServerDuplex.IPublisher>, NET_GetStartedWithSOA_WCF_Demo2_Client.WcfServerDuplex.IPublisher {
        
        public PublisherClient(System.ServiceModel.InstanceContext callbackInstance) : 
                base(callbackInstance) {
        }
        
        public PublisherClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName) : 
                base(callbackInstance, endpointConfigurationName) {
        }
        
        public PublisherClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, string remoteAddress) : 
                base(callbackInstance, endpointConfigurationName, remoteAddress) {
        }
        
        public PublisherClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(callbackInstance, endpointConfigurationName, remoteAddress) {
        }
        
        public PublisherClient(System.ServiceModel.InstanceContext callbackInstance, System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(callbackInstance, binding, remoteAddress) {
        }
        
        public void Subscriber(string clientName) {
            base.Channel.Subscriber(clientName);
        }
        
        public System.Threading.Tasks.Task SubscriberAsync(string clientName) {
            return base.Channel.SubscriberAsync(clientName);
        }
        
        public void UnSubscriber(string clientName) {
            base.Channel.UnSubscriber(clientName);
        }
        
        public System.Threading.Tasks.Task UnSubscriberAsync(string clientName) {
            return base.Channel.UnSubscriberAsync(clientName);
        }
    }
}
