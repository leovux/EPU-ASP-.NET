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
    
    public partial class TypeMenu
    {
        public TypeMenu()
        {
            this.Menus = new HashSet<Menu>();
        }
    
        public int TypeMenuId { get; set; }
        public string TypeMenuName { get; set; }
        public Nullable<int> DepartmentId { get; set; }
        public Nullable<int> Status { get; set; }
    
        public virtual ICollection<Menu> Menus { get; set; }
    }
}
