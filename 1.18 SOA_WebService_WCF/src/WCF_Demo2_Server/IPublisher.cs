using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace NET_GetStartedWithSOA_WCF_Demo2_Server
{
    // 注意: 使用“重构”菜单上的“重命名”命令，可以同时更改代码和配置文件中的接口名“IPublisher”。
    [ServiceContract(CallbackContract = typeof(IPublisherEvents))]
    public interface IPublisher
    {
        [OperationContract(IsOneWay = true)]
        void Subscriber(string clientName);      //订阅消息

        [OperationContract(IsOneWay = true)]
        void UnSubscriber(string clientName);    //取消订阅
    }

    public interface IPublisherEvents
    {
        [OperationContract(IsOneWay = true)]
        void PublishMessage(string message);    //发布消息

    }
}
