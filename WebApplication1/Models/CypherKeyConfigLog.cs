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
    
    public partial class CypherKeyConfigLog
    {
        public int LogID { get; set; }
        public string SerialNumber { get; set; }
        public string OperationPassword { get; set; }
        public string ConfigurationPassword { get; set; }
        public int InitialCounter { get; set; }
        public int MaximumCounter { get; set; }
        public System.DateTime Caducity { get; set; }
        public System.DateTime ConfigurationDate { get; set; }
        public short Operation { get; set; }
        public int RemainingFolios { get; set; }
        public int UserID { get; set; }
        public short Status { get; set; }
    }
}