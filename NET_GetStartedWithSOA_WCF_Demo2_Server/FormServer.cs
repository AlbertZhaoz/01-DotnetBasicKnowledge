using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Windows.Forms;

namespace NET_GetStartedWithSOA_WCF_Demo2_Server
{
    // 这里把窗体类作为服务了，宿主为窗体
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]   
    public partial class FormServer : Form,IPublisher
    {
        
        //定义回调客户端集合
        public static List<IPublisherEvents> ClientCallbackList { get; set; }

        public FormServer()
        {
            InitializeComponent();
            ClientCallbackList = new List<IPublisherEvents>();
        }

        private void FormServer_Load(object sender, EventArgs e)
        {
            ServiceInit.StartProcess();
            foreach (var msg in ServiceInit.listProcessingMsg)
            {
                this.textBox_Log.AppendText(msg+"\r\n");
            }
        }

        /// <summary>
        /// 实现订阅
        /// </summary>
        /// <param name="clientName"></param>
        public void Subscriber(string clientName)
        {
            var client = OperationContext.Current.GetCallbackChannel<IPublisherEvents>();
            var msgClient = $"客户端{clientName}——开始订阅消息";
            // Invoke
            // textBox_Log.Invoke(new EventHandler(delegate {this.textBox_Log.AppendText(msgClient);}));

            OperationContext.Current.Channel.Closing += Channel_Closing;
            ClientCallbackList.Add(client);

            MessageBox.Show(msgClient);
        }

        /// <summary>
        /// 取消订阅
        /// </summary>
        /// <param name="clientName"></param>
        public void UnSubscriber(string clientName)
        {
            var client = OperationContext.Current.GetCallbackChannel<IPublisherEvents>();
            var sessionid = OperationContext.Current.SessionId;
            var msgClient = $"客户端{clientName}——取消订阅消息";

            OperationContext.Current.Channel.Closing += Channel_Closing;
            ClientCallbackList.Remove(client);

            //this.textBox_Log.AppendText(msgClient+"\r\n");
            MessageBox.Show(msgClient);
        }

        private void FormServer_FormClosing(object sender, FormClosingEventArgs e)
        {
            ServiceInit.EndProcess();
            foreach (var msg in ServiceInit.listProcessingMsg)
            {
                this.textBox_Log.AppendText(msg+"\r\n");
            }
        }

        //关闭通道，移除回调客户端
        private void Channel_Closing(object sender, EventArgs e)
        {
            lock (ClientCallbackList)
            {
                ClientCallbackList.Remove((IPublisherEvents)sender);
            }
        }

        /// <summary>
        /// 发布消息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uiButton_Publish_Click(object sender, EventArgs e)
        {
            var list = ClientCallbackList;
            if (list == null || list.Count == 0)
                return;
            lock (list)
            {
                foreach (var clientCallback in list)
                {
                    clientCallback.PublishMessage(this.uiTextBox_Msg.Text);
                }
            }
        }
    }
}
