//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CITSWebApiService.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tb_EmpSalary
    {
        public int ID { get; set; }
        public Nullable<int> EMP_CODE { get; set; }
        public Nullable<System.DateTime> Month { get; set; }
        public Nullable<System.DateTime> Year { get; set; }
        public Nullable<int> PresentDays { get; set; }
        public Nullable<int> AbsentDays { get; set; }
        public Nullable<int> HalfDays { get; set; }
        public Nullable<int> TotalPermission { get; set; }
        public Nullable<int> TotalLateDays { get; set; }
        public Nullable<decimal> BasicSalary { get; set; }
        public Nullable<decimal> LeaveDetect { get; set; }
        public Nullable<decimal> LateDetect { get; set; }
        public Nullable<decimal> Advance { get; set; }
        public Nullable<decimal> NetAmount { get; set; }
        public Nullable<System.DateTime> Creation_Date { get; set; }
        public Nullable<System.DateTime> Update_Date { get; set; }
    
        public virtual tb_Employee tb_Employee { get; set; }
    }
}
