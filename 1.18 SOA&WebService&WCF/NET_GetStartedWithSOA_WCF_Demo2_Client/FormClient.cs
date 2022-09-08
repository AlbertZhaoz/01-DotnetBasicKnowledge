using System;
using System.Drawing;
using System.ServiceModel;
using System.Windows.Forms;
using NET_GetStartedWithSOA_WCF_Demo2_Client.WcfServerDuplex;

namespace NET_GetStartedWithSOA_WCF_Demo2_Client
{
    public partial class FormClient : Form,IPublisherCallback
    {
        private PublisherClient _publisher ;
        private string _clientName ;
        public FormClient()
        {
            InitializeComponent();
            
        }

        private void FormClient_Load(object sender, EventArgs e)
        {
            // 实例化服务器发布者
            _publisher= new PublisherClient(new InstanceContext(this));
            _clientName = Guid.NewGuid().ToString();
            this.button_UnSub.Enabled = false;
        }

        public void PublishMessage(string message)
        {
            var msg = $"来自服务端的广播消息 : {message}\r\n";
            textBox_Msg.AppendText(msg);
        }

        private void button_Sub_Click(object sender, EventArgs e)
        {
            this.button_Sub.Enabled = false;
            this.button_UnSub.Enabled = true;
            this.button_UnSub.BackColor = Color.White;
            this.button_Sub.BackColor = Color.Green;
            _publisher.Subscriber(_clientName);
        }

        private void button_UnSub_Click(object sender, EventArgs e)
        {
            this.button_UnSub.Enabled = false;
            this.button_Sub.Enabled = true;
            this.button_Sub.BackColor = Color.White;
            this.button_UnSub.BackColor = Color.Red;
            _publisher.UnSubscriber(_clientName);
        }
    }
}
