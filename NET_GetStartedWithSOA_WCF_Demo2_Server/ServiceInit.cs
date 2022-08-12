using System.Collections.Generic;
using System.ServiceModel;

namespace NET_GetStartedWithSOA_WCF_Demo2_Server
{
    public static class ServiceInit
    {
        //ServiceHost对象
        public static List<ServiceHost> hosts = new List<ServiceHost>()
        {
            new ServiceHost(typeof(FormServer)),
        };

        public static List<string> listProcessingMsg = new List<string>();

        public static void EndProcess()
        {
            foreach (var host in hosts)
            {
                if (host != null)
                {
                    host.Close();
                }
            }
        }

        public static void StartProcess()
        {
            foreach (var host in hosts)
            {
                if(host != null)
                {
                    host.Opening += (s, e) => listProcessingMsg.Add($"{host.Description.Name}——准备打开\n");
                    host.Opened += (s, e) => listProcessingMsg.Add($"{host.Description.Name}——已经正常打开\n");
                    host.Closing += (s, e) => listProcessingMsg.Add($"{host.Description.Name}——准备关闭\n");
                    host.Closed += (s, e) => listProcessingMsg.Add($"{host.Description.Name}——准备关闭\n");
                    host.Open();
                }
            }
        }
    }
}
