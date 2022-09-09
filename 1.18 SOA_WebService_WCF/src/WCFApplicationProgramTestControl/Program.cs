using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET_GetStartedWIthSOA_WCFApplicationProgramTestControl
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AlbertWCF.Service1 service1 = null;
            try
            {
                service1 = new AlbertWCF.Service1();
                service1.GetData(1,true);
                service1.Dispose();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                service1.Abort();
                throw;
            }
        }
    }
}
