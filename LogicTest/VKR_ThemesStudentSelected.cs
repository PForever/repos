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
    
    public partial class VKR_ThemesStudentSelected
    {
        public int Id { get; set; }
        public System.Guid StudentOid { get; set; }
        public int Priority { get; set; }
        public Nullable<int> VKRThemeNPRId { get; set; }
        public Nullable<int> CustomThemeId { get; set; }
        public System.DateTime Timestamp { get; set; }
        public Nullable<bool> FromLK { get; set; }
        public Nullable<bool> Checked { get; set; }
        public Nullable<int> NewId { get; set; }
        public string ProposedNameEng { get; set; }
    
        public virtual VKR_Themes_NPR VKR_Themes_NPR { get; set; }
        public virtual VKR_ThemesStudentCustom VKR_ThemesStudentCustom { get; set; }
    }
}