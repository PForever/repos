//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LogicTest
{
    using System;
    using System.Collections.Generic;
    
    public partial class VKR_ThemesStudentOrder_Log
    {
        public int OrdId { get; set; }
        public int Id { get; set; }
        public string FIO { get; set; }
        public Nullable<int> GraduateYear { get; set; }
        public string StatusName { get; set; }
        public string Priority { get; set; }
        public string VKRName { get; set; }
        public string VKRNameEng { get; set; }
        public Nullable<System.Guid> NPRSapId { get; set; }
        public Nullable<System.Guid> NPR_Changed_SapId { get; set; }
        public Nullable<System.Guid> NPR_Changed2_SapId { get; set; }
        public string OrderNumber { get; set; }
        public Nullable<System.DateTime> OrderDate { get; set; }
        public Nullable<int> StudentNumberInOrder { get; set; }
        public string OrderNumberReview { get; set; }
        public Nullable<System.DateTime> OrderDateReview { get; set; }
        public Nullable<int> StudentNumberInOrderReview { get; set; }
        public Nullable<System.Guid> Review_NPR_SapId { get; set; }
        public Nullable<System.Guid> Review_NPR2_SapId { get; set; }
        public Nullable<int> Review_PartnerPersonId { get; set; }
        public Nullable<int> Review_PartnerPersonId2 { get; set; }
        public Nullable<System.Guid> Review_NPR_Changed_SapId { get; set; }
        public Nullable<System.Guid> Review_NPR_Changed2_SapId { get; set; }
        public Nullable<int> Review_PartnerPersonId_Changed2 { get; set; }
        public Nullable<int> Review_PartnerPersonId2_Changed2 { get; set; }
        public string Author { get; set; }
        public System.DateTime Timestamp { get; set; }
        public string Action { get; set; }
    }
}
