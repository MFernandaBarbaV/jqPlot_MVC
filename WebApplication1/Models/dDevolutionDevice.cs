//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication1.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class dDevolutionDevice
    {
        public int DevolutionID { get; set; }
        public int DeviceID { get; set; }
        public int AssignationID { get; set; }
        public Nullable<int> ParentID { get; set; }
    
        public virtual dAssignationDevice dAssignationDevice { get; set; }
        public virtual mDevolutions mDevolutions { get; set; }
    }
}