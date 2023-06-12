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
    [RoutePrefix(prefix: "api/Buy")]
    public class BuyController : ApiController
    {
        [Route(template: "AddBuyInfo")]
        [HttpPost]
        /// <summary>
        /// 添加一条购买商品信息
        /// </summary>
        /// <param name="addr"></param>
        /// <returns></returns>
        public bool AddBuyInfo(warehouse_info addr)
        {
            using (EesdSQLEntitiesM DB = new EesdSQLEntitiesM())
            {
                bool Bo = false;
                warehouse_info inf = new warehouse_info();
                if (addr != null)
                {
                    try
                    {
                        inf.warehouse_sn = addr.warehouse_sn;
                        inf.warehoust_name = addr.warehoust_name;
                        inf.warehouse_phone = addr.warehouse_phone;
                        inf.contact = addr.contact;
                        inf.province = addr.province;
                        inf.city = addr.city;
                        inf.distrct = addr.distrct;
                        inf.address = addr.address;
                        inf.warehouse_status = 1;
                        inf.modified_time = DateTime.Now.ToString();                    
                        DB.warehouse_info.Add(inf);
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
        /// 查询所有购买信息
        /// </summary>
        /// <returns></returns>
        [Route(template: "GetBuyInfo")]
        [HttpGet]
        public List<warehouse_info> GetBuyInfo()
        {
            using (EesdSQLEntitiesM DB = new EesdSQLEntitiesM())
            {
                List<warehouse_info> BuyInfo = new List<warehouse_info>();
                List<warehouse_info> tempmodel = DB.warehouse_info.Where(s => s.w_id >= 1).ToList();
                BuyInfo = tempmodel;
                return (BuyInfo);
            }
        }
    }
}
