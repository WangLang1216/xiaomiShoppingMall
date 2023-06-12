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
    [RoutePrefix(prefix: "api/Shipping")]
    public class shippingController : ApiController
    {

        /// <summary>
        /// 得到商品信息
        /// </summary>
        /// <param name="ID"></param>
        /// <param name="isNO"></param>
        /// <returns></returns>       
        [Route(template: "Shipping_Info")]
        [HttpGet]
        public List<shipping_info> GetShipping_Info(string PageName)
        {
            using (EesdSQLEntitiesM DB = new EesdSQLEntitiesM())
            {
                List<shipping_info> customer_Infs = new List<shipping_info>();
                List<shipping_info> tempmodel = DB.shipping_info.Where(s => s.modified_time == PageName).ToList();
                customer_Infs = tempmodel;
                return (customer_Infs);
            }
        }
        /// <summary>
        /// 得到所有商品信息
        /// </summary>
        /// <returns></returns>
        [Route(template: "GetShipping_InfoAll")]
        [HttpGet]
        public List<shipping_info> GetShipping_InfoAll()
        {
            using (EesdSQLEntitiesM DB = new EesdSQLEntitiesM())
            {
                List<shipping_info> customer_Infs = new List<shipping_info>();
                List<shipping_info> tempmodel = DB.shipping_info.Where(s => s.ship_id >= 1).ToList();
                customer_Infs = tempmodel;
                return (customer_Infs);
            }
        }
        /// <summary>
        /// 添加商品信息
        /// </summary>
        /// <param name="shipping"></param>
        /// <returns></returns>
        [Route(template: "AddShipping_Info")]
        [HttpPost]
        public bool AddShipping_Info(shipping_info shipping)
        {
            using(EesdSQLEntitiesM DB=new EesdSQLEntitiesM())
            {
                bool Bo = false;

                shipping_info inf = new shipping_info();
                if (shipping != null)
                {
                    try
                    {
                        inf.ship_name = shipping.ship_name;
                        inf.ship_contact = shipping.ship_contact;
                        inf.telephone = shipping.telephone;
                        inf.price = shipping.price;
                        inf.modified_time = shipping.modified_time;
                        inf.pricenew = shipping.pricenew;
                        inf.imgUrl = shipping.imgUrl;                      
                        inf.product_id = shipping.product_id;                     
                        DB.shipping_info.Add(inf);
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
        /// <summary>
        /// 修改一条商品信息
        /// </summary>
        /// <param name="info"></param>
        /// <param name="ID"></param>
        /// <returns></returns>
        [Route(template: "UpDateShipping_Info")]
        [HttpPost]
        public bool UpDateShipping_Info(shipping_info info, int ID)
        {
            using (EesdSQLEntitiesM DB = new EesdSQLEntitiesM())
            {

                bool Bo = false;

                List<shipping_info> customerList = DB.shipping_info.Where(s => s.product_id == ID).ToList();
                if (customerList != null)
                {
                    try
                    {
                        foreach (var item in customerList)
                        {
                            item.ship_name = info.ship_name;
                            item.ship_contact = info.ship_contact;
                            item.telephone = info.telephone;
                            item.price = info.price;
                            item.modified_time = info.modified_time;
                            item.pricenew = info.pricenew;
                            item.imgUrl = info.imgUrl;
                            item.product_id = info.product_id;                           
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
        /// 删除一条商品信息
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        [Route(template: "DeleteShipping_Info")]
        [HttpGet]
        public bool DeleteShipping_Info(int ID)
        {
            using (EesdSQLEntitiesM DB = new EesdSQLEntitiesM())
            {
                bool Bo = false;
                List<shipping_info> customerList = DB.shipping_info.Where(s => s.product_id == ID).ToList();
                if (customerList != null)
                {
                    try
                    {
                        foreach (var item in customerList)
                        {
                            DB.shipping_info.Remove(item);
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
        [Route(template: "ChaShipping_Info")]
        [HttpGet]
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
        [HttpGet]
        [Route(template: "GetInfAll")]
        /// <summary>
        /// 得到所有用户信息
        /// </summary>
        /// <returns></returns>
        public List<customer_inf> GetCustomer_InfsAll()
        {
            using (EesdSQLEntitiesM DB = new EesdSQLEntitiesM())
            {
                List<customer_inf> customer_Infs = new List<customer_inf>();
                List<customer_inf> tempmodel = DB.customer_inf.Where(s => s.customer_inf_id >=1 ).ToList();
                customer_Infs = tempmodel;
                return (customer_Infs);
            }
        }
        /// <summary>
        /// 用户信息ID且名称查询查询
        /// </summary>
        /// <param name="ID"></param>
        /// <param name="Name"></param>
        /// <returns></returns>
        [Route(template: "ChaCustomer_Infs")]
        [HttpGet]
        public List<customer_inf> ChaCustomer_Infs(int ID, string Name)
        {
            using (EesdSQLEntitiesM DB = new EesdSQLEntitiesM())
            {
                List<customer_inf> customer_Infs = new List<customer_inf>();
                List<customer_inf> tempmodel = DB.customer_inf.Where(s => s.customer_inf_id==ID && s.customer_name.Contains(Name)).ToList();
                customer_Infs = tempmodel;
                return (customer_Infs);
            }
        }

        /// <summary>
        /// 用户信息ID查询
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        [Route(template: "ChaCustomer_InfsID")]
        [HttpGet]
        public List<customer_inf> ChaCustomer_InfsID(int ID)
        {
            using (EesdSQLEntitiesM DB = new EesdSQLEntitiesM())
            {
                List<customer_inf> customer_Infs = new List<customer_inf>();
                List<customer_inf> tempmodel = DB.customer_inf.Where(s => s.customer_inf_id == ID).ToList();
                customer_Infs = tempmodel;
                return (customer_Infs);
            }
        }
        /// <summary>
        /// 用户信息名称查询
        /// </summary>
        /// <param name="Name"></param>
        /// <returns></returns>
        [Route(template: "ChaCustomer_InfsName")]
        [HttpGet]
        public List<customer_inf> ChaCustomer_InfsName(string Name)
        {
            using (EesdSQLEntitiesM DB = new EesdSQLEntitiesM())
            {
                List<customer_inf> customer_Infs = new List<customer_inf>();
                List<customer_inf> tempmodel = DB.customer_inf.Where(s => s.customer_name.Contains(Name)).ToList();
                customer_Infs = tempmodel;
                return (customer_Infs);
            }
        }
    }
}
