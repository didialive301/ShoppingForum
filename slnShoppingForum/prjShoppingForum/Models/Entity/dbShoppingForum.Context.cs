﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class dbShoppingForumEntities : DbContext
    {
        public dbShoppingForumEntities()
            : base("name=dbShoppingForumEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<tCategory> tCategories { get; set; }
        public virtual DbSet<tDiscount> tDiscounts { get; set; }
        public virtual DbSet<tEfficacy> tEfficacies { get; set; }
        public virtual DbSet<tfeature> tfeatures { get; set; }
        public virtual DbSet<tForum> tForums { get; set; }
        public virtual DbSet<tForumAnalysi> tForumAnalysis { get; set; }
        public virtual DbSet<tForumAuth> tForumAuths { get; set; }
        public virtual DbSet<tForumReply> tForumReplies { get; set; }
        public virtual DbSet<tForumReplyAnalysi> tForumReplyAnalysis { get; set; }
        public virtual DbSet<tNote> tNotes { get; set; }
        public virtual DbSet<tOrder> tOrders { get; set; }
        public virtual DbSet<tOrderDetail> tOrderDetails { get; set; }
        public virtual DbSet<tPart> tParts { get; set; }
        public virtual DbSet<tProduct> tProducts { get; set; }
        public virtual DbSet<tProductImage> tProductImages { get; set; }
        public virtual DbSet<tProductUnilateral> tProductUnilaterals { get; set; }
        public virtual DbSet<tProductVegetableoil> tProductVegetableoils { get; set; }
        public virtual DbSet<tQuestion> tQuestions { get; set; }
        public virtual DbSet<tScore> tScores { get; set; }
        public virtual DbSet<tShoppingCart> tShoppingCarts { get; set; }
        public virtual DbSet<tTest> tTests { get; set; }
        public virtual DbSet<tUserBrowseHistory> tUserBrowseHistories { get; set; }
        public virtual DbSet<tUserDiscountList> tUserDiscountLists { get; set; }
        public virtual DbSet<tUserFavorite> tUserFavorites { get; set; }
        public virtual DbSet<tUserLog> tUserLogs { get; set; }
        public virtual DbSet<tUserProductFavorite> tUserProductFavorites { get; set; }
        public virtual DbSet<tUserProfile> tUserProfiles { get; set; }
        public virtual DbSet<tAdminManager> tAdminManagers { get; set; }
    }
}
