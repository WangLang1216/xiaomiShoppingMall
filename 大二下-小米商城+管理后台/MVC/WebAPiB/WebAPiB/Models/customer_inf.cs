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
    
    public partial class customer_inf
    {
        public int customer_inf_id { get; set; }
        public string customer_id { get; set; }
        public string customer_name { get; set; }
        public string identity_card_type { get; set; }
        public string identity_card_num { get; set; }
        public string mobile_phone { get; set; }
        public string customer_email { get; set; }
        public string sex { get; set; }
        public string user_point { get; set; }
        public string register_time { get; set; }
        public Nullable<System.DateTime> birthday { get; set; }
        public string customer_level { get; set; }
        public decimal user_money { get; set; }
        public string modified_time { get; set; }
        public string ReceivingAddress { get; set; }
        public byte[] HeadPortrait { get; set; }
    }
}
