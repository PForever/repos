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
    
    public partial class VKR_Themes_StudyPlans
    {
        public int Id { get; set; }
        public Nullable<int> VKRThemeId { get; set; }
        public Nullable<int> ObrazProgramId { get; set; }
    
        public virtual VKR_Themes VKR_Themes { get; set; }
    }
}
