//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EPUWeb.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Menu
    {
        public int MenuId { get; set; }
        public Nullable<int> CategoryId { get; set; }
        public Nullable<int> TypeMenuId { get; set; }
        public Nullable<int> Location { get; set; }
        public Nullable<int> MenuParentId { get; set; }
        public Nullable<System.DateTime> CreatedAt { get; set; }
        public Nullable<System.DateTime> UpdatedAt { get; set; }
        public Nullable<int> UserId { get; set; }
        public int Status { get; set; }
    
        public virtual TypeMenu TypeMenu { get; set; }
    }
}
