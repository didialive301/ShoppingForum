//------------------------------------------------------------------------------
// <auto-generated>
//     這個程式碼是由範本產生。
//
//     對這個檔案進行手動變更可能導致您的應用程式產生未預期的行為。
//     如果重新產生程式碼，將會覆寫對這個檔案的手動變更。
// </auto-generated>
//------------------------------------------------------------------------------

namespace prjShoppingForum.Models.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class tOrderDetail
    {
        public int fOrderDetailId { get; set; }
        public long fOrderId { get; set; }
        public int fProductId { get; set; }
        public Nullable<int> fOrderQuantity { get; set; }
        public string fPayment { get; set; }
    
        public virtual tOrder tOrder { get; set; }
        public virtual tProduct tProduct { get; set; }
    }
}
