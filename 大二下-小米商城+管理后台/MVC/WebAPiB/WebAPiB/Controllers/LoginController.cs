using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using WebAPiB.Models ;


namespace WebAPiB.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    [RoutePrefix(prefix: "api/Login")]
    public class LoginController : ApiController
    {
        /// <summary>
        /// 得到一条登录信息
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        [HttpGet]
        [Route(template: "GetLogin")]
        public List<customer_login> GetLogin(string ID)
        {
            using (EesdSQLEntitiesM DB = new EesdSQLEntitiesM())
            {
                List<customer_login> tempmodel = DB.customer_login.Where(s => s.customer_id == ID).ToList();
                List<customer_login> customer = new List<customer_login>();              
                    customer = tempmodel;               
                return customer;
            }
        }
        /// <summary>
        /// 判断是否存在登录信息
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        [HttpGet]
        [Route(template: "BooLogin")]
        public bool BooLogin(string ID)
        {
            using (EesdSQLEntitiesM DB = new EesdSQLEntitiesM())
            {
                bool bo = false;
                List<customer_login> tempmodel = DB.customer_login.Where(s => s.customer_id == ID).ToList();
                if (tempmodel.Count!=0)
                {
                    bo = true;
                }
                return bo;
            }
        }
        /// <summary>
        /// 登录判断
        /// </summary>
        /// <param name="result">返回值</param>
        /// <returns></returns>
        [HttpPost]
        [Route(template: "Logind")]
        public string Login(customer_login data, string result)
        {
            using (EesdSQLEntitiesM DB = new EesdSQLEntitiesM())
            {
                List<customer_login> tempmodel = DB.customer_login.Where(s => s.customer_id == data.customer_id).ToList();
                customer_login customer = new customer_login();
                foreach (var item in tempmodel)
                {
                    customer = item;
                }
                try
                {
                    if (tempmodel.Count == 0)
                    {
                        result = "账号不存在";
                        return (result);
                    }
                    else if (data.password != customer.password)
                    {
                        result = "密码不正确";
                        return (result);
                    }
                    else
                    {
                        result = "登录成功";
                        return (result);
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }


            }
        }
        [HttpPost]
        [Route(template: "LoginU")]
        /// <summary>
        /// 更新登录信息
        /// </summary>
        /// <param name="customer"></param>
        /// <param name="ID"></param>
        /// <returns></returns>
        public bool UpDatecustomer_login(customer_login customer, string ID)
        {
            using (EesdSQLEntitiesM DB = new EesdSQLEntitiesM())
            {
                bool Bo = false;
                List<customer_login> customerList = DB.customer_login.Where(s => s.customer_id == ID).ToList();
                if (customerList.Count != 0)
                {
                    try
                    {
                        foreach (var item in customerList)
                        {
                            item.customer_id = customer.customer_id;
                            item.login_name = customer.login_name;
                            item.password = customer.password;
                            item.user_stats = customer.user_stats;
                            item.modified_time = DateTime.Now.ToString();
                            DB.SaveChanges();
                        }
                        Bo = true;
                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }
                }
                return Bo;
            }
        }
        [HttpPost]
        [Route(template: "LoginAH")]
        /// <summary>
        /// 添加用户登录信息
        /// </summary>
        /// <param name="customer"></param>
        /// <returns></returns>
        public string Addcustomer_loginH(customer_login customer)
        {
            using (EesdSQLEntitiesM DB = new EesdSQLEntitiesM())
            {
                string Bo = "添加失败";
                List<customer_login> QLogin = DB.customer_login.Where(s => s.Id >= 1).ToList();
                customer_login login = new customer_login();
                if (customer != null)
                {
                    foreach (var item in QLogin)
                    {
                        if (item.customer_id == customer.customer_id)
                        {
                            Bo = "账号已存在";
                            return Bo;
                        }
                    }
                    try
                    {
                        login.customer_id = customer.customer_id;
                        login.login_name = customer.login_name;
                        login.password = customer.password;
                        login.user_stats = "1";
                        login.modified_time = DateTime.Now.ToString();
                        DB.customer_login.Add(login);
                        DB.SaveChanges();
                        Bo = "添加成功";
                        return Bo;
                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }
                }
                return Bo;
            }
        }
        [HttpPost]
        [Route(template: "LoginAQ")]
        public bool Addcustomer_loginQ(customer_login customer)
        {
            using (EesdSQLEntitiesM DB = new EesdSQLEntitiesM())
            {

                bool Bo = false;

                customer_login login = new customer_login();
                if (customer != null)
                {
                    try
                    {



                        login.customer_id = customer.customer_id;
                        login.password = customer.password;
                        login.user_stats = customer.user_stats;
                        login.modified_time = DateTime.Now.ToString();

                        DB.customer_login.Add(login);
                        DB.SaveChanges();
                        Bo = true;



                    }
                    catch (Exception ex)
                    {

                        throw ex;
                    }

                }
                return Bo;


            }
        }
        [HttpGet]
        [Route(template: "DeleteDatecustomer_login")]
        /// <summary>
        /// 删除登录信息
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public bool DeleteDatecustomer_login(string ID)
        {
            using (EesdSQLEntitiesM DB = new EesdSQLEntitiesM())
            {

                bool Bo = false;

                List<customer_login> customerList = DB.customer_login.Where(s => s.customer_id == ID).ToList();
                if (customerList != null)
                {
                    try
                    {
                        foreach (var item in customerList)
                        {
                            DB.customer_login.Remove(item);
                            DB.SaveChanges();

                        }
                        Bo = true;


                    }
                    catch (Exception ex)
                    {

                        throw ex;
                    }

                }
                return Bo;


            }
        }
        [HttpGet]
        [Route(template: "GetInf")]
        /// <summary>
        /// 得到用户信息
        /// </summary>
        /// <param name="ID"></param>
        /// <param name="isNO"></param>
        /// <returns></returns>
        public List<customer_inf> GetCustomer_Infs(string ID)
        {
            using (EesdSQLEntitiesM DB = new EesdSQLEntitiesM())
            {
               
                List<customer_inf> customer_Infs = new List<customer_inf>();
               
                    List<customer_inf> tempmodel = DB.customer_inf.Where(s => s.customer_id == ID).ToList();
                    customer_Infs = tempmodel;
                    return (customer_Infs);
              

            }
        }
        /// <summary>
        /// 判断用户信息是否存在
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        [HttpGet]
        [Route(template: "BoolCustomer_Infs")]
        public bool BoolCustomer_Infs(string ID)
        {
            using (EesdSQLEntitiesM DB = new EesdSQLEntitiesM())
            {
                bool bo = false;
                
                List<customer_inf> customer_Infs = new List<customer_inf>();

                List<customer_inf> tempmodel = DB.customer_inf.Where(s => s.customer_id == ID).ToList();
                if (tempmodel.Count == 0) {

                    bo = true;
                }
                return (bo);


            }
        }
        [HttpPost]
        [Route(template: "UpDateCustomer_Infs")]
        /// <summary>
        /// 更新用户信息
        /// </summary>
        /// <param name="customer"></param>
        /// <param name="ID"></param>
        /// <returns></returns>
        public bool UpDatecustomer_inf(customer_inf customer, string ID)
        {
            using (EesdSQLEntitiesM DB = new EesdSQLEntitiesM())
            {

                bool Bo = false;

                List<customer_inf> customerList = DB.customer_inf.Where(s => s.customer_id == ID).ToList();
                if (customerList.Count != 0)
                {
                    try
                    {
                        foreach (var item in customerList)
                        {                      
                            item.customer_name = customer.customer_name;
                            item.identity_card_type = customer.identity_card_type;
                            item.identity_card_num = customer.identity_card_num;
                            item.mobile_phone = customer.mobile_phone;
                            item.customer_email = customer.customer_email;
                            item.sex = customer.sex;
                            item.birthday = DateTime.Now;
                            item.user_money = customer.user_money;
                            item.customer_level = customer.customer_level;
                            item.ReceivingAddress = customer.ReceivingAddress;
                            DB.SaveChanges();
                        }
                        Bo = true;
                    }
                    catch (Exception ex)
                    {

                        throw ex;
                    }

                }
                return Bo;


            }
        }
        [HttpPost]
        [Route(template: "AddCustomer_Inf")]
        /// <summary>
        /// 添加用户信息
        /// </summary>
        /// <param name="customer"></param>
        /// <returns></returns>
        public bool Addcustomer_inf(customer_inf customer)
        {
            using (EesdSQLEntitiesM DB = new EesdSQLEntitiesM())
            {

                bool Bo = false;

                customer_inf inf = new customer_inf();
                if (customer != null)
                {
                    try
                    {


                        inf.customer_id = customer.customer_id;
                        inf.customer_name = customer.customer_name;
                        inf.identity_card_type = customer.identity_card_type;
                        inf.identity_card_num = customer.identity_card_num;
                        inf.mobile_phone = customer.mobile_phone;
                        inf.customer_email = customer.customer_email;
                        inf.sex = customer.sex;                      
                        inf.register_time = DateTime.Now.ToString();
                        inf.birthday = DateTime.Now;
                        inf.user_money = customer.user_money;
                        inf.customer_level = customer.customer_level;
                        inf.ReceivingAddress = customer.ReceivingAddress;
                        inf.modified_time = DateTime.Now.ToString();
                        inf.user_point = "11";
                        DB.customer_inf.Add(inf);
                        DB.SaveChanges();
                        
                        Bo = true;



                    }
                    catch (Exception ex)
                    {

                        throw ex;
                    }

                }
                return Bo;


            }
        }
        [HttpGet]
        [Route(template: "DeleteDatecustomer_inf")]
        /// <summary>
        /// 删除用户信息
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public bool DeleteDatecustomer_inf(string ID)
        {
            using (EesdSQLEntitiesM DB = new EesdSQLEntitiesM())
            {

                bool Bo = false;

                List<customer_inf> customerList = DB.customer_inf.Where(s => s.customer_id == ID).ToList();
                if (customerList != null)
                {
                    try
                    {
                        foreach (var item in customerList)
                        {
                            DB.customer_inf.Remove(item);
                            DB.SaveChanges();

                        }
                        Bo = true;


                    }
                    catch (Exception ex)
                    {

                        throw ex;
                    }

                }
                return Bo;


            }
        }
        /// <summary>
        /// 商品名称查询
        /// </summary>
        /// <param name="ShipName"></param>
        /// <returns></returns>
        [HttpGet]
        [Route(template: "ChaShipping_Info")]       
        public List<shipping_info> ChaShipping_Info(string ShipName)
        {
            using (EesdSQLEntitiesM DB = new EesdSQLEntitiesM())
            {
                List<shipping_info> customer_Infs = new List<shipping_info>();
                List<shipping_info> tempmodel = DB.shipping_info.Where(s => s.ship_name.Contains(ShipName)).ToList();
                customer_Infs = tempmodel;
                return (customer_Infs);
            }
        }



    }
}
