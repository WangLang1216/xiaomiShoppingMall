﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebAPiB.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class EesdSQLEntitiesM : DbContext
    {
        public EesdSQLEntitiesM()
            : base("name=EesdSQLEntitiesM")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<brand_info> brand_info { get; set; }
        public virtual DbSet<customer_addr> customer_addr { get; set; }
        public virtual DbSet<customer_inf> customer_inf { get; set; }
        public virtual DbSet<customer_login> customer_login { get; set; }
        public virtual DbSet<customerLevelInf> customerLevelInf { get; set; }
        public virtual DbSet<order_cart> order_cart { get; set; }
        public virtual DbSet<order_detail> order_detail { get; set; }
        public virtual DbSet<order_master> order_master { get; set; }
        public virtual DbSet<product_category> product_category { get; set; }
        public virtual DbSet<product_comment> product_comment { get; set; }
        public virtual DbSet<product_info> product_info { get; set; }
        public virtual DbSet<productpicinfo> productpicinfo { get; set; }
        public virtual DbSet<shipping_info> shipping_info { get; set; }
        public virtual DbSet<supplier_info> supplier_info { get; set; }
        public virtual DbSet<warehouse_info> warehouse_info { get; set; }
        public virtual DbSet<warehouse_product> warehouse_product { get; set; }
    }
}
