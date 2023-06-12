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
    [RoutePrefix(prefix: "api/Index")]
    public class IndexController : ApiController
        
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
                List<shipping_info> tempmodel = DB.shipping_info.Where(s => s.ship_id >=1).ToList();
                customer_Infs = tempmodel;
                return (customer_Infs);
            }
        }
        /// <summary>
        /// 查询用户信息
        /// </summary>
        /// <param name="ID">用户ID</param>
        /// <returns></returns>
        [Route(template: "Customer_Infs")]
        [HttpGet]
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
        /// 添加一条用户地址信息
        /// </summary>
        /// <param name="addr"></param>
        /// <returns></returns>
        [Route(template: "AddCustomer_Addrs")]
        [HttpPost]
        public bool AddCustomer_Addrs(customer_addr addr)
        {
            using (EesdSQLEntitiesM DB = new EesdSQLEntitiesM())
            {
                bool Bo = false;
                customer_addr inf = new customer_addr();
                if (addr != null)
                {
                    try
                    {
                        inf.customer_id = addr.customer_id;
                        inf.zip = addr.zip;
                        inf.province = addr.province;
                        inf.city = addr.city;
                        inf.district = addr.district;
                        inf.address = addr.address;
                        inf.is_default = addr.is_default;
                        inf.modified_time = DateTime.Now.ToString();                       
                        DB.customer_addr.Add(inf);
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
        /// 删除一条用户地址信息
        /// </summary>
        /// <param name="ID">用户ID</param>
        /// <returns></returns>
        [Route(template: "DeleteCustomer_Addrs")]
        [HttpGet]
        public bool DeleteCustomer_Addrs(string ID)
        {
            using (EesdSQLEntitiesM DB = new EesdSQLEntitiesM())
            {
                bool Bo = false;
                List<customer_addr> customerList = DB.customer_addr.Where(s => s.customer_id == ID).ToList();
                if (customerList != null)
                {
                    try
                    {
                        foreach (var item in customerList)
                        {
                            DB.customer_addr.Remove(item);
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
        /// 更新一条用户地址信息
        /// </summary>
        /// <param name="customer"></param>
        /// <param name="ID">用户ID</param>
        /// <returns></returns>
        [Route(template: "UpDateCustomer_Addrs")]
        [HttpPost]
        public bool UpDateCustomer_Addrs(customer_addr customer, string ID)
        {
            using (EesdSQLEntitiesM DB = new EesdSQLEntitiesM())
            {

                bool Bo = false;

                List<customer_addr> customerList = DB.customer_addr.Where(s => s.customer_id == ID).ToList();
                if (customerList != null)
                {
                    try
                    {
                        foreach (var item in customerList)
                        {
                            item.zip = customer.zip;
                            item.province = customer.province;
                            item.city = customer.city;
                            item.district = customer.district;
                            item.address = customer.address;
                            item.is_default = customer.is_default;
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
        /// <summary>
        /// 获取用户地址信息
        /// </summary>
        /// <param name="ID">用户ID</param>
        /// <returns></returns>
        [Route(template: "Customer_Addrs")]
        [HttpGet]
        public List<customer_addr> GetCustomer_Addr(string ID)
        {
            using (EesdSQLEntitiesM DB = new EesdSQLEntitiesM())
            {
                List<customer_addr> customer_Addrs = new List<customer_addr>();                           
                    List<customer_addr> tempmodel = DB.customer_addr.Where(s => s.customer_id == ID).ToList();
                 customer_Addrs = tempmodel;
                    return (customer_Addrs);             
            }
        }
        /// <summary>
        /// 获取供应商信息
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        [Route(template: "Supplier_Info")]
        [HttpGet]
        public List<supplier_info> GetSupplier_Info(int ID)
        {
            using (EesdSQLEntitiesM DB = new EesdSQLEntitiesM())
            {
                List<supplier_info> supplier_Infos = new List<supplier_info>();
                List<supplier_info> tempmodel = DB.supplier_info.Where(s => s.supplier_status == ID).ToList();
                supplier_Infos = tempmodel;
                return (supplier_Infos);
            }
        }
        /// <summary>
        /// 添加一条供应商信息
        /// </summary>
        /// <param name="supplier_Info"></param>
        /// <returns></returns>
        [Route(template: "AddSupplier_Info")]
        [HttpPost]
        public bool AddSupplier_Info(supplier_info  supplier_Info)
        {
            using (EesdSQLEntitiesM DB = new EesdSQLEntitiesM())
            {
                bool Bo = false;
                supplier_info inf = new supplier_info();
                if (supplier_Info != null)
                {
                    try
                    {
                        inf.supplier_code = supplier_Info.supplier_code;
                        inf.supplier_name = supplier_Info.supplier_name;
                        inf.supplier_type = supplier_Info.supplier_type;
                        inf.link_man = supplier_Info.link_man;
                        inf.phone_number = supplier_Info.phone_number;
                        inf.bank_name = supplier_Info.bank_name;
                        inf.bank_account = supplier_Info.bank_account;
                        inf.address = supplier_Info.address;
                        inf.supplier_status = supplier_Info.supplier_status;           
                        inf.modified_time = DateTime.Now.ToString();
                        DB.supplier_info.Add(inf);
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
        /// 更新一条供应商信息
        /// </summary>
        /// <param name="customer"></param>
        /// <param name="ID"></param>
        /// <returns></returns>
        [Route(template: " UpDateSupplier_Info")]
        [HttpPost]
        public bool UpDateSupplier_Info(supplier_info customer, int ID)
        {
            using (EesdSQLEntitiesM DB = new EesdSQLEntitiesM())
            {

                bool Bo = false;

                List<supplier_info> customerList = DB.supplier_info.Where(s => s.supplier_status == ID).ToList();
                if (customerList != null)
                {
                    try
                    {
                        foreach (var item in customerList)
                        {
                            item.supplier_code = customer.supplier_code;
                            item.supplier_name = customer.supplier_name;
                            item.supplier_type = customer.supplier_type;
                            item.link_man = customer.link_man;
                            item.phone_number = customer.phone_number;
                            item.bank_name = customer.bank_name;
                            item.bank_account = customer.bank_account;
                            item.address = customer.address;
                            item.supplier_status = customer.supplier_status;                  
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
        /// <summary>
        /// 删除一条供应商信息
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
                List<supplier_info> customerList = DB.supplier_info.Where(s => s.supplier_status == ID).ToList();
                if (customerList != null)
                {
                    try
                    {
                        foreach (var item in customerList)
                        {
                            DB.supplier_info.Remove(item);
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
        /// 添加一条评论信息
        /// </summary>
        /// <param name="product"></param>
        /// <returns></returns>
        [Route(template: "AddProduct_Comment")]
        [HttpPost]
        public bool AddProduct_Comment(product_comment product)
        {
            using (EesdSQLEntitiesM DB = new EesdSQLEntitiesM())
            {
                bool Bo = false;
                product_comment inf = new product_comment();
                if (product != null)
                {
                    try
                    {
                        inf.product_id = product.product_id;
                        inf.order_id = product.order_id;
                        inf.customer_id = product.customer_id;
                        inf.title = product.title;
                        inf.Ucontent = product.Ucontent;
                        inf.audit_status = product.audit_status;
                        inf.audit_time = DateTime.Now.ToString();                    
                        inf.modified_time = DateTime.Now.ToString();
                        DB.product_comment.Add(inf);
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
        /// 查询评语信息
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public List<product_comment> GetProduct_Comment(int ID)
        {
            using (EesdSQLEntitiesM DB = new EesdSQLEntitiesM())
            {
                List<product_comment>  comments = new List<product_comment>();
                List<product_comment> tempmodel = DB.product_comment.Where(s => s.product_id == ID).ToList();
                comments = tempmodel;
                return (comments);
            }
        }


    }
}
