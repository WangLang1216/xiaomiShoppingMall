//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class shipping_info
    {
        public int ship_id { get; set; }
        public string ship_name { get; set; }
        public string ship_contact { get; set; }
        public string telephone { get; set; }
        public decimal price { get; set; }
        public string modified_time { get; set; }
        public Nullable<decimal> pricenew { get; set; }
        public string imgUrl { get; set; }
        public Nullable<int> product_id { get; set; }
    }
}
