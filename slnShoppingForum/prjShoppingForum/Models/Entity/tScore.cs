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
    
    public partial class tScore
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tScore()
        {
            this.tTests = new HashSet<tTest>();
        }
    
        public int fId { get; set; }
        public Nullable<int> fScore { get; set; }
        public Nullable<int> fActiveScore { get; set; }
        public Nullable<int> fQuestionScore { get; set; }
        public Nullable<System.DateTime> fScoreDate { get; set; }
        public Nullable<bool> fAuthTestFlag { get; set; }
    
        public virtual tUserProfile tUserProfile { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tTest> tTests { get; set; }
    }
}
