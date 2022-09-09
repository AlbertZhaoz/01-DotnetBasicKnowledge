using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Threading;

namespace NET_GetStartedWithSOA_WCF_Demo1_OneWay
{
    // 注意: 使用“重构”菜单上的“重命名”命令，可以同时更改代码和配置文件中的类名“OneWay”。
    public class OneWay : IOneWay
    {
        public void DoWork()
        {
            // 此处测试线程延时，单工模式不存在数据返回
            // 单工模式多用于记录日志，但是要注意单工模式亦存在队列最大数问题
            Console.WriteLine("开始执行DoWork");
            Thread.Sleep(5000);
            Console.WriteLine("结束执行DoWork");
        }
    }
}
