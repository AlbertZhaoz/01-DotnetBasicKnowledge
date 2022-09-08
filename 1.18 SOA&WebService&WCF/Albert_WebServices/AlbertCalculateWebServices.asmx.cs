using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;

namespace NET_GetStartedWithSOA.Albert_WebServices
{
    /// <summary>
    /// AlbertCalculateWebServices 的摘要说明
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // 若要允许使用 ASP.NET AJAX 从脚本中调用此 Web 服务，请取消注释以下行。 
    // [System.Web.Script.Services.ScriptService]
    public class AlbertCalculateWebServices : System.Web.Services.WebService
    {
        public CustomSoapHeader CustomSoapHeader { get; set; }  

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }

        [WebMethod]
        public int PrintAdd(int x,int y)
        {
            return x + y;
        }

        [WebMethod]
        [SoapHeader(nameof(CustomSoapHeader))]
        public Student GetStuByID(int id)
        {
            return new Student()
            {
                ID = id,
                Name = "Albertzhao",
                Age = 27,
                Description = "Very Nice"
            };
        }

        [WebMethod]
        [SoapHeader(nameof(CustomSoapHeader))]
        public List<Student> GetAllStuByID(int id)
        {
            return new List<Student>()
            {
                new Student()
                {
                    ID = id,
                    Name = "Albertzhao",
                    Age = 27,
                    Description = "Very Nice"
                },
                new Student()
                {
                    ID = id,
                    Name = "Jack",
                    Age = 28,
                    Description = "Nice"
                }
            };
        }

        public class Student
        {
            public int ID { get; set; }
            public string Name { get; set; }
            public int Age { get; set; }
            public string Description { get; set; }
        }
    }
}
