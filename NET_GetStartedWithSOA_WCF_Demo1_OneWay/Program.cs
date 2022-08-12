using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace NET_GetStartedWithSOA_WCF_Demo1_OneWay
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (ServiceHost oneWayHost = new ServiceHost(typeof(OneWay)))
            {
                oneWayHost.Opened += (s,e)=>
                {
                    Console.WriteLine("单向通讯服务已经启动，按任意键终止！");
                };
 
                oneWayHost.Open();
                Console.Read();
            }
        }
    }
}
