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
    
    public partial class GAK_MemberNPR_log
    {
        public int Id { get; set; }
        public int GAK_Number_logId { get; set; }
        public int GAK_MemberNPRId { get; set; }
        public int GAK_NumberId { get; set; }
        public string NPR_Persnum { get; set; }
        public string NPR_Tabnum { get; set; }
        public string NPR_FIO { get; set; }
        public string NPR_Position { get; set; }
        public string NPR_Degree { get; set; }
        public string NPR_Rank { get; set; }
        public string NPR_Account { get; set; }
        public string NPR_Chair { get; set; }
        public string NPR_Faculty { get; set; }
        public string Comment { get; set; }
        public Nullable<bool> IsAbsent { get; set; }
        public string AuthorUpdated { get; set; }
        public Nullable<System.DateTime> DateUpdated { get; set; }
        public string Author { get; set; }
        public Nullable<System.DateTime> DateCreated { get; set; }
        public string AuthorLog { get; set; }
        public Nullable<System.DateTime> DateCreatedLog { get; set; }
    
        public virtual GAK_Number_log GAK_Number_log { get; set; }
    }
}
