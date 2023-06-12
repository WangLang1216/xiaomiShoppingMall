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
    [RoutePrefix(prefix: "api/Phone")]
    public class PhoneController : ApiController
    {
       
        /// <summary>
        /// 获取手机商品信息
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        [Route(template: "GetBrand_Info")]
        [HttpGet]
        public List<brand_info> GetBrand_Info(int ID)
        {
            using (EesdSQLEntitiesM DB = new EesdSQLEntitiesM())
            {
                List<brand_info> brand_Infos = new List<brand_info>();
                List<brand_info> tempmodel = DB.brand_info.Where(s => s.brand_id == ID).ToList();
                brand_Infos = tempmodel;
                return (brand_Infos);
            }
        }
        /// <summary>
        /// 添加一条手机商品信息
        /// </summary>
        /// <param name="supplier_Info"></param>
        /// <returns></returns>
        [Route(template: "AddBrand_Info")]
        [HttpPost]
        public bool AddSupplier_Info(brand_info brand)
        {
            using (EesdSQLEntitiesM DB = new EesdSQLEntitiesM())
            {
                bool Bo = false;
                brand_info inf = new brand_info();
                if (brand != null)
                {
                    try
                    {
                        inf.brand_name = brand.brand_name;
                        inf.telephone = brand.telephone;
                        inf.brand_web = brand.brand_web;
                        inf.brand_logo = brand.brand_logo;
                        inf.brand_desc = brand.brand_desc;
                        inf.brand_status = brand.brand_status;
                        inf.brand_order = brand.brand_order;
                        inf.modified_time = brand.modified_time;                                            
                        DB.brand_info.Add(inf);
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
        /// 更新一条手机商品信息
        /// </summary>
        /// <param name="customer"></param>
        /// <param name="ID"></param>
        /// <returns></returns>
        [Route(template: " UpDateBrand_Info")]
        [HttpPost]
        public bool UpDateBrand_Info(brand_info customer, int ID)
        {
            using (EesdSQLEntitiesM DB = new EesdSQLEntitiesM())
            {

                bool Bo = false;

                List<brand_info> customerList = DB.brand_info.Where(s => s.brand_id == ID).ToList();
                if (customerList != null)
                {
                    try
                    {
                        foreach (var item in customerList)
                        {
                            item.brand_name = customer.brand_name;
                            item.telephone = customer.telephone;
                            item.brand_web = customer.brand_web;
                            item.brand_logo = customer.brand_logo;
                            item.brand_desc = customer.brand_desc;
                            item.brand_status = customer.brand_status;
                            item.brand_order = customer.brand_order;
                            item.modified_time = customer.modified_time;
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
        /// 删除一条手机商品信息
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        [Route(template: "DeleteSupplier_Info")]
        [HttpGet]
        public bool DeleteSupplier_Info(int ID)
        {
            using (EesdSQLEntitiesM DB = new EesdSQLEntitiesM())
            {
                bool Bo = false;
                List<brand_info> customerList = DB.brand_info.Where(s => s.brand_id == ID).ToList();
                if (customerList != null)
                {
                    try
                    {
                        foreach (var item in customerList)
                        {
                            DB.brand_info.Remove(item);
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
    }
}
