using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using WebAPiB.Models;

namespace WebAPiB.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    [RoutePrefix(prefix: "api/Student")]
    public class StudentController : ApiController
    {
        
        public string Get()
        {
            return "god";
        }
        [HttpPost]
        [Route (template:"Login")]
        public bool Login(StudenModel data)
        {
            if (data.LoginName.Length > 2 && data.PassWord == "123456") 
            {
                return true;
            }
            return false;
        }
        [Route (template:"getInfo")]
        public string GetStudentInfo(String loginName)
        {
            return loginName + "用户资料";
        }
    }
}
